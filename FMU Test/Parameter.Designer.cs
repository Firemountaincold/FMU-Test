
namespace FMU_Test
{
    partial class Parameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameter));
            this.treeViewpara = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewpara
            // 
            this.treeViewpara.ImageIndex = 0;
            this.treeViewpara.ImageList = this.imageList;
            this.treeViewpara.Location = new System.Drawing.Point(13, 13);
            this.treeViewpara.Name = "treeViewpara";
            this.treeViewpara.SelectedImageIndex = 0;
            this.treeViewpara.Size = new System.Drawing.Size(339, 366);
            this.treeViewpara.TabIndex = 0;
            this.treeViewpara.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewpara_BeforeExpand);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "namespace");
            this.imageList.Images.SetKeyName(1, "program");
            this.imageList.Images.SetKeyName(2, "type");
            this.imageList.Images.SetKeyName(3, "varible");
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(203, 389);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 2;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.BackColor = System.Drawing.Color.SeaShell;
            this.buttonselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonselect.Location = new System.Drawing.Point(38, 389);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(125, 25);
            this.buttonselect.TabIndex = 3;
            this.buttonselect.Text = "选择";
            this.buttonselect.UseVisualStyleBackColor = false;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(364, 426);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.treeViewpara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择变量";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewpara;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.ImageList imageList;
    }
}