using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FMU_Test
{
    public partial class GetTasks : Form
    {
        public XmlDocument xmlDocument = new XmlDocument();
        public XmlElement root;
        public TipTools tip = new TipTools();
        public int num = 0;
        public string[] name = new string[0];
        public bool loaded = false;
        public Dictionary<string, string> vars = new Dictionary<string, string>();
        public GetTasks()
        {
            InitializeComponent();
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", ""));
            root = xmlDocument.CreateElement("Tasks");
            root.SetAttribute("xmlns:tasks", "http://www.hollysys.com/IAS/control");
            xmlDocument.AppendChild(root);
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            //添加任务
            GetTask getTask = new GetTask(xmlDocument, root);
            getTask.loaded = loaded;
            if (loaded)
            {
                getTask.vars = vars;
            }
            if (getTask.ShowDialog() == DialogResult.OK)
            {
                if (CheckCopy(name, getTask.name)) 
                {
                    MessageBox.Show("任务名重复，请重新添加！", "警告");
                }
                else
                {
                    num++;
                    textBoxnum.Text = num.ToString();
                    Array.Resize(ref name, num);
                    name[num - 1] = getTask.name;
                    FreshName();
                }
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            //保存xml文件
            if (!Directory.Exists(Application.StartupPath + "\\XML文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\XML文件");
            }
            xmlDocument.Save(Application.StartupPath + "\\XML文件\\Task.xml");
            string xmltxt = File.ReadAllText(Application.StartupPath + "\\XML文件\\Task.xml");
            File.WriteAllText(Application.StartupPath + "\\XML文件\\Task.xml", xmltxt.Replace("======", "&#x0020;"));
            DialogResult = DialogResult.OK;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }

        public void FreshName()
        {
            //刷新已添加的任务名
            textBoxinfo.Text = "已添加的任务：";
            for (int i = 0; i < name.Length - 1; i++)
            {
                textBoxinfo.AppendText(name[i] + "、");
            }
            textBoxinfo.AppendText(name[name.Length - 1]);
        }

        public bool CheckCopy(string[] obj, string objs)
        {
            //检查名称是否重复
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    if (objs == obj[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonadd_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonadd, "添加任务定义信息，每个任务有一个唯一的名字");
        }
    }
}
