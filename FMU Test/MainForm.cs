using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public InfoTools info;
        public RESTful restful = new RESTful();
        public SFTPHelper sftp;
        public string FMUpath = "";
        public string Callpath = "";
        public string ip;
        public string port;
        public string userid;
        public string password;
        public string token;
        public string rn = "\r\n                       ";
        public bool logflag = false;

        public MainForm()
        {
            InitializeComponent();
            info = new InfoTools(richTextBoxinfo);
            if (DateTime.Now.Hour > 9)
            {
                rn = rn + " ";
            }
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {   // 总是接受  
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

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //用SFTP部署文件
            if (FMUpath != "" && Callpath != "" && textBoxRemotePath.Text != "")
            {
                sftp.Put(FMUpath, textBoxRemotePath.Text);
                info.AddInfo("已上传dll文件。", 1);
                sftp.Put(Callpath, textBoxRemotePath.Text);
                info.AddInfo("已上传py文件。", 1);
                if (checkBoxtask.Checked)
                {
                    sftp.Put(Application.StartupPath + "\\XML文件\\Task.xml", textBoxRemotePath.Text);
                    info.AddInfo("已上传Task.xml。", 1);
                }
            }
            else
            {
                MessageBox.Show("请选择好要部署的文件和目录。", "警告");
            }
        }

        private void buttonGetTask_Click(object sender, EventArgs e)
        {
            //生成Task.xml
            GetTask getTask = new GetTask();
            if (getTask.ShowDialog() == DialogResult.OK)
            {
                info.AddInfo("创建成功！已保存到" + Application.StartupPath + "\\XML文件\\Task.xml", 1);
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
                Process.GetCurrentProcess().Kill();
                Application.Exit();
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

        private void timerNOP_Tick(object sender, EventArgs e)
        {
            //保持连接
            if (restful.GetTokenTime() > 0)
            {
                timerNOP.Interval = restful.GetTokenTime() * 1000;
            }
            restful.GetNOP(userid, token, password);
        }

        private async void buttonlogin_ClickAsync(object sender, EventArgs e)
        {
            //登录
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);//验证服务器证书回调自动验证
                LogIn logIn = new LogIn();
                logIn.Text = "登录RESTful API";
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    ip = logIn.ip;
                    port = logIn.port;
                    userid = logIn.userid;
                    password = logIn.password;
                    info.AddInfo("开始登录……", 1);
                    restful.GetClient(ip, port);
                    string seed = await restful.GetSeed(userid, "W");
                    info.AddInfo("已获得种子:" + seed, 1);
                    token = await restful.GetToken(userid, password, seed);
                    info.AddInfo("已获得令牌" + token + "，登陆成功。", 1);
                    textBoxlogstatus.Text = "已登录";
                    textBoxlogstatus.ForeColor = Color.Green;
                    logflag = true;
                    timerNOP.Start();
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
                    info.AddInfo("当前SN号为：" + restful.SN + "，MD5为：" + restful.GetMD5(restful.SN.ToString() + password), 1);
                    if (radioButtonget.Checked)
                    {
                        //GET命令
                        JObject json = new JObject();
                        switch (comboBoxtask.SelectedItem)
                        {
                            case "获取控制器运行状态":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyRunStat, password);
                                info.AddInfo("控制器运行状态为：" + json["data"]["Stat"].ToString(), 1);
                                break;
                            case "获取平台版本信息":
                                json = await restful.GetInfo(userid, token, RESTful.Order.SysVersion, password);
                                info.AddInfo("平台系统：" + json["data"]["OS"].ToString() + rn + "Os版本：" + json["data"]["OsVer"] +
                                     rn + "Python版本：" + json["data"]["PythonVer"] + rn + "Gcc版本：" + json["data"]["GccVer"] + rn + "AI版本：" + json["data"]["AIVer"], 1);
                                break;
                            case "获取PyTask的路径":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyTaskFile, password);
                                info.AddInfo("根目录为：" + json["data"]["RootPath"].ToString() + rn + "文件目录为：" + json["data"]["FullFileName"].ToString(), 1);
                                break;
                            case "获取Python已安装的库":
                                json = await restful.GetInfo(userid, token, RESTful.Order.PyLib, password);
                                info.AddInfo("已安装的库有：" + json["data"]["Libs"].ToString(), 1);
                                break;
                        }
                    }
                    else
                    {
                        //POST命令
                        JObject json = new JObject();
                        string post1 = textBoxpost1.Text;
                        string post2 = textBoxpost2.Text;
                        switch (comboBoxtask.SelectedItem)
                        {
                            case "修改密码":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.Password, password);
                                break;
                            case "设置控制器的控制程序的运行调度":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyRunStat, password);
                                break;
                            case "设置PyTask的路径":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyTaskFile, password);
                                break;
                            case "安装Python库":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib, password);
                                break;
                            case "卸载Python库":
                                json = await restful.PostInfo(userid, token, post1, post2, RESTful.Order.PyLib2, password);
                                break;
                        }
                        info.AddInfo("返回消息：" + json["msg"].ToString(), 1);
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

        private void comboBoxtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonpost.Checked)
            {
                textBoxpost2.Enabled = true;
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
            try
            {
                LogIn logIn = new LogIn();
                logIn.Text = "登录SFTP";
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    sftp = new SFTPHelper(logIn.ip, logIn.port, logIn.userid, logIn.password);
                    sftp.Connect();
                    info.AddInfo("SFTP服务器登陆成功。", 1);
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
    }
}
