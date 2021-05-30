using System;
using System.Configuration;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class LogIn : Form
    {
        public string ip;
        public string port;
        public string userid;
        public string password;
        public string type;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public LogIn(string type)
        {
            InitializeComponent();
            //同时用于两个登录窗口，所以需要两种初始化
            this.type = type;
            if (type == "fmu")
            {
                Text = "登录RESTful API";
                textBoxip.Text = ConfigurationManager.AppSettings["fmuip"]; 
                textBoxport.Text = ConfigurationManager.AppSettings["fmuport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["fmuuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["fmupw"];
            }
            else if (type == "sftp")
            {
                Text = "登录SFTP";
                textBoxip.Text = ConfigurationManager.AppSettings["sftpip"];
                textBoxport.Text = ConfigurationManager.AppSettings["sftpport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["sftpuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["sftppw"];
            }
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            //登录，并询问是否保存改变的信息
            if (textBoxip.Text != "" && textBoxpassword.Text != "" && textBoxport.Text != "" && textBoxuserid.Text != "")
            {
                ip = textBoxip.Text;
                port = textBoxport.Text;
                userid = textBoxuserid.Text;
                password = textBoxpassword.Text;
                if (!Compare())
                {
                    if (MessageBox.Show("检测到登录信息改变，是否保存现在的登录信息？", "询问", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (type == "fmu")
                        {
                            config.AppSettings.Settings["fmuip"].Value = ip;
                            config.AppSettings.Settings["fmuport"].Value = port;
                            config.AppSettings.Settings["fmuuser"].Value = userid;
                            config.AppSettings.Settings["fmupw"].Value = password;
                        }
                        else if (type == "sftp")
                        {
                            config.AppSettings.Settings["sftpip"].Value = ip;
                            config.AppSettings.Settings["sftpport"].Value = port;
                            config.AppSettings.Settings["sftpuser"].Value = userid;
                            config.AppSettings.Settings["sftppw"].Value = password;
                        }
                        config.Save(ConfigurationSaveMode.Modified);
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请填写必要的信息！", "警告");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }

        public bool Compare()
        {
            //对比登录信息是否改变
            if (type == "fmu")
            {
                if (textBoxip.Text == ConfigurationManager.AppSettings["fmuip"] && textBoxport.Text == ConfigurationManager.AppSettings["fmuport"] && 
                    textBoxuserid.Text == ConfigurationManager.AppSettings["fmuuser"] && textBoxpassword.Text == ConfigurationManager.AppSettings["fmupw"])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (type == "sftp") 
            {
                if (textBoxip.Text == ConfigurationManager.AppSettings["sftpip"] && textBoxport.Text == ConfigurationManager.AppSettings["sftpport"] &&
                    textBoxuserid.Text == ConfigurationManager.AppSettings["sftpuser"] && textBoxpassword.Text == ConfigurationManager.AppSettings["sftppw"])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
