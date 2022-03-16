using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace FMU_Test
{
    public class RESTful
    {
        private HttpClient client = new HttpClient();
        public int SN = 1;
        private int tokentime = 50;
        private bool[] iswait = new bool[7];
        public InfoTools info;
        public bool reconn = false;

        public void GetClient(string ip, string port)
        {
            //初始化
            client = new HttpClient();
            client.BaseAddress = new Uri("https://" + ip + ":" + port + "/V0/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            for (int i = 0; i < 7; i++)
            {
                iswait[i] = false;
            }
        }

        public bool CheckWait()
        {
            //异步方法是否在等待
            return !iswait[0] && !iswait[1] && !iswait[2] && !iswait[3] && !iswait[4] && !iswait[5] && !iswait[6];
        }

        public async Task DisConnect(bool rec)
        {
            //异步等待退出
            while (!CheckWait())
            {
                await Task.Delay(100);
            }
            client.Dispose();
            SN = 1;
            reconn = rec;
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

        public string GetEncrypt(string content, string secretKey)
        {
            //获取异或加密
            char[] data = content.ToCharArray();
            char[] key = secretKey.ToCharArray();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key[i % key.Length];
            }
            string str = new string(data);
            return HttpUtility.UrlDecode(str);
        }

        public async Task<string> GetSeed(string userid, string permission)
        {
            //获取种子
            try
            {
                iswait[0] = true;
                HttpResponseMessage response = await client.GetAsync("PasswordSeed?UserId=" + userid + "&Permission=" + permission);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                string msg = json["msg"].ToString();
                if (msg == "success")
                {
                    iswait[0] = false;
                    return json["data"]["Seed"].ToString();
                }
                iswait[0] = false;
                return json["msg"].ToString();
            }
            catch (Exception e)
            {
                iswait[0] = false;
                throw e;
            }
        }

        public async Task<string> GetToken(string userid, string password, string seed)
        {
            //获取Token
            try
            {
                iswait[1] = true;
                string md5password = GetMD5(seed + password);
                HttpResponseMessage response = await client.GetAsync("Token?UserId=" + userid + "&Password=" + md5password);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                string msg = json["msg"].ToString();
                tokentime = Convert.ToInt32(json["data"]["PeriodOfValidity"]) - 5;
                if (msg == "success")
                {
                    iswait[1] = false;
                    return json["data"]["Token"].ToString();
                }
                iswait[1] = false;
                return json["msg"].ToString();
            }
            catch (Exception e)
            {
                iswait[1] = false;
                throw e;
            }
        }

        public async Task<string> GetNOP(string userid, string token, string password)
        {
            //空命令，保持连接
            iswait[2] = true;
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, Order.NOP, password));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
            if (json["msg"].ToString() != "success")
            {
                SN--;
            }
            if (json["msg"].ToString() == "SN invalid")
            {
                //流水号错误，试探重新发送
                info.AddInfo("流水号错误，开始自动匹配流水号。", 2);
                int temp = SN;
                bool succ = false;
                for (int i = temp - 1; i < temp + 3; i++)
                {
                    SN = i;
                    response = await client.GetAsync(GetAPI(userid, token, Order.NOP, password));
                    responseBody = await response.Content.ReadAsStringAsync();
                    json = (JObject)JsonConvert.DeserializeObject(responseBody);
                    if (json["msg"].ToString() != "SN invalid")
                    {
                        succ = true;
                        info.AddInfo("流水号匹配成功！当前流水号：" + (SN - 1).ToString(), 1);
                        break;
                    }
                }
                if (!succ)
                {
                    throw new Exception(string.Format("流水号错误，匹配失败。"));
                }
            }
            iswait[2] = false;
            return json["msg"].ToString();
        }

        public async Task<JObject> GetInfo(string userid, string token, Order order, string password)
        {
            //获取信息
            iswait[3] = true;
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, order, password));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
            if (json["msg"].ToString() == "SN invalid")
            {
                //流水号错误，试探重新发送
                info.AddInfo("流水号错误，开始自动匹配流水号。", 2);
                int temp = SN;
                bool succ = false;
                for (int i = temp - 2; i < temp + 3; i++)
                {
                    SN = i;
                    response = await client.GetAsync(GetAPI(userid, token, order, password));
                    responseBody = await response.Content.ReadAsStringAsync();
                    json = (JObject)JsonConvert.DeserializeObject(responseBody);
                    if (json["msg"].ToString() != "SN invalid")
                    {
                        succ = true;
                        info.AddInfo("流水号匹配成功！当前流水号：" + (SN - 1).ToString(), 1);
                        break;
                    }
                }
                if (!succ)
                {
                    throw new Exception(string.Format("流水号错误，匹配失败。"));
                }
            }
            iswait[3] = false;
            return json;
        }

        public async Task<JObject> GetInfo(string userid, string token, string order, string password)
        {
            //获取信息
            iswait[4] = true;
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, order, password));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
            iswait[4] = false;
            return json;
        }

        public HttpContent GetJsonContent(string order2, Order order)
        {
            //获取json字符串
            string str = "";
            HttpContent content = new StringContent(str);
            if (order == Order.PyRunStat && order2 != "")
            {
                JObject js = new JObject();
                string[] a = order2.Split(',');
                JArray ja = new JArray(a);
                js.Add("TaskNames", ja);
                string jss = JsonConvert.SerializeObject(js);//用序列化才能得到正确的字符串
                content = new StringContent(jss);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return content;
            }
            return content;
        }

        public async Task<JObject> PostInfo(string userid, string token, string order1, string order2, Order order, string password, string seed = "")
        {
            //发送信息
            iswait[5] = true;
            HttpContent content = GetJsonContent(order2, order);
            HttpResponseMessage response = await client.PostAsync(PostAPI(userid, token, order1, order2, order, password, seed), content);
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
            if (returnjson["msg"].ToString() != "success" && returnjson["msg"].ToString() != "msg not match!" && !returnjson["msg"].ToString().StartsWith("cant stop task") &&
                !returnjson["msg"].ToString().StartsWith("cant run task") && returnjson["msg"].ToString() != "sched timeout")
            {
                SN--;
            }
            if (returnjson["msg"].ToString().StartsWith("cant stop task") || returnjson["msg"].ToString().StartsWith("cant run task"))
            {
                info.AddInfo("返回失败提示，正在自动重新执行任务。", 1);
                HttpContent content2 = GetJsonContent(order2, order);
                response = await client.PostAsync(PostAPI(userid, token, order1, order2, order, password, seed), content2);
                responseBody = await response.Content.ReadAsStringAsync();
                returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
            }
            if(returnjson["msg"].ToString()== "SN invalid")
            {
                //流水号错误，试探重新发送
                info.AddInfo("流水号错误，开始自动匹配流水号。", 2);
                int temp = SN;
                bool succ = false;
                for (int i = temp - 2; i < temp + 3; i++)
                {
                    SN = i;
                    HttpContent content2 = GetJsonContent(order2, order);
                    response = await client.PostAsync(PostAPI(userid, token, order1, order2, order, password, seed), content2);
                    responseBody = await response.Content.ReadAsStringAsync();
                    returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
                    if (returnjson["msg"].ToString() != "success" && returnjson["msg"].ToString() != "msg not match!" && !returnjson["msg"].ToString().StartsWith("cant stop task") &&
                        !returnjson["msg"].ToString().StartsWith("cant run task") && returnjson["msg"].ToString() != "sched timeout")
                    {
                        SN--;
                    }
                    if (returnjson["msg"].ToString() != "SN invalid")
                    {
                        succ = true;
                        info.AddInfo("流水号匹配成功！当前流水号：" + (SN - 1).ToString(), 1);
                        break;
                    }
                }
                if (!succ)
                { 
                    throw new Exception(string.Format("流水号错误，匹配失败。"));
                }
            }
            iswait[5] = false;
            return returnjson;
        }

        public async Task<JObject> PostInfo(string userid, string token, string order1, string order2, string order, string password)
        {
            //发送信息
            iswait[6] = true;
            string str = "";
            HttpContent content = new StringContent(str);
            HttpResponseMessage response = await client.PostAsync(PostAPI(userid, token, order1, order2, order, password), content);
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
            if (returnjson["msg"].ToString() != "success" && returnjson["msg"].ToString() != "msg not match!" && !returnjson["msg"].ToString().StartsWith("cant stop task") &&
                !returnjson["msg"].ToString().StartsWith("cant run task") && returnjson["msg"].ToString() != "sched timeout") 
            {
                SN--;
            }
            iswait[6] = false;
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

        public string GetAPI(string userid, string token, string order, string password)
        {
            //获取Get命令的字符串
            string api = order + "?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password);
            SN++;
            return api;
        }

        public string PostAPI(string userid, string token, string order1, string order2, Order order, string password, string seed = "")
        {
            //获取Post命令的字符串
            switch (order)
            {
                case Order.Password:
                    string api = "Password?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) +
                        "&OldPassword=" + GetMD5(seed + order1) + "&NewPassword=" + GetEncrypt(order2, order1);
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
                        "&Stat=" + order1;
                    SN++;
                    return api5;
            }
            return "error";
        }

        public string PostAPI(string userid, string token, string order, string order1, string order2, string password)
        {
            //获取Get命令的字符串
            string api = order + "?UserId=" + userid + "&Token=" + token + "&SN=" + GetMD5(SN.ToString() + password) + "&" + order1;
            if (order2 != "")
            {
                api = api + "&" + order2;
            }
            SN++;
            return api;
        }

        public enum Order
        {
            //api枚举
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
