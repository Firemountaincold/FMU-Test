
namespace FMU_Test
{
    partial class SFTPExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFTPExplorer));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("混合控制器");
            this.buttonselect = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonselect
            // 
            this.buttonselect.BackColor = System.Drawing.Color.SeaShell;
            this.buttonselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonselect.Location = new System.Drawing.Point(68, 417);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(125, 25);
            this.buttonselect.TabIndex = 1;
            this.buttonselect.Text = "选择";
            this.buttonselect.UseVisualStyleBackColor = false;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(277, 417);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 1;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pc");
            this.imageList.Images.SetKeyName(1, "dir");
            this.imageList.Images.SetKeyName(2, "file");
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextMenuStrip;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(13, 13);
            this.treeView.Name = "treeView";
            treeNode1.Name = "节点0";
            treeNode1.Text = "混合控制器";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(435, 396);
            this.treeView.TabIndex = 2;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择ToolStripMenuItem,
            this.删除文件ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            this.选择ToolStripMenuItem.Click += new System.EventHandler(this.选择ToolStripMenuItem_Click);
            // 
            // 删除文件ToolStripMenuItem
            // 
            this.删除文件ToolStripMenuItem.Name = "删除文件ToolStripMenuItem";
            this.删除文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除文件ToolStripMenuItem.Text = "删除文件";
            this.删除文件ToolStripMenuItem.Click += new System.EventHandler(this.删除文件ToolStripMenuItem_Click);
            // 
            // SFTPExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonselect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SFTPExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SFTPExplorer";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件ToolStripMenuItem;
    }
}