
namespace FMU_Test
{
    partial class Tasks
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.Font = new System.Drawing.Font("宋体", 11F);
            this.treeView.Location = new System.Drawing.Point(13, 13);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(288, 269);
            this.treeView.TabIndex = 0;
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(184, 296);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(110, 25);
            this.buttoncancel.TabIndex = 4;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.BackColor = System.Drawing.Color.SeaShell;
            this.buttonselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonselect.Location = new System.Drawing.Point(19, 296);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(110, 25);
            this.buttonselect.TabIndex = 5;
            this.buttonselect.Text = "选择";
            this.buttonselect.UseVisualStyleBackColor = false;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(313, 333);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "任务选择";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonselect;
    }
}