using System;
using System.Windows.Forms;
using System.Xml;

namespace FMU_Test
{
    public partial class Tasks : Form
    {
        public string[] tasks = new string[0];
        public XmlDocument xmlDocument = new XmlDocument();
        public string returnstr = "";

        public Tasks(string xmlpath)
        {
            InitializeComponent();
            ReadTask(xmlpath);
            InitTree();
        }

        public void ReadTask(string xmlpath)
        {
            //从xml文件读取任务名
            xmlDocument.Load(xmlpath);
            XmlElement root = xmlDocument.DocumentElement;
            Array.Resize(ref tasks, root.ChildNodes.Count);
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                XmlElement task = (XmlElement)root.ChildNodes.Item(i);
                tasks[i] = task.GetAttribute("Name").ToString();
            }
        }

        public void InitTree()
        {
            //初始化树状图
            foreach (var t in tasks)
            {
                treeView.Nodes.Add(t);
            }
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            //把选择的节点连成字符串
            returnstr = "";
            foreach (TreeNode t in treeView.Nodes)
            {
                if (t.Checked)
                {
                    returnstr += t.Text + ",";
                }
            }
            returnstr = returnstr.TrimEnd(',');
            DialogResult = DialogResult.OK;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }
    }
}
