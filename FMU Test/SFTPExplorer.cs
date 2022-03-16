using System;
using System.Collections;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class SFTPExplorer : Form
    {
        public bool getdir = false;
        public SFTPHelper sftp;
        public string returnpath = "";
        public TreeNode temp;
        public bool ispy = false;
        public string firstpath = "/";

        public SFTPExplorer(SFTPHelper sftp, bool getdir, bool download, string path="", bool getfile=false)
        {
            //初始化
            InitializeComponent();
            this.getdir = getdir;
            this.sftp = sftp;
            if (path != "")
            {
                firstpath = path;
            }
            SFTPinfo tree = new SFTPinfo("tree", firstpath, true, true);
            treeView.Nodes[0].Tag = tree;
            treeView.Nodes[0].Expand();
            ShowDir(treeView.Nodes[0], firstpath);
            if (firstpath != "/")
            {
                treeView.Nodes[0].Text = "调度策略根目录";
            }
            if (getdir) 
            {
                Text = "选择SFTP远程文件夹";
                buttonselect.Text = "选择文件夹";
                选择ToolStripMenuItem.Text = "选择文件夹";
            }
            else if(download)
            {
                Text = "下载SFTP远程文件";
                buttonselect.Text = "下载文件";
                选择ToolStripMenuItem.Text = "下载文件";
            }
            else if (getfile)
            {
                Text = "选择SFTP远程文件";
                buttonselect.Text = "选择文件";
                选择ToolStripMenuItem.Text = "选择文件";
            }
            else
            {
                Text = "选择控制算法";
                buttonselect.Text = "选择python文件";
                选择ToolStripMenuItem.Text = "选择python文件";
                ispy = true;
            }
        }

        public void ShowDir(TreeNode tn, string dir)
        {
            //填充树状图
            try
            {
                ArrayList sftpinfo = sftp.GetFileList(dir);
                int i = 0;
                foreach (SFTPinfo info in sftpinfo)
                {
                    if (info.name != ".." && info.name != "." && info.name != "") 
                    {
                        tn.Nodes.Add(info.name);
                        tn.Nodes[i].Tag = info;
                        if (info.isdir)
                        {
                            tn.Nodes[i].SelectedImageIndex = 1;
                            tn.Nodes[i].ImageIndex = 1;
                            tn.Nodes[i].Nodes.Add("");
                        }
                        else
                        {
                            tn.Nodes[i].SelectedImageIndex = 2;
                            tn.Nodes[i].ImageIndex = 2;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //展开树状图
            try
            {
                if (e.Node.Level > 0)
                {
                    e.Node.Nodes.Clear();
                    SFTPinfo info = (SFTPinfo)e.Node.Tag;
                    if (!info.isOtherRead)
                    {
                        MessageBox.Show("用户权限不足！", "警告");
                        return;
                    }
                    //点击之前，先填充节点：
                    string path = info.path;
                    if (!path.EndsWith("/"))
                    {
                        path += "/";
                    }
                    ShowDir(e.Node, path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        public void SelectItem(TreeNode tn)
        {
            //选择节点，返回地址
            SFTPinfo info = (SFTPinfo)tn.Tag;
            if (getdir)
            {
                if (info.isdir)
                {
                    returnpath = info.path + "/";
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("请选择文件夹！", "警告");
                }
            }
            else
            {
                if (!info.isdir)
                {
                    if (ispy)
                    {
                        if (info.path.EndsWith(".py"))
                        {
                            returnpath = info.path;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("请选择python文件(*.py)！", "警告");
                        }
                    }
                    else
                    {
                        returnpath = info.path;
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("请选择文件！", "警告");
                }
            }
        }

        public void RefreshTree(TreeNode tn)
        {
            //刷新目录
            tn.Nodes.Clear();
            SFTPinfo tree = (SFTPinfo)tn.Tag;
            ShowDir(tn, tree.path);
            tn.Expand();
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            //选择文件或文件夹
            SelectItem(treeView.SelectedNode);
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择文件或文件夹
            SelectItem(temp);
        }

        private void 删除文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //右键删除文件
            SFTPinfo info = (SFTPinfo)temp.Tag;
            if (!info.isOtherRead)
            {
                MessageBox.Show("用户权限不足！", "警告");
                return;
            }
            else
            {
                TreeNode p = temp.Parent;
                sftp.Delete(info.path);
                RefreshTree(p);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //右击树状图
            if (e.Button != MouseButtons.Right) return;
            if (e.Node == null) return; //无节点
            if (e.Node.Level == 0) return;
            treeView.SelectedNode = e.Node;
            temp = e.Node;
            if (treeView.SelectedNode != null)
            {
                SFTPinfo info = (SFTPinfo)temp.Tag;
                if (info.isdir)
                {
                    选择ToolStripMenuItem.Enabled = false;
                    删除文件ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    选择ToolStripMenuItem.Enabled = true;
                    删除文件ToolStripMenuItem.Enabled = true;
                }
            }
        }
    }
}
