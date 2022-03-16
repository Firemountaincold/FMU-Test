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
        Configuration config;

        public LogIn(string type, Configuration config)
        {
            InitializeComponent();
            //同时用于两个登录窗口，所以需要两种初始化
            this.type = type;
            this.config = config;
            if (type == "fmu")
            {
                Text = "配置RESTful";
                textBoxip.Text = ConfigurationManager.AppSettings["fmuip"]; 
                textBoxport.Text = ConfigurationManager.AppSettings["fmuport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["fmuuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["fmupw"];
                buttonok.Text = "保存并登录";
            }
            else if (type == "sftp")
            {
                Text = "配置SFTP";
                textBoxip.Text = ConfigurationManager.AppSettings["sftpip"];
                textBoxport.Text = ConfigurationManager.AppSettings["sftpport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["sftpuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["sftppw"];
                buttonok.Text = "保存并登录";
            }
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            //保存改变的信息
            if (textBoxip.Text != "" && textBoxpassword.Text != "" && textBoxport.Text != "" && textBoxuserid.Text != "")
            {
                ip = textBoxip.Text;
                port = textBoxport.Text;
                userid = textBoxuserid.Text;
                password = textBoxpassword.Text;
                if (!Compare())
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
