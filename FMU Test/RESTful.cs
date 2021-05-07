using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FMU_Test
{
    public class RESTful
    {
        HttpClient client = new HttpClient();
        public int SN = 1;
        int tokentime = 50;

        public void GetClient(string ip, string port)
        {
            //初始化
            client.BaseAddress = new Uri("https://" + ip + ":" + port + "/V0/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public int GetTokenTime()
        {
            return tokentime;
        }

        public string GetMD5(string password)
        {
            //获取32位MD5
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedDataBytes;
            hashedDataBytes = md5Hasher.ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(password));
            StringBuilder tmp = new StringBuilder();
            foreach (byte i in hashedDataBytes)
            {
                tmp.Append(i.ToString("x2"));
            }
            return tmp.ToString();
        }

        public string GetMD516(string password)
        {
            //获取16位MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(password)), 4, 8);
            t2 = t2.Replace("-", "").ToLower();
            return t2;
        }

        private string GetEncrypt(string content, string secretKey)
        {
            //获取异或加密
            char[] data = content.ToCharArray();
            char[] key = secretKey.ToCharArray();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key[i % key.Length];
            }
            string str = new string(data);
            return str;
        }

        public async Task<string> GetSeed(string userid, string permission)
        {
            //获取种子
            try
            {
                HttpResponseMessage response = await client.GetAsync("PasswordSeed?UserId=" + userid + "&Permission=" + permission);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                string msg = json["msg"].ToString();
                if (msg == "success")
                {
                    return json["data"]["Seed"].ToString();
                }
                return json["msg"].ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<string> GetToken(string userid, string password, string seed)
        {
            //获取Token
            try
            {
                string md5password = GetMD5(seed + password);
                HttpResponseMessage response = await client.GetAsync("Token?UserId=" + userid + "&Password=" + md5password);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                string msg = json["msg"].ToString();
                tokentime = Convert.ToInt32(json["data"]["PeriodOfValidity"]);
                if (msg == "success")
                {
                    return json["data"]["Token"].ToString();
                }
                return json["msg"].ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async void GetNOP(string userid, string token, string password)
        {
            //空命令，保持连接
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, Order.NOP, password));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
        }

        public async Task<JObject> GetInfo(string userid, string token, Order order, string password)
        {
            //获取信息
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, order, password));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
            return json;
        }

        public async Task<JObject> PostInfo(string userid, string token, string order1, string order2, Order order, string password)
        {
            //发送信息
            JObject json = PostAPI(order1, order2, order);
            HttpContent content = new StringContent(json.ToString());
            HttpResponseMessage response = await client.PostAsync(PostAPI(userid, token, order1, order2, order, password), content);
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
            if (returnjson["msg"].ToString() != "success" && returnjson["msg"].ToString() != "msg not match!") 
            {
                SN--;
            }
            return returnjson;
        }

        public string GetAPI(string userid, string token, Order order, string password)
        {
            //获取Get命令的字符串
            switch (order)
            {
                case Order.NOP:
                    string api = "NOP?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
                    SN++;
                    return api;
                case Order.PyTaskFile:
                    string api2 = "PyTaskFile?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
                    SN++;
                    return api2;
                case Order.PyLib:
                    string api3 = "PyLib?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
                    SN++;
                    return api3;
                case Order.PyRunStat:
                    string api4 = "PyRunStat?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
                    SN++;
                    return api4;
                case Order.SysVersion:
                    string api5 = "SysVersion?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
                    SN++;
                    return api5;
            }
            return "error";
        }

        public JObject PostAPI(string order1, string order2, Order order)
        {
            //获取Post命令的json
            JObject json = new JObject();
            switch (order)
            {
                case Order.Password:
                    order2 = GetEncrypt(order2, order1);
                    order1 = GetMD516(order1);
                    json["OldPassword"] = order1;
                    json["NewPassword"] = order2;
                    return json;
                case Order.PyTaskFile:
                    json["RootPath"] = order1;
                    json["FullFileName"] = order2;
                    return json;
                case Order.PyLib:
                    json["InstallName"] = order1;
                    return json;
                case Order.PyLib2:
                    json["UninstallName"] = order1;
                    return json;
                case Order.PyRunStat:
                    json["Stat"] = order1;
                    json["TaskNames"] = order2;
                    return json;
            }
            return json;
        }

        public string PostAPI(string userid, string token, string order1, string order2, Order order, string password)
        {
            //获取Post命令的字符串
            switch (order)
            {
                case Order.Password:
                    string api = "Password?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&OldPassword=" + GetMD516(password) + "&NewPassword=" + GetEncrypt(order2, password);
                    SN++;
                    return api;
                case Order.PyTaskFile:
                    string api2 = "PyTaskFile?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&RootPath=" + order1 + "&FullFileName=" + order2;
                    SN++;
                    return api2;
                case Order.PyLib:
                    string api3 = "PyLib?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&InstallName=" + order1;
                    SN++;
                    return api3;
                case Order.PyLib2:
                    string api4 = "PyLib?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&UninstallName=" + order1;
                    SN++;
                    return api4;
                case Order.PyRunStat:
                    string api5 = "PyRunStat?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&Stat=" + order1 + "&TaskNames=" + order2;
                    SN++;
                    return api5;
            }
            return "error";
        }

        public enum Order
        {
            Password = 0,
            NOP,
            PyTaskFile,
            PyLib,
            PyLib2,
            PyRunStat,
            SysVersion,
        }
    }
}
