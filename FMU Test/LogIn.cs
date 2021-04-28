using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class LogIn : Form
    {
        public string ip;
        public string port;
        public string userid;
        public string password;
        public LogIn()
        {
            InitializeComponent();
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
