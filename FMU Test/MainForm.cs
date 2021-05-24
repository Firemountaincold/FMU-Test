using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class MainForm : Form
    {
        public InfoTools info;
        public TipTools tip = new TipTools();
        public TipTools txttip = new TipTools();
        public RESTful restful = new RESTful();
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public SFTPHelper sftp;
        public string FMUpath = "";
        public string Callpath = "";
        public string ip;
        public string port;
        public string userid;
        public string password;
        public string token;
        public string seed; 
        public string rn = "\r\n       ";
        public bool logflag = false;
        public bool sftplogflag = false;

        public MainForm()
        {
            InitializeComponent();
            textBoxRemotePath.Text = ConfigurationManager.AppSettings["sftppath"];
            info = new InfoTools(richTextBoxinfo);
            for (int i = 0; i < DateTime.Now.ToString().Length; i++) 
            {
                rn = rn + " ";
            }
            if (!Directory.Exists(Application.StartupPath + "\\运行日志"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\运行日志");
            }
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
            openFileDialog.Filter = "DLL文件(*.dll)|*.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FMUpath = openFileDialog.FileName;
                textBoxFMUstatus.Text = "已选择";
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
                Callpath = openFileDialog.FileName;
                textBoxCallstatus.Text = "已选择";
                textBoxCallstatus.ForeColor = Color.Green;
                info.AddInfo("已载入" + Callpath, 1);
            }
        }

        private async void buttonUpload_Click(object sender, EventArgs e)
        {
            //用SFTP部署文件
            try
            {
                if (sftplogflag)
                {
                    if (FMUpath != "" || Callpath != "" || textBoxRemotePath.Text != "")
                    {
                        string rp = textBoxRemotePath.Text;
                        if (!rp.EndsWith("/"))
                        {
                            rp = rp + "/";
                        }
                        if (FMUpath != "")
                        {
                            long fmulength = sftp.Put(FMUpath, rp + Path.GetFileName(FMUpath));
                            info.AddInfo("已上传" + Path.GetFileName(FMUpath) + "。共" + fmulength + "字节。", 1);
                        }
                        if (Callpath != "")
                        {
                            long callength = sftp.Put(Callpath, rp + Path.GetFileName(Callpath));
                            info.AddInfo("已上传" + Path.GetFileName(Callpath) + "。共" + callength + "字节。", 1);
                        }
                        if (checkBoxtask.Checked)
                        {
                            long tasklength = sftp.Put(Application.StartupPath + "\\XML文件\\Task.xml", rp + "Task.xml");
                            info.AddInfo("已上传Task.xml。共" + tasklength + "字节。", 1);
                        }
                        if (checkBoxpyTask.Checked)
                        {
                            if (logflag)
                            {
                                string post1 = rp;
                                string post2 = rp + "Task.xml";
                                JObject json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyTaskFile, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：路径设置成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：设置失败，原因：" + json["msg"].ToString(), 1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("要自动设置目录，请先登录FMU！", "警告");
                            }
                        }
                        if (textBoxRemotePath.Text != ConfigurationManager.AppSettings["sftppath"])
                        {
                            if (MessageBox.Show("检测到SFTP部署的远程目录变化，是否保存改变？", "询问", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                config.AppSettings.Settings["sftppath"].Value = textBoxRemotePath.Text;
                                config.Save(ConfigurationSaveMode.Modified);
                            }
                        }

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
            catch(Exception ex)
            {
                info.AddInfo("部署失败。原因：" + ex.Message, 2);
            }
        }

        private void buttonGetTask_Click(object sender, EventArgs e)
        {
            //生成Task.xml
            GetTasks getTasks = new GetTasks();
            if (getTasks.ShowDialog() == DialogResult.OK)
            {
                info.AddInfo("创建成功！已保存到" + Application.StartupPath + "\\XML文件\\Task.xml", 1);
                string[] taskname = getTasks.name;
                string name = "已添加的任务：";
                for (int i = 0; i < taskname.Length - 1; i++) 
                {
                    name += taskname[i] + "、";
                }
                name += taskname[taskname.Length - 1];
                info.AddInfo(name, 1);
            }
        }

        private void buttonOpenxml_Click(object sender, EventArgs e)
        {
            //打开Task.xml
            if (File.Exists(Application.StartupPath + "\\XML文件\\Task.xml"))
            {
                Process.Start("notepad.exe", Application.StartupPath + "\\XML文件\\Task.xml");
            }
            else
            {
                MessageBox.Show("Task.xml不存在。", "警告");
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //关闭窗口
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (checkBoxsavelog.Checked)
                {
                    Savelog();
                }
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗口
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (checkBoxsavelog.Checked)
                {
                    Savelog();
                }
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
            string nop = await restful.GetNOP(userid, token, password);
            if (nop == "success")
            {
                info.AddInfo("启动NOP GET操作。当前流水号为：" + restful.SN + rn +
                                       "Token有效时间自动刷新成功。每隔" + restful.GetTokenTime().ToString() + "秒刷新一次。", 1);
            }
            else
            {
                info.AddInfo("启动NOP GET操作。当前流水号为：" + restful.SN + rn +
                                       "Token有效时间自动刷新失败。原因：" + nop, 1);
            }
        }

        private async void buttonlogin_ClickAsync(object sender, EventArgs e)
        {
            //登录
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);//验证服务器证书回调自动验证
                LogIn logIn = new LogIn("fmu");
                logIn.Text = "登录RESTful API";
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    ip = logIn.ip;
                    port = logIn.port;
                    userid = logIn.userid;
                    password = logIn.password;
                    info.AddInfo("开始登录……", 1);
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
                        if (checkBoxgetinfo.Checked)
                        {
                            GetInfo();
                        }
                    }
                }
                else
                {
                    info.AddInfo("登录已取消。", 2);
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        private void radioButtonget_CheckedChanged(object sender, EventArgs e)
        {
            //GET
            if (radioButtonget.Checked)
            {
                comboBoxtask.Text = "";
                comboBoxtask.Items.Clear();
                comboBoxtask.Items.Add("获取控制器运行状态");
                comboBoxtask.Items.Add("获取平台版本信息");
                comboBoxtask.Items.Add("获取PyTask的路径");
                comboBoxtask.Items.Add("获取Python已安装的库");
                textBoxpost1.Enabled = false;
                textBoxpost2.Enabled = false;
            }
        }

        private void radioButtonpost_CheckedChanged(object sender, EventArgs e)
        {
            //POST
            if (radioButtonpost.Checked)
            {
                comboBoxtask.Text = "";
                comboBoxtask.Items.Clear();
                comboBoxtask.Items.Add("修改密码");
                comboBoxtask.Items.Add("设置控制器的控制程序的运行调度");
                comboBoxtask.Items.Add("设置PyTask的路径");
                comboBoxtask.Items.Add("安装Python库"); 
                comboBoxtask.Items.Add("卸载Python库");
                textBoxpost1.Enabled = true;
                textBoxpost2.Enabled = true;
            }
        }

        private async void buttondo_Click(object sender, EventArgs e)
        {
            //执行相应的API命令
            try
            {
                if (logflag)
                {
                    if (radioButtonget.Checked)
                    {
                        //GET命令
                        JObject json = new JObject();
                        switch (comboBoxtask.SelectedItem)
                        {
                            case "获取控制器运行状态":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyRunStat, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyRunStat GET操作。当前流水号为：" + restful.SN  + rn +
                                        "控制器运行状态为：" + json["data"]["Stat"].ToString(), 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat GET操作。当前流水号为：" + restful.SN + rn +
                                        "信息获取失败，返回信息为：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "获取平台版本信息":
                                json = await restful.GetInfo(userid, token, RESTful.Order.SysVersion, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动SysVersion GET操作。当前流水号为：" + restful.SN + rn + 
                                    "平台系统：" + json["data"]["OS"].ToString() + rn + "系统版本：" + json["data"]["OsVer"] +
                                     rn + "Python版本：" + json["data"]["PythonVer"] + rn + "Gcc版本：" + json["data"]["GccVer"] + rn + "AI版本：" + json["data"]["AIVer"], 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat GET操作。当前流水号为：" + restful.SN + rn +
                                        "信息获取失败，返回信息为：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "获取PyTask的路径":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyTaskFile, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyTaskFile GET操作。当前流水号为：" + restful.SN + rn + 
                                    "根目录为：" + json["data"]["RootPath"].ToString() + rn + "文件目录为：" + json["data"]["FullFileName"].ToString(), 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat GET操作。当前流水号为：" + restful.SN + rn +
                                        "信息获取失败，返回信息为：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "获取Python已安装的库":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyLib, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyLib GET操作。当前流水号为：" + restful.SN + rn + 
                                    "已安装的库有：" + json["data"]["Libs"].ToString(), 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat GET操作。当前流水号为：" + restful.SN + rn +
                                        "信息获取失败，返回信息为：" + json["msg"].ToString(), 1);
                                }
                                break;
                        }
                    }
                    else
                    {
                        //POST命令
                        JObject json = new JObject();
                        string post1 = textBoxpost1.Text.Trim();
                        string post2 = textBoxpost2.Text.Trim();
                        switch (comboBoxtask.SelectedItem)
                        {
                            case "修改密码":
                                if (post1.Length != post2.Length)
                                {
                                    MessageBox.Show("请保持新旧密码长度相同！", "警告");
                                    break;
                                }
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.Password, password, seed);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动Password POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：密码修改成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动Password POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：密码修改失败，原因：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "设置控制器的控制程序的运行调度":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyRunStat, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：运行调度成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyRunStat POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：调度失败，原因：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "设置PyTask的路径":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyTaskFile, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：路径设置成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyTaskFile POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：设置失败，原因：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "安装Python库":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：路径设置成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：安装失败，原因：" + json["msg"].ToString(), 1);
                                }
                                break;
                            case "卸载Python库":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib2, password);
                                if (json["msg"].ToString() == "success")
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：路径设置成功！", 1);
                                }
                                else
                                {
                                    info.AddInfo("启动PyLib POST操作。当前流水号为：" + restful.SN + rn +
                                        "返回消息：卸载失败，原因：" + json["msg"].ToString(), 1);
                                }
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先登录。", "警告");
                }
            }
            catch(Exception ex)
            {
                info.AddInfo(ex.Message, 2);
            }
        }

        public async void GetInfo()
        {
            //一次性获取4次信息
            info.AddInfo("开始获取信息，当前流水号为：" + restful.SN, 1);
            JObject json1 = await restful.GetInfo(userid, token, RESTful.Order.PyRunStat, password);
            if (json1["msg"].ToString() == "success")
            {
                info.AddInfo("控制器运行状态为：" + json1["data"]["Stat"].ToString(), 1);
            }
            else
            {
                info.AddInfo("控制器运行状态信息获取失败，返回信息为：" + json1["msg"].ToString(), 1);
            }
            JObject json2 = await restful.GetInfo(userid, token, RESTful.Order.SysVersion, password);
            if (json2["msg"].ToString() == "success")
            {
                info.AddInfo("平台系统：" + json2["data"]["OS"].ToString() + rn + "系统版本：" + json2["data"]["OsVer"] +
                 rn + "Python版本：" + json2["data"]["PythonVer"] + rn + "Gcc版本：" + json2["data"]["GccVer"] + rn + "AI版本：" + json2["data"]["AIVer"], 1);
            }
            else
            {
                info.AddInfo("平台信息获取失败，返回信息为：" + json2["msg"].ToString(), 1);
            }
            JObject json3 = await restful.GetInfo(userid, token, RESTful.Order.PyTaskFile, password);
            if (json3["msg"].ToString() == "success")
            {
                info.AddInfo("任务文件根目录为：" + json3["data"]["RootPath"].ToString() + rn + "任务文件目录为：" + json3["data"]["FullFileName"].ToString(), 1);
            }
            else
            {
                info.AddInfo("任务文件信息获取失败，返回信息为：" + json3["msg"].ToString(), 1);
            }
            JObject json4 = await restful.GetInfo(userid, token, RESTful.Order.PyLib, password);
            if (json4["msg"].ToString() == "success")
            {
                info.AddInfo("已安装的库有：" + json4["data"]["Libs"].ToString(), 1);
            }
            else
            {
                info.AddInfo("库信息获取失败，返回信息为：" + json4["msg"].ToString(), 1);
            }
            info.AddInfo("信息获取完成，当前流水号为：" + restful.SN, 1);
        }

        private void comboBoxtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            //让label随combobox选项变化
            if (radioButtonpost.Checked)
            {
                textBoxpost2.Enabled = true;
                txttip.Clear();
                switch (comboBoxtask.SelectedItem)
                {
                    case "修改密码":
                        labelpost1.Text = "旧密码：";
                        labelpost2.Text = "新密码：";
                        break;
                    case "设置控制器的控制程序的运行调度":
                        labelpost1.Text = "运行状态：";
                        labelpost2.Text = "运行任务：";
                        break;
                    case "设置PyTask的路径":
                        labelpost1.Text = "目录：";
                        labelpost2.Text = "全路径：";
                        break;
                    case "安装Python库":
                        labelpost1.Text = "安装路径：";
                        labelpost2.Text = "";
                        textBoxpost2.Enabled = false;
                        break;
                    case "卸载Python库":
                        labelpost1.Text = "卸载库名：";
                        labelpost2.Text = "";
                        textBoxpost2.Enabled = false;
                        break;
                }
            }
            else
            {
                labelpost1.Text = "post字段1：";
                labelpost2.Text = "post字段2：";
            }
        }

        private void buttonlogsftp_Click(object sender, EventArgs e)
        {
            //登录sftp
            try
            {
                LogIn logIn = new LogIn("sftp");
                logIn.Text = "登录SFTP";
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    sftp = new SFTPHelper(logIn.ip, logIn.port, logIn.userid, logIn.password);
                    info.AddInfo("开始登陆SFTP服务器：sftp://" + logIn.ip + ":" + logIn.port, 1);
                    sftp.Connect();
                    info.AddInfo("SFTP服务器登陆成功。", 1);
                    textBoxsftplog.Text = "已登录";
                    textBoxsftplog.ForeColor = Color.Green;
                    sftplogflag = true;
                }
                else
                {
                    info.AddInfo("登录已取消。", 2);
                }
            }
            catch (Exception ex)
            {
                info.AddInfo(ex.Message, 2);
                textBoxsftplog.Text = "未登录";
                textBoxsftplog.ForeColor = Color.Black;
            }
        }

        private void buttondisconnsftp_Click(object sender, EventArgs e)
        {
            //sftp断开连接
            if (textBoxsftplog.Text == "已登录") 
            {
                sftp.Disconnect();
                info.AddInfo("已断开SFTP连接。", 1);
                sftplogflag = false;
                textBoxsftplog.Text = "未登录";
                textBoxsftplog.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("SFTP未连接！", "警告");
            }
        }

        private void buttondisconnfmu_Click(object sender, EventArgs e)
        {
            //fmu退出登录
            if (textBoxlogstatus.Text == "已登录")
            {
                restful.DisConnect();
                info.AddInfo("已退出登录。", 1);
                logflag = false;
                textBoxlogstatus.Text = "未登录";
                textBoxlogstatus.ForeColor = Color.Black;
                timerNOP.Stop();
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
                timersavelog.Start();
            }
            else
            {
                timersavelog.Stop();
            }
        }

        private void timersavelog_Tick(object sender, EventArgs e)
        {
            //开启后每5秒自动保存日志
            timersavelog.Interval = 5000;
            Savelog();
        }

        public void Savelog()
        {
            //保存日志
            string path = Application.StartupPath + "\\运行日志\\" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Flush();
            sw.Write(info.tb.Text);
            sw.Close();
        }

        private void checkBoxpyTask_CheckedChanged(object sender, EventArgs e)
        {
            //同步checkbox
            if (checkBoxpyTask.Checked)
            {
                checkBoxtask.Checked = true;
            }
        }

        private void checkBoxtask_CheckedChanged(object sender, EventArgs e)
        {
            //保证task取消后取消另一个
            if (!checkBoxtask.Checked) 
            {
                if (checkBoxpyTask.Checked)
                {
                    checkBoxpyTask.Checked = false;
                }
            }
        }

        private void checkBoxgetinfo_CheckedChanged(object sender, EventArgs e)
        {
            //选择自动获取信息，就把radiobutton移到POST
            if (checkBoxgetinfo.Checked)
            {
                radioButtonpost.Checked = true;
            }
        }

        private void checkBoxpyTask_MouseHover(object sender, EventArgs e)
        {
            //给个小提示
            tip.ToolTips(checkBoxpyTask, "要自动设置目录必须同时部署Task.xml");
        }

        private void textBoxpost1_MouseHover(object sender, EventArgs e)
        {
            //POST语句提示1
            switch (comboBoxtask.SelectedItem)
            {
                case "修改密码":
                    txttip.ToolTips(textBoxpost1, "旧密码。");
                    break;
                case "设置控制器的控制程序的运行调度":
                    txttip.ToolTips(textBoxpost1, "命令：RUN（运行），STOP（停止），RESET（复位），RELOAD（重载）。");
                    break;
                case "设置PyTask的路径":
                    txttip.ToolTips(textBoxpost1, "任务文件存放的目录。");
                    break;
                case "安装Python库":
                    txttip.ToolTips(textBoxpost1, "Python库的安装文件路径。");
                    break;
                case "卸载Python库":
                    txttip.ToolTips(textBoxpost1, "Python库名。");
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
                case "设置控制器的控制程序的运行调度":
                    txttip.ToolTips(textBoxpost2, "多个任务名之间用英文逗号隔开。如果为空，则命令针对控制器内的全部任务。");
                    break;
                case "设置PyTask的路径":
                    txttip.ToolTips(textBoxpost2, "任务配置文件的路径和文件名信息。");
                    break;
            }
        }

    }
}
