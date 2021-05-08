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
        public LogIn(string type)
        {
            InitializeComponent();
            if (type == "fmu")
            {
                textBoxip.Text = ConfigurationManager.AppSettings["fmuip"]; 
                textBoxport.Text = ConfigurationManager.AppSettings["fmuport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["fmuuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["fmupw"];
            }
            else if (type == "sftp")
            {
                textBoxip.Text = ConfigurationManager.AppSettings["sftpip"];
                textBoxport.Text = ConfigurationManager.AppSettings["sftpport"];
                textBoxuserid.Text = ConfigurationManager.AppSettings["sftpuser"];
                textBoxpassword.Text = ConfigurationManager.AppSettings["sftppw"];
            }
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            if (textBoxip.Text != "" && textBoxpassword.Text != "" && textBoxport.Text != "" && textBoxuserid.Text != "")
            {
                ip = textBoxip.Text;
                port = textBoxport.Text;
                userid = textBoxuserid.Text;
                password = textBoxpassword.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请填写必要的信息！", "警告");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
