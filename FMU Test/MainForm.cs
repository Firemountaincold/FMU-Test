using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class MainForm : Form
    {
        //工具类
        public InfoTools info;
        public TipTools tip = new TipTools();
        public TipTools txttip = new TipTools();
        public RESTful restful = new RESTful();
        public SFTPHelper sftp;
        //全局量
        public string FMUpath = "";
        public string pypath = "";
        public string xmlpath = "";
        public string pythonexe = "";
        public string xmlexe = "";
        public string ip;
        public string port;
        public string userid;
        public string password;
        public string token;
        public string seed;
        public string rn = "\r\n       ";
        public string sftpip = "";
        public string sftpport = "";
        public string sftpuserid = "";
        public string sftppassword = "";
        public string taskdefault = "";
        public string tasksftp = "";
        //标志
        public bool logflag = false;
        public bool sftplogflag = false;
        public bool readxml = false;
        public bool jsonstyle = false;
        public bool isready = false;
        public bool isnop = false;

        //配置文件修改
        private Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public MainForm()
        {
            InitializeComponent();
            textBoxRePathfmu.Text = ConfigurationManager.AppSettings["sftppath"];
            textBoxRePathpy.Text = ConfigurationManager.AppSettings["calpath"];
            textBoxRePathtask.Text = ConfigurationManager.AppSettings["taskpath"];
            pythonexe = ConfigurationManager.AppSettings["pythonpath"];
            xmlexe = ConfigurationManager.AppSettings["xmlpath"];
            info = new InfoTools(richTextBoxinfo);
            for (int i = 0; i < DateTime.Now.ToString().Length; i++)
            {
                rn = rn + " ";
            }
            if (!Directory.Exists(Application.StartupPath + "\\运行日志"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\运行日志");
            }
            restful.info = info;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Comboboxinit();
            LoadConfig();
        }

        public void Comboboxinit()
        {
            //载入下拉列表
            comboBoxtask.Items.Add("修改密码");
            comboBoxtask.Items.Add("FMU运行调度控制");
            comboBoxtask.Items.Add("设置调度策略的路径");
            comboBoxtask.Items.Add("安装控制模型");
            comboBoxtask.Items.Add("卸载控制模型");
            comboBoxtask.SelectedItem = "FMU运行调度控制";
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {   // 总是接受，忽略https证书   
            return true;
        }

        private void buttonFMU_Click(object sender, EventArgs e)
        {
            //选择FMU.dll
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!Directory.Exists(Application.StartupPath + "\\配置文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\配置文件");
            }
            openFileDialog.InitialDirectory = Application.StartupPath + "\\配置文件";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FMUpath = openFileDialog.FileName;
                textBoxFMUstatus.Text = Path.GetFileName(FMUpath);
                textBoxFMUstatus.ForeColor = Color.Green;
                info.AddInfo("已载入" + FMUpath, 1);
            }
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            //选择cal1.py
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!Directory.Exists(Application.StartupPath + "\\配置文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\配置文件");
            }
            openFileDialog.InitialDirectory = Application.StartupPath + "\\配置文件";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "python文件(*.py)|*.py";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pypath = openFileDialog.FileName;
                textBoxCallstatus.Text = Path.GetFileName(pypath);
                textBoxCallstatus.ForeColor = Color.Green;
                info.AddInfo("已载入" + pypath, 1);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //用SFTP部署文件
            try
            {
                if (sftplogflag)
                {
                    if (checkBoxfmu.Checked || checkBoxpy.Checked || checkBoxtask.Checked)
                    {
                        if (checkBoxfmu.Checked && FMUpath != "")
                        {
                            string repath = GetXieGang(textBoxRePathfmu.Text) + Path.GetFileName(FMUpath);
                            if (sftp.CheckFile(repath))
                            {
                                if (MessageBox.Show(Path.GetFileName(FMUpath) + "文件已存在，是否覆盖？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    long fmulength = sftp.Put(FMUpath, repath);
                                    info.AddInfo("已上传" + Path.GetFileName(FMUpath) + "。共" + fmulength + "字节。", 1);
                                }
                            }
                            else
                            {
                                long fmulength = sftp.Put(FMUpath, repath);
                                info.AddInfo("已上传" + Path.GetFileName(FMUpath) + "。共" + fmulength + "字节。", 1);
                            }
                        }
                        if (checkBoxpy.Checked && pypath != "")
                        {
                            string repath = GetXieGang(textBoxRePathpy.Text) + Path.GetFileName(pypath);
                            if (sftp.CheckFile(repath))
                            {
                                if (MessageBox.Show(Path.GetFileName(pypath) + "文件已存在，是否覆盖？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    long pylength = sftp.Put(pypath, repath);
                                    info.AddInfo("已上传" + Path.GetFileName(pypath) + "。共" + pylength + "字节。", 1);
                                }
                            }
                            else
                            {
                                long pylength = sftp.Put(pypath, repath);
                                info.AddInfo("已上传" + Path.GetFileName(pypath) + "。共" + pylength + "字节。", 1);
                            }
                        }
                        if (checkBoxtask.Checked && xmlpath != "")
                        {
                            string repath = GetXieGang(textBoxRePathtask.Text) + Path.GetFileName(xmlpath);
                            if (sftp.CheckFile(repath))
                            {
                                if (MessageBox.Show(Path.GetFileName(xmlpath) + "文件已存在，是否覆盖？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    long xmllength = sftp.Put(xmlpath, repath);
                                    info.AddInfo("已上传" + Path.GetFileName(xmlpath) + "。共" + xmllength + "字节。", 1);
                                }
                            }
                            else
                            {
                                long xmllength = sftp.Put(xmlpath, repath);
                                info.AddInfo("已上传" + Path.GetFileName(xmlpath) + "。共" + xmllength + "字节。", 1);
                            }
                        }
                        if (textBoxRePathfmu.Text != ConfigurationManager.AppSettings["sftppath"])
                        {
                            config.AppSettings.Settings["sftppath"].Value = textBoxRePathfmu.Text;
                        }
                        if (textBoxRePathpy.Text != ConfigurationManager.AppSettings["calpath"])
                        {
                            config.AppSettings.Settings["calpath"].Value = textBoxRePathpy.Text;
                        }
                        if (textBoxRePathtask.Text != ConfigurationManager.AppSettings["taskpath"])
                        {
                            config.AppSettings.Settings["taskpath"].Value = textBoxRePathtask.Text;
                        }
                        config.Save(ConfigurationSaveMode.Modified);
                    }
                    else
                    {
                        MessageBox.Show("请选择好要部署的文件和目录。", "警告");
                    }
                }
                else
                {
                    MessageBox.Show("请先登录SFTP服务器。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo("部署失败。原因：" + ex.Message.Replace("No such file", "目标目录不存在。"), 2);
            }
        }

        public string GetXieGang(string path)
        {
            //自动补全斜杠
            if (!path.EndsWith("/"))
            {
                path = path + "/";
            }
            return path;
        }

        private void buttonGetTask_Click(object sender, EventArgs e)
        {
            //生成Task.xml
            try
            {
                string taskpath = textBoxRePathtask.Text;
                if (taskdefault != "")
                {
                    taskpath = taskdefault;
                }
                GetTasks getTasks = new GetTasks(xmlpath, sftp, taskpath);
                if (getTasks.ShowDialog() == DialogResult.OK)
                {
                    if (xmlpath == "")
                    {
                        info.AddInfo("创建成功！已保存到" + Application.StartupPath + "\\XML文件\\task.xml", 1);
                        xmlpath = Application.StartupPath + "\\XML文件\\task.xml";
                        textBoxtaskstatus.Text = Path.GetFileName(xmlpath);
                        textBoxtaskstatus.ForeColor = Color.Green;
                        info.AddInfo("已载入" + xmlpath, 1);
                    }
                    else
                    {
                        info.AddInfo("修改成功！已保存到" + xmlpath, 1);
                    }
                    string[] taskname = getTasks.tasknames;
                    if (taskname.Length != 0)
                    {
                        string name = "已添加的任务：";
                        for (int i = 0; i < taskname.Length - 1; i++)
                        {
                            name += taskname[i] + "、";
                        }
                        name += taskname[taskname.Length - 1];
                        info.AddInfo(name, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                info.AddInfo("保存失败。原因：" + ex.Message, 2);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async void timerNOP_Tick(object sender, EventArgs e)
        {
            //保持连接
            try
            {
                isnop = true;
                string nop = await restful.GetNOP(userid, token, password);
                if (nop == "success")
                {
                    info.AddInfo("启动NOP GET操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "Token有效时间自动刷新成功。每隔" + restful.GetTokenTime().ToString() + "秒刷新一次。", 1);
                }
                else
                {
                    info.AddInfo("启动NOP GET操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "Token有效时间自动刷新失败。原因：" + nop + rn + "连接已断开。", 2);
                    await FMUDisconnect(true);
                    info.AddInfo("退出成功，将开始进行重新登陆。", 1);
                }
                isnop = false;
            }
            catch (Exception ex)
            {
                isnop = false;
                info.AddInfo("连接出现错误。原因：" + ex.Message, 2);
                await FMUDisconnect(true);
                info.AddInfo("退出成功，将开始进行重新登陆。", 1);
            }
        }

        public async Task FMUDisconnect(bool reconnect)
        {
            //FMU退出登录
            try
            {
                await restful.DisConnect(reconnect);
                logflag = false;
                textBoxlogstatus.BeginInvoke(new Action(() =>
                {
                    textBoxlogstatus.Text = "未登录";
                    textBoxlogstatus.ForeColor = Color.Black;
                }));
                timerNOP.Stop();
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private async void buttonlogin_ClickAsync(object sender, EventArgs e)
        {
            //登录
            try
            {
                LogIn logIn = new LogIn("fmu", config);
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    ip = logIn.ip;
                    port = logIn.port;
                    userid = logIn.userid;
                    password = logIn.password;
                    buttonlogin.Enabled = false;
                    await ConnectFMU();
                    buttonlogin.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private async Task ConnectFMU()
        {
            //登录
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);//验证服务器证书回调自动验证
                if (logflag == true)
                {
                    await FMUDisconnect(false);
                }
                restful.SN = 1;
                info.AddInfo("开始登录RESTful接口……", 1);
                restful.GetClient(ip, port);
                seed = await restful.GetSeed(userid, "W");
                info.AddInfo("已获得种子：" + seed + "，正在获取令牌……", 1);
                token = await restful.GetToken(userid, password, seed);
                if (token == "get token fail!")
                {
                    info.AddInfo("令牌获取失败！", 2);
                }
                else
                {
                    info.AddInfo("已获得令牌：" + token + "，登陆成功。", 1);
                    textBoxlogstatus.Text = "已登录";
                    textBoxlogstatus.ForeColor = Color.Green;
                    logflag = true;
                    if (restful.GetTokenTime() > 0)
                    {
                        timerNOP.Interval = restful.GetTokenTime() * 1000;
                    }
                    timerNOP.Start();
                    timerReConnect.Start();
                    if (isready)
                    {
                        panelwait.Visible = true;
                        await GetInfo();
                        panelwait.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                info.AddInfo("登录出现错误：" + ex.Message, 2);
            }
        }

        private async void buttondo_Click(object sender, EventArgs e)
        {
            //执行相应的API命令
            try
            {
                if (logflag)
                {
                    //POST命令
                    await CheckNOP();
                    timerNOP.Stop();
                    pictureBoxloading2.Visible = true;
                    buttondo.Enabled = false;
                    JObject json = new JObject();
                    string post1 = textBoxpost1.Text.Trim();
                    string post2 = textBoxpost2.Text.Trim();
                    switch (comboBoxtask.SelectedItem)
                    {
                        case null:
                            MessageBox.Show("请选择一个命令！", "警告");
                            break;
                        case "修改密码":
                            if (post1.Length != post2.Length)
                            {
                                MessageBox.Show("请保持新旧密码长度相同！", "警告");
                                break;
                            }
                            json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.Password, password, seed);
                            if (jsonstyle)
                            {
                                info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                            }
                            else if (json != null)
                            {
                                if (json["msg"] != null)
                                {
                                    if (json["msg"].ToString() == "success")
                                    {
                                        info.AddInfo("启动Password POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：密码修改成功！", 1);
                                        await FMUDisconnect(false);
                                        info.AddInfo("已自动断开连接，请重新登录！", 2);
                                    }
                                    else
                                    {
                                        info.AddInfo("启动Password POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：密码修改失败，原因：" + json["msg"].ToString(), 1);
                                    }
                                }
                                else
                                {
                                    info.AddInfo("启动Password POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "信息获取失败，返回json字符串为：" + json.ToString(), 1);
                                }
                            }
                            else
                            {
                                info.AddInfo("启动Password POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                    "信息获取失败，没有返回json字符串", 1);
                            }
                            break;
                        case "FMU运行调度控制":
                            json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyRunStat, password);
                            if (jsonstyle)
                            {
                                info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                            }
                            else if (json != null)
                            {
                                if (json["msg"] != null)
                                {
                                    if (json["msg"].ToString() == "success")
                                    {
                                        info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：运行调度成功！", 1);
                                    }
                                    else
                                    {
                                        string warn = json["msg"].ToString().Replace("cant run task", "无法运行任务").Replace("current task status", "任务当前状态").Replace("STATUS_RUN", "运行中");
                                        warn = warn.Replace("cant stop task", "无法停止任务").Replace("STATUS_STOP", "已停止");
                                        info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：调度失败，原因：" + warn, 1);
                                    }
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "信息获取失败，返回json字符串为：" + json.ToString(), 1);
                                }
                            }
                            else
                            {
                                info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                        "信息获取失败，没有返回json字符串", 1);
                            }
                            break;
                        case "设置调度策略的路径":
                            json = await restful.PostInfo(userid, token, GetXieGang(post1), post2, RESTful.Order.PyTaskFile, password);
                            if (jsonstyle)
                            {
                                info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                            }
                            else if (json != null)
                            {
                                if (json["msg"] != null)
                                {
                                    if (json["msg"].ToString() == "success")
                                    {
                                        info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：路径设置成功！", 1);
                                        if (!post1.EndsWith("/"))
                                        {
                                            post1 = post1 + "/";
                                        }
                                        taskdefault = post1;
                                        textBoxRePathtask.Text = taskdefault;
                                        if (textBoxRePathtask.Text != ConfigurationManager.AppSettings["taskpath"])
                                        {
                                            config.AppSettings.Settings["taskpath"].Value = textBoxRePathtask.Text;
                                            config.Save(ConfigurationSaveMode.Modified);
                                        }
                                    }
                                    else
                                    {
                                        info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：设置失败，原因：" + json["msg"].ToString(), 1);
                                    }
                                }
                                else
                                {
                                    info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "信息获取失败，返回json字符串为：" + json.ToString(), 1);
                                }
                            }
                            else
                            {
                                info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                        "信息获取失败，没有返回json字符串", 1);
                            }
                            break;
                        case "安装控制模型":
                            json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib, password);
                            if (jsonstyle)
                            {
                                info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                            }
                            else if (json != null)
                            {
                                if (json["msg"] != null)
                                {
                                    if (json["msg"].ToString() == "success")
                                    {
                                        info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：路径设置成功！", 1);
                                    }
                                    else
                                    {
                                        info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：安装失败，原因：" + json["msg"].ToString(), 1);
                                    }
                                }
                                else
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "信息获取失败，返回json字符串为：" + json.ToString(), 1);
                                }
                            }
                            else
                            {
                                info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                        "信息获取失败，没有返回json字符串", 1);
                            }
                            break;
                        case "卸载控制模型":
                            json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib2, password);
                            if (jsonstyle)
                            {
                                info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                            }
                            else if (json != null)
                            {
                                if (json["msg"] != null)
                                {
                                    if (json["msg"].ToString() == "success")
                                    {
                                        info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：路径设置成功！", 1);
                                    }
                                    else
                                    {
                                        info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                            "返回消息：卸载失败，原因：" + json["msg"].ToString(), 1);
                                    }
                                }
                                else
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                           "信息获取失败，返回json字符串为：" + json.ToString(), 1);
                                }
                            }
                            else
                            {
                                info.AddInfo("启动PyLib POST操作。当前流水号为：" + (restful.SN - 1).ToString() + rn +
                                        "信息获取失败，没有返回json字符串", 1);
                            }
                            break;
                    }
                    if (jsonstyle)
                    {
                        if (comboBoxtask.Text != comboBoxtask.SelectedItem.ToString())
                        {
                            json = await restful.PostInfo(userid, token, post1, post2, comboBoxtask.Text, password);
                            info.AddInfo("已发送POST命令。当前流水号为：" + (restful.SN - 1).ToString() + "\r\n" + json.ToString(), 1);
                        }
                    }
                    timerNOP.Start();
                }
                else
                {
                    MessageBox.Show("请先登录。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo("连接出现错误：" + ex.Message, 2);
                await FMUDisconnect(true);
                info.AddInfo("退出成功，将开始进行重新登陆。", 1);
            }
            finally
            {
                buttondo.Enabled = true;
                pictureBoxloading2.Visible = false;
            }
        }

        public async Task<bool> CheckNOP()
        {
            //等待NOP结束
            while (isnop)
            {
                await Task.Delay(100);
            }
            return true;
        }

        public async Task<bool> GetInfo(bool refresh = false)
        {
            //一次性获取4次信息
            try
            {
                info.AddInfo("开始获取平台信息，当前流水号为：" + restful.SN, 1);
                await CheckNOP();
                timerNOP.Stop();
                if (refresh)
                {
                    textBoxserverinfo.Text = "开始刷新平台信息……";
                }
                else
                {
                    textBoxserverinfo.Text = "开始获取平台信息……";
                }
                string serverinfo = "控制器运行状态：";
                JObject json1 = await restful.GetInfo(userid, token, RESTful.Order.PyRunStat, password);
                if (json1 != null)
                {
                    if (json1["msg"] != null)
                    {
                        if (json1["msg"].ToString() == "success")
                        {
                            if (json1["data"].ToString() != "{}")
                            {
                                info.AddInfo("控制器运行状态为：" + json1["data"]["Stat"].ToString(), 1);
                                serverinfo += json1["data"]["Stat"].ToString() + "\r\n";
                            }
                            else
                            {
                                serverinfo += "\r\n";
                            }
                        }
                        else
                        {
                            info.AddInfo("控制器运行状态信息获取失败，返回信息为：" + json1["msg"].ToString(), 1);
                            serverinfo += "获取失败。\r\n";
                        }
                    }
                    else
                    {
                        info.AddInfo("控制器运行状态信息获取失败，返回信息为：" + json1.ToString(), 1);
                        serverinfo += "获取失败。\r\n";
                    }
                }
                else
                {
                    info.AddInfo("控制器运行状态信息获取失败。", 1);
                    serverinfo += "获取失败。\r\n";
                }
                textBoxserverinfo.Text = serverinfo;
                JObject json2 = await restful.GetInfo(userid, token, RESTful.Order.SysVersion, password);
                if (json2 != null)
                {
                    if (json2["msg"] != null)
                    {
                        if (json2["msg"].ToString() == "success")
                        {
                            if (json2["data"].ToString() != "{}")
                            {
                                info.AddInfo("平台系统：" + json2["data"]["OS"].ToString() + rn + "系统版本：" + json2["data"]["OsVer"] +
                                    rn + "Python版本：" + json2["data"]["PythonVer"] + rn + "Gcc版本：" + json2["data"]["GccVer"] + rn + "AI版本：" + json2["data"]["AIVer"], 1);
                                serverinfo += "平台系统：" + json2["data"]["OS"].ToString() + "\r\n系统版本：" + json2["data"]["OsVer"] +
                                    "\r\nPython版本：" + json2["data"]["PythonVer"] + "\r\nGcc版本：" + json2["data"]["GccVer"] + "\r\nAI版本：" + json2["data"]["AIVer"] + "\r\n";
                            }
                            else
                            {
                                serverinfo += "平台系统：\r\n系统版本：\r\nPython版本：\r\nGcc版本：\r\nAI版本：\r\n";
                            }
                        }
                        else
                        {
                            info.AddInfo("平台信息获取失败，返回信息为：" + json2["msg"].ToString(), 1);
                            serverinfo += "平台信息：获取失败。\r\n";
                        }
                    }
                    else
                    {
                        info.AddInfo("控制器运行状态信息获取失败，返回信息为：" + json1.ToString(), 1);
                        serverinfo += "获取失败。\r\n";
                    }
                }
                else
                {
                    info.AddInfo("控制器运行状态信息获取失败。", 1);
                    serverinfo += "获取失败。\r\n";
                }
                textBoxserverinfo.Text = serverinfo;
                JObject json3 = await restful.GetInfo(userid, token, RESTful.Order.PyTaskFile, password);
                if (json3["msg"].ToString() == "success")
                {
                    if (json3["data"].ToString() != "{}")
                    {
                        info.AddInfo("调度策略根目录：" + json3["data"]["RootPath"].ToString() + rn + "调度策略文件路径：" + json3["data"]["FullFileName"].ToString(), 1);
                        serverinfo += "调度策略根目录：" + json3["data"]["RootPath"].ToString() + "\r\n调度策略文件路径：" + json3["data"]["FullFileName"].ToString() + "\r\n";
                        taskdefault = json3["data"]["RootPath"].ToString().Trim();
                        tasksftp = json3["data"]["FullFileName"].ToString().Trim();
                        textBoxRePathtask.Text = taskdefault;
                        if (textBoxRePathtask.Text != ConfigurationManager.AppSettings["taskpath"])
                        {
                            config.AppSettings.Settings["taskpath"].Value = textBoxRePathtask.Text;
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                    }
                    else
                    {
                        serverinfo += "调度策略根目录：\r\n调度策略文件路径：\r\n";
                    }
                }
                else
                {
                    info.AddInfo("调度策略信息获取失败，返回信息为：" + json3["msg"].ToString(), 1);
                    serverinfo += "调度策略信息：获取失败。\r\n";
                }
                textBoxserverinfo.Text = serverinfo;
                JObject json4 = await restful.GetInfo(userid, token, RESTful.Order.PyLib, password);
                if (json4["msg"].ToString() == "success")
                {
                    if (json4["data"].ToString() != "{}")
                    {
                        info.AddInfo("已安装的控制模型有：" + json4["data"]["Libs"].ToString(), 1);
                        serverinfo += "已安装的控制模型：" + json4["data"]["Libs"].ToString();
                    }
                    else
                    {
                        serverinfo += "已安装的控制模型：";
                    }
                }
                else
                {
                    info.AddInfo("控制模型获取失败，返回信息为：" + json4["msg"].ToString(), 1);
                    serverinfo += "控制模型信息：获取失败。";
                }
                info.AddInfo("信息获取完成，当前流水号为：" + (restful.SN - 1).ToString(), 1);
                textBoxserverinfo.Text = serverinfo;
                isready = true;
                timerNOP.Start();
                return true;
            }
            catch (Exception ex)
            {
                timerNOP.Start();
                info.AddInfo(ex.Message, 2);
                return false;
            }
        }

        private void comboBoxtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            //让label随combobox选项变化
            textBoxpost2.Enabled = true;
            buttonpost1.Visible = false;
            buttonpost2.Visible = false;
            txttip.Clear();
            switch (comboBoxtask.SelectedItem)
            {
                case "修改密码":
                    labelpost1.Text = "旧密码：";
                    labelpost2.Text = "新密码：";
                    break;
                case "FMU运行调度控制":
                    buttonpost2.Visible = true;
                    labelpost1.Text = "运行状态：";
                    labelpost2.Text = "运行任务：";
                    break;
                case "设置调度策略的路径":
                    buttonpost1.Visible = true;
                    buttonpost2.Visible = true;
                    labelpost1.Text = "目录：";
                    labelpost2.Text = "文件路径：";
                    break;
                case "安装控制模型":
                    buttonpost1.Visible = true;
                    labelpost1.Text = "安装路径：";
                    labelpost2.Text = "";
                    textBoxpost2.Enabled = false;
                    break;
                case "卸载控制模型":
                    labelpost1.Text = "卸载模型名：";
                    labelpost2.Text = "";
                    textBoxpost2.Enabled = false;
                    break;
            }
            textBoxpost1.Text = "";
            textBoxpost2.Text = "";
        }

        private async void buttonlogsftp_Click(object sender, EventArgs e)
        {
            //登录sftp
            if (textBoxRePathfmu.Text == "test")
            {
                buttontteesstt.Enabled = true;
                buttontteesstt.Visible = true;
                textBoxRePathfmu.Text = ConfigurationManager.AppSettings["sftppath"];
            }
            else
            {
                LogIn logIn = new LogIn("sftp", config);
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    buttonlogsftp.Enabled = false;
                    await SFTPlogin(logIn.ip, logIn.port, logIn.userid, logIn.password);
                    buttonlogsftp.Enabled = true;
                }
            }
        }

        public void LoadConfig()
        {
            //读取配置
            sftpip = ConfigurationManager.AppSettings["sftpip"];
            sftpport = ConfigurationManager.AppSettings["sftpport"];
            sftpuserid = ConfigurationManager.AppSettings["sftpuser"];
            sftppassword = ConfigurationManager.AppSettings["sftppw"];
            ip = ConfigurationManager.AppSettings["fmuip"];
            port = ConfigurationManager.AppSettings["fmuport"];
            userid = ConfigurationManager.AppSettings["fmuuser"];
            password = ConfigurationManager.AppSettings["fmupw"];
        }

        public async Task<bool> SFTPlogin(string ip, string port, string userid, string pw)
        {
            //异步的sftp登录
            try
            {
                sftp = new SFTPHelper(ip, port, userid, pw);
                info.AddInfo("开始登陆SFTP服务器：sftp://" + ip + ":" + port, 1);
                await Task.Run(() =>
                {
                    sftp.Connect();
                });
                info.AddInfo("SFTP服务器登陆成功。", 1);
                textBoxsftplog.Text = "已登录";
                textBoxsftplog.ForeColor = Color.Green;
                sftplogflag = true;
                return true;
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
                textBoxsftplog.Text = "未登录";
                textBoxsftplog.ForeColor = Color.Black;
                return false;
            }
        }

        private async void buttondisconnfmu_Click(object sender, EventArgs e)
        {
            //fmu退出登录
            if (logflag)
            {
                info.AddInfo("开始退出登录，正在等待异步操作……", 2);
                await FMUDisconnect(false);
                info.AddInfo("退出成功。", 1);
            }
            else
            {
                MessageBox.Show("FMU未连接！", "警告");
            }
        }

        private void checkBoxsavelog_CheckedChanged(object sender, EventArgs e)
        {
            //选择是否保存日志
            if (checkBoxsavelog.Checked)
            {
                info.islog = true;
            }
            else
            {
                info.islog = false;
            }
        }

        private void textBoxpost1_MouseHover(object sender, EventArgs e)
        {
            //POST语句提示1
            switch (comboBoxtask.SelectedItem)
            {
                case "修改密码":
                    txttip.ToolTips(textBoxpost1, "旧密码。");
                    break;
                case "FMU运行调度控制":
                    txttip.ToolTips(textBoxpost1, "命令：RUN（运行），STOP（停止），RESET（复位），RELOAD（重载）。");
                    break;
                case "设置调度策略的路径":
                    txttip.ToolTips(textBoxpost1, "任务文件存放的目录。");
                    break;
                case "安装控制模型":
                    txttip.ToolTips(textBoxpost1, "控制模型的安装文件路径。");
                    break;
                case "卸载控制模型":
                    txttip.ToolTips(textBoxpost1, "控制模型名。");
                    break;
            }
        }

        private void textBoxpost2_MouseHover(object sender, EventArgs e)
        {
            //POST语句提示2
            switch (comboBoxtask.SelectedItem)
            {
                case "修改密码":
                    txttip.ToolTips(textBoxpost2, "新密码，长度应与旧密码相同。");
                    break;
                case "FMU运行调度控制":
                    txttip.ToolTips(textBoxpost2, "多个任务名之间用英文逗号隔开。如果为空，则命令针对控制器内的全部任务。");
                    break;
                case "设置调度策略的路径":
                    txttip.ToolTips(textBoxpost2, "任务配置文件的路径和文件名信息。");
                    break;
            }
        }

        private void buttontteesstt_Click(object sender, EventArgs e)
        {
            //打开或关闭测试模式
            if (!jsonstyle)
            {
                comboBoxtask.DropDownStyle = ComboBoxStyle.DropDown;
                jsonstyle = true;
                info.AddInfo("已开启测试模式。", 2);
            }
            else
            {
                comboBoxtask.DropDownStyle = ComboBoxStyle.DropDownList;
                jsonstyle = false;
                info.AddInfo("已关闭测试模式。", 2);
            }
        }

        private void buttonsftpdl_Click(object sender, EventArgs e)
        {
            //sftp下载文件
            try
            {
                if (sftplogflag)
                {
                    SFTPExplorer se = new SFTPExplorer(sftp, false, true);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        string repath = se.returnpath;
                        string path = Path.Combine(Application.StartupPath, "sftp文件");
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        long length = sftp.Get(repath, Path.Combine(path, Path.GetFileName(repath)));
                        info.AddInfo("已下载文件：" + Path.GetFileName(repath) + "。长度" + length.ToString() + "字节。", 1);
                    }
                }
                else
                {
                    MessageBox.Show("请先登录SFTP服务器。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo("下载失败。原因：" + ex.Message, 2);
            }
        }

        private void buttonsftpdldir_Click(object sender, EventArgs e)
        {
            //打开下载文件所在文件夹
            string path = Path.Combine(Application.StartupPath, "sftp文件");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start("explorer.exe", path);
        }

        private void checkBoxfmu_CheckedChanged(object sender, EventArgs e)
        {
            //是否启用fmu
            if (checkBoxfmu.Checked)
            {
                panelfmu.Enabled = true;
                panelfmu.BackColor = Color.FromName("Window");
            }
            else
            {
                panelfmu.Enabled = false;
                panelfmu.BackColor = Color.FromName("Control");
            }
        }

        private void checkBoxpy_CheckedChanged(object sender, EventArgs e)
        {
            //是否启用py
            if (checkBoxpy.Checked)
            {
                panelpy.Enabled = true;
                panelpy.BackColor = Color.FromName("Window");
            }
            else
            {
                panelpy.Enabled = false;
                panelpy.BackColor = Color.FromName("Control");
            }
        }

        private void checkBoxtask_CheckedChanged(object sender, EventArgs e)
        {
            //是否启用task
            if (checkBoxtask.Checked)
            {
                paneltask.Enabled = true;
                paneltask.BackColor = Color.FromName("Window");
            }
            else
            {
                paneltask.Enabled = false;
                paneltask.BackColor = Color.FromName("Control");
            }
        }

        private void buttontask_Click(object sender, EventArgs e)
        {
            //选择task.xml
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!Directory.Exists(Application.StartupPath + "\\XML文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\XML文件");
            }
            openFileDialog.InitialDirectory = Application.StartupPath + "\\XML文件";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlpath = openFileDialog.FileName;
                textBoxtaskstatus.Text = Path.GetFileName(xmlpath);
                textBoxtaskstatus.ForeColor = Color.Green;
                info.AddInfo("已载入" + xmlpath, 1);
            }
        }

        private async void buttonrefreshinfo_Click(object sender, EventArgs e)
        {
            //刷新平台信息
            if (logflag)
            {
                buttonrefreshinfo.Enabled = false;
                panelwait.Visible = true;
                await GetInfo();
                panelwait.Visible = false;
                buttonrefreshinfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("请先登录FMU服务器。", "警告");
            }
        }

        private void buttongetsftpdirfmu_Click(object sender, EventArgs e)
        {
            //选择远程文件夹
            try
            {
                if (sftplogflag)
                {
                    string path = textBoxRePathfmu.Text;
                    SFTPExplorer se = new SFTPExplorer(sftp, true, false);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        textBoxRePathfmu.Text = se.returnpath;
                        if (textBoxRePathfmu.Text != ConfigurationManager.AppSettings["sftppath"])
                        {
                            config.AppSettings.Settings["sftppath"].Value = textBoxRePathfmu.Text;
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先登录SFTP服务器。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private void buttongetsftpdirpy_Click(object sender, EventArgs e)
        {
            //选择远程文件夹
            try
            {
                if (sftplogflag)
                {
                    string path = textBoxRePathpy.Text;
                    SFTPExplorer se = new SFTPExplorer(sftp, true, false);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        textBoxRePathpy.Text = se.returnpath;
                        if (textBoxRePathpy.Text != ConfigurationManager.AppSettings["calpath"])
                        {
                            config.AppSettings.Settings["calpath"].Value = textBoxRePathpy.Text;
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先登录SFTP服务器。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private void buttongetsftpdirtask_Click(object sender, EventArgs e)
        {
            //选择远程文件夹
            try
            {
                if (sftplogflag)
                {
                    string path = textBoxRePathtask.Text;
                    SFTPExplorer se = new SFTPExplorer(sftp, true, false);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        textBoxRePathtask.Text = se.returnpath;
                        if (textBoxRePathtask.Text != ConfigurationManager.AppSettings["taskpath"])
                        {
                            config.AppSettings.Settings["taskpath"].Value = textBoxRePathtask.Text;
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先登录SFTP服务器。", "警告");
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }        

        private void buttonopenpy_Click(object sender, EventArgs e)
        {
            //打开python文件
            try
            {
                if (pypath != "")
                {
                    Process.Start(pythonexe, pypath);
                }
                else
                {
                    MessageBox.Show("请先选择一个python文件。", "警告");
                }
            }
            catch
            {
                if (MessageBox.Show("Python文件打开失败，是否重新设定python文件的打开方式？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Multiselect = false;
                    ofd.Filter = "可执行文件(*.exe)|*.exe";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pythonexe = ofd.FileName;
                        config.AppSettings.Settings["pythonpath"].Value = pythonexe;
                        config.Save(ConfigurationSaveMode.Modified);
                        Process.Start(pythonexe, pypath);
                    }
                }
            }
        }

        private void buttonopenxml_Click(object sender, EventArgs e)
        {
            //打开xml文件
            try
            {
                if (xmlpath != "")
                {
                    Process.Start(xmlexe, xmlpath);
                }
                else
                {
                    MessageBox.Show("请先选择一个xml文件。", "警告");
                }
            }
            catch
            {
                if (MessageBox.Show("xml文件打开失败，是否重新设定xml文件的打开方式？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Multiselect = false;
                    ofd.Filter = "可执行文件(*.exe)|*.exe";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        xmlexe = ofd.FileName;
                        config.AppSettings.Settings["xmlpath"].Value = xmlexe;
                        config.Save(ConfigurationSaveMode.Modified);
                        Process.Start(xmlexe, xmlpath);
                    }
                }
            }
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            //欢迎窗口调用
            Visible = false;
            Welcome w = new Welcome();
            w.Show();
            w.ChangeLabelSFTP("正在登陆SFTP……");
            bool s1 = await SFTPlogin(sftpip, sftpport, sftpuserid, sftppassword);
            if (s1)
            {
                w.ChangeLabelSFTP("正在登陆SFTP……\r\nSFTP登陆成功！");
            }
            else
            {
                w.ChangeLabelSFTP("正在登陆SFTP……\r\nSFTP登陆失败！");
            }
            w.ChangeLabelREST("正在登陆RESTful接口……");
            bool s2 = await LogRestful();
            if (s2)
            {
                w.ChangeLabelREST("正在登陆RESTful接口……\r\nRESTful接口登陆成功！");
                w.ChangeLabel("正在获取控制器信息……");
                await GetInfo();
            }
            else
            {
                w.ChangeLabelREST("正在登陆RESTful接口……\r\nRESTful接口登陆失败！");
            }
            w.Close();
            Visible = true;
        }

        public async Task<bool> LogRestful()
        {
            //登录
            try
            {
                await ConnectFMU();
                if (logflag)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
                return false;
            }
        }

        private async void timerReConnect_Tick(object sender, EventArgs e)
        {
            //重连计时器
            try
            {
                if (restful.reconn)
                {
                    restful.reconn = false;
                    info.AddInfo("开始自动重新连接。", 1);
                    await ConnectFMU();
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private void buttonpost1_Click(object sender, EventArgs e)
        {
            //post1文本框小按钮
            try
            {
                if (comboBoxtask.SelectedItem.ToString() == "安装控制模型")
                {
                    SFTPExplorer se = new SFTPExplorer(sftp, false, false, "", true);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        string repath = se.returnpath;
                        textBoxpost1.Text = repath;
                    }
                }
                else if (comboBoxtask.SelectedItem.ToString() == "设置调度策略的路径")
                {
                    SFTPExplorer se = new SFTPExplorer(sftp, true, false);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        string repath = se.returnpath;
                        textBoxpost2.Text = repath;
                    }
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }    

        private void buttonpost2_Click(object sender, EventArgs e)
        {
            //post2文本框小按钮
            try
            {
                if (comboBoxtask.SelectedItem.ToString() == "FMU运行调度控制")
                {
                    if (tasksftp != "")
                    {
                        if (!tasksftp.EndsWith(".xml"))
                        {
                            MessageBox.Show("调度策略文件路径设置错误！请重新设置。", "警告");
                            return;
                        }
                        sftp.Get(tasksftp, Path.Combine(Application.StartupPath, "temp2.xml"));
                        Tasks ts = new Tasks(Path.Combine(Application.StartupPath, "temp2.xml"));
                        if (ts.ShowDialog() == DialogResult.OK)
                        {
                            string str = ts.returnstr;
                            textBoxpost2.Text = str;
                        }
                        File.Delete(Path.Combine(Application.StartupPath, "temp2.xml"));
                    }
                }
                else if (comboBoxtask.SelectedItem.ToString() == "设置调度策略的路径")
                {
                    SFTPExplorer se = new SFTPExplorer(sftp, false, false, "", true);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        string repath = se.returnpath;
                        textBoxpost2.Text = repath;
                    }
                }
            }
            catch(Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }
    }
}
