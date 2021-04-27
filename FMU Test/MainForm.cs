using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public InfoTools info;
        public string FMUpath = "";
        public string Callpath = "";
        public MainForm()
        {
            InitializeComponent();
            info = new InfoTools(richTextBoxinfo);
        }

        private void buttonFMU_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
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
            GetTask getTask = new GetTask();
            if (getTask.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
