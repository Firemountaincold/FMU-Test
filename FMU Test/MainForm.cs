using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public InfoTools info;
        public RESTful restful = new RESTful();
        public string FMUpath = "";
        public string Callpath = "";
        public string ip;
        public string port;
        public string userid;
        public string password;
        public string token;
        public MainForm()
        {
            InitializeComponent();
            info = new InfoTools(richTextBoxinfo);
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
            timerNOP.Interval = restful.GetTokenTime() * 1000;
            restful.GetNOP(userid, token);
        }

        private async void buttonlogin_ClickAsync(object sender, EventArgs e)
        {
            //登录
            try
            {
                LogIn logIn = new LogIn();
                if (logIn.ShowDialog() == DialogResult.OK)
                {
                    ip = logIn.ip;
                    port = logIn.port;
                    userid = logIn.userid;
                    password = logIn.password;
                    info.AddInfo("开始登录……", 1);
                    string seed = await restful.GetSeed(userid, "W");
                    info.AddInfo("已获得种子:" + seed, 1);
                    token = await restful.GetToken(userid, password, seed);
                    info.AddInfo("已获得令牌" + token + "，登陆成功。", 1);
                    textBoxlogstatus.Text = "已登录";
                    textBoxlogstatus.ForeColor = Color.Green;
                    timerNOP.Start();
                }
                else
                {
                    info.AddInfo("登录已取消。", 2);
                }
            }
            catch(Exception ex)
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
                comboBoxtask.Items.Add("获取控制器的诊断状态");
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

        private void buttondo_Click(object sender, EventArgs e)
        {
            if (radioButtonget.Checked)
            {
                //GET命令
                switch (comboBoxtask.SelectedItem)
                {
                    case "获取控制器运行状态":

                        break;
                    case "获取控制器的诊断状态":

                        break;
                    case "获取PyTask的路径":

                        break;
                    case "获取Python已安装的库":

                        break;
                }
            }
            else
            {
                //POST命令
                switch (comboBoxtask.SelectedItem)
                {
                    case "修改密码":

                        break;
                    case "设置控制器的控制程序的运行调度":

                        break;
                    case "设置PyTask的路径":

                        break;
                    case "安装Python库":

                        break;
                    case "卸载Python库":

                        break;
                }
            }
        }

        private void comboBoxtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonpost.Checked)
            {
                switch (comboBoxtask.SelectedItem)
                {
                    case "修改密码":
                        labelpost1.Text = "旧密码：";
                        labelpost2.Text = "新密码：";
                        break;
                    case "设置控制器的控制程序的运行调度":

                        break;
                    case "设置PyTask的路径":

                        break;
                    case "安装Python库":

                        break;
                    case "卸载Python库":

                        break;
                }
            }
        }
    }
}
