using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web.Security;

namespace FMU_Test
{
    public class RESTful
    {
        HttpClient client = new HttpClient();
        int SN = 1;
        int tokentime = 50;

        public void GetClient(string ip, string port)
        {
            //初始化
            client.BaseAddress = new Uri("http://" + ip + ":" + port + "/V0/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public int GetTokenTime()
        {
            return tokentime;
        }

        public string GetMD5(string a)
        {
            //获取MD5加密
            MD5 md5 = MD5.Create();
            byte[] data = Encoding.UTF8.GetBytes(a);
            byte[] newdata = md5.ComputeHash(data);
            return BitConverter.ToString(newdata);
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
                HttpResponseMessage response = await client.GetAsync("PasswordSeed%3FUserId%3D" + userid + "%26Permission%3D" + permission);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                int status = Convert.ToInt32(json["status"]);
                if (status == 0)
                {
                    return json["result"]["Seed"].ToString();
                }
                return json["message"].ToString();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<string> GetToken(string userid, string password, string seed)
        {
            //获取Token
            try
            {
                password = GetMD5(password);
                HttpResponseMessage response = await client.GetAsync("Token%3FUserId%3D" + userid + "%26Password%3D" + password);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
                int status = Convert.ToInt32(json["status"]);
                tokentime = Convert.ToInt32(json["result"]["PeriodOfValidity"]);
                if (status == 0)
                {
                    return json["result"]["Token"].ToString();
                }
                return json["message"].ToString();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async void GetNOP(string userid, string token)
        {
            //空命令，保持连接
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, Order.NOP));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
        }

        public async Task<JObject> GetInfo(string userid, string token, Order order)
        {
            //获取信息，PyTaskFile,PyLib,PyRunStat,Diagstat四种
            HttpResponseMessage response = await client.GetAsync(GetAPI(userid, token, order));
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = (JObject)JsonConvert.DeserializeObject(responseBody);
            return json;
        }

        public async Task<JObject> PostInfo(string userid, string token, string order1, string order2, Order order)
        {
            //发送信息
            JObject json = PostAPI(userid, token, order1, order2, order);
            HttpContent content = new StringContent(json.ToString());
            HttpResponseMessage response = await client.PostAsync(order.ToString(), content);
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject returnjson = (JObject)JsonConvert.DeserializeObject(responseBody);
            return returnjson;
        }

        public string GetAPI(string userid, string token, Order order)
        {
            //获取Get命令的字符串
            switch (order)
            {
                case Order.NOP:
                    string api = "NOP%3FUserId%3D" + userid + "%26Token%3D" + token + "%26SN%3D" + SN.ToString();
                    SN++;
                    return api;
                case Order.PyTaskFile:
                    string api2 = "PyTaskFile%3FUserId%3D" + userid + "%26Token%3D" + token + "%26SN%3D" + SN.ToString();
                    SN++;
                    return api2;
                case Order.PyLib:
                    string api3 = "PyLib%3FUserId%3D" + userid + "%26Token%3D" + token + "%26SN%3D" + SN.ToString();
                    SN++;
                    return api3;
                case Order.PyRunStat:
                    string api4 = "PyRunStat%3FUserId%3D" + userid + "%26Token%3D" + token + "%26SN%3D" + SN.ToString();
                    SN++;
                    return api4;
                case Order.Diagstat:
                    string api5 = "Diagstat%3FUserId%3D" + userid + "%26Token%3D" + token + "%26SN%3D" + SN.ToString();
                    SN++;
                    return api5;
            }
            return "error";
        }

        public JObject PostAPI(string userid, string token, string order1, string order2, Order order)
        {
            //获取Post命令的json
            JObject json = new JObject();
            json["userid"] = userid;
            json["token"] = token;
            json["SN"] = SN.ToString();
            switch (order)
            {
                case Order.Password:
                    order2 = GetEncrypt(order2, order1);
                    order1 = GetMD5(order1);
                    json["OldPassword"] = order1;
                    json["NewPassword"] = order2;
                    SN++;
                    return json;
                case Order.PyTaskFile:
                    json["RootPath"] = order1;
                    json["FullFileName"] = order2;
                    SN++;
                    return json;
                case Order.PyLib:
                    json["InstallName"] = order1;
                    SN++;
                    return json;
                case Order.PyLib2:
                    json["UninstallName"] = order1;
                    SN++;
                    return json;
                case Order.PyRunStat:
                    json["Stat"] = order1;
                    json["TaskNames"] = order2;
                    SN++;
                    return json;
            }
            return json;
        }

        public enum Order
        {
            Password=0,
            NOP,
            PyTaskFile,
            PyLib,
            PyLib2,
            PyRunStat,
            Diagstat,
        }
    }
}
