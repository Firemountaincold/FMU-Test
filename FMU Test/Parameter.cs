using System;
using System.Collections;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class Parameter : Form
    {
        private ArrayList param = new ArrayList();
        public string[] namespacename = new string[0];
        public string[] programname = new string[0];
        public string[] typename = new string[0];
        public Xml10 returnvar;

        public Parameter(ArrayList param)
        {
            InitializeComponent();
            this.param = param;
            InitTree();
        }

        public void InitTree()
        {
            //初始化树状图
            foreach (Xml10 para in param)
            {
                if (!CompareStr(para.xnamespace, namespacename))
                {
                    Array.Resize(ref namespacename, namespacename.Length + 1);
                    namespacename[namespacename.Length - 1] = para.xnamespace;
                }
            }
            int i = 0;
            foreach (string nsn in namespacename)
            {
                treeViewpara.Nodes.Add("命名空间:" + nsn);
                treeViewpara.Nodes[i].Tag = nsn;
                treeViewpara.Nodes[i].SelectedImageIndex = 0;
                treeViewpara.Nodes[i].ImageIndex = 0;
                treeViewpara.Nodes[i].Nodes.Add("");
                i++;
            }
        }

        public bool CompareStr(string str1, string[] str2)
        {
            //查询数组中是否有重复的
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1 == str2[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void treeViewpara_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //展开树状图
            try
            {
                e.Node.Nodes.Clear();
                if (e.Node.Level == 0)
                {
                    //点击之前，先填充节点：
                    string ns = e.Node.Tag.ToString();
                    programname = new string[0];
                    foreach (Xml10 para in param)
                    {
                        if (para.xnamespace == ns && !CompareStr(para.xprogram, programname))
                        {
                            Array.Resize(ref programname, programname.Length + 1);
                            programname[programname.Length - 1] = para.xprogram;
                        }
                    }
                    int i = 0;
                    foreach (string pn in programname)
                    {
                        e.Node.Nodes.Add("Program:" + pn);
                        e.Node.Nodes[i].Tag = pn;
                        e.Node.Nodes[i].SelectedImageIndex = 1;
                        e.Node.Nodes[i].ImageIndex = 1;
                        e.Node.Nodes[i].Nodes.Add("");
                        i++;
                    }
                }
                else if (e.Node.Level == 1)
                {
                    //点击之前，先填充节点：
                    string ns = e.Node.Parent.Tag.ToString();
                    string p = e.Node.Tag.ToString();
                    typename = new string[0];
                    foreach (Xml10 para in param)
                    {
                        if (para.xnamespace == ns && para.xprogram == p && !CompareStr(para.xtype, typename))
                        {
                            Array.Resize(ref typename, typename.Length + 1);
                            typename[typename.Length - 1] = para.xtype;
                        }
                    }
                    int i = 0;
                    foreach (string tn in typename)
                    {
                        e.Node.Nodes.Add("变量类型:" + tn);
                        e.Node.Nodes[i].Tag = tn;
                        e.Node.Nodes[i].SelectedImageIndex = 2;
                        e.Node.Nodes[i].ImageIndex = 2;
                        e.Node.Nodes[i].Nodes.Add("");
                        i++;
                    }
                }
                else if (e.Node.Level == 2)
                {
                    //点击之前，先填充节点：
                    string ns = e.Node.Parent.Parent.Tag.ToString();
                    string p = e.Node.Parent.Tag.ToString();
                    string t = e.Node.Tag.ToString();
                    int i = 0;
                    foreach (Xml10 para in param)
                    {
                        if (para.xnamespace == ns && para.xprogram == p && para.xtype == t)
                        {
                            e.Node.Nodes.Add(para.xvar);
                            e.Node.Nodes[i].Tag = para;
                            e.Node.Nodes[i].SelectedImageIndex = 3;
                            e.Node.Nodes[i].ImageIndex = 3;
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            //选择变量
            if (treeViewpara.SelectedNode.Level == 3)
            {
                returnvar = (Xml10)treeViewpara.SelectedNode.Tag;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请选择一个变量！", "警告");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }
    }
}
