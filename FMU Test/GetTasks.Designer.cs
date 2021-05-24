
namespace FMU_Test
{
    partial class GetTasks
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "任务数量：";
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxinfo.Location = new System.Drawing.Point(12, 77);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.Size = new System.Drawing.Size(278, 110);
            this.textBoxinfo.TabIndex = 0;
            this.textBoxinfo.Text = "已添加的任务：暂无。";
            // 
            // textBoxnum
            // 
            this.textBoxnum.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnum.Location = new System.Drawing.Point(230, 36);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.ReadOnly = true;
            this.textBoxnum.Size = new System.Drawing.Size(43, 14);
            this.textBoxnum.TabIndex = 1;
            this.textBoxnum.Text = "0";
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadd.Location = new System.Drawing.Point(23, 32);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(112, 20);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "添加任务";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            this.buttonadd.MouseHover += new System.EventHandler(this.buttonadd_MouseHover);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsave.Location = new System.Drawing.Point(23, 204);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(112, 20);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "生成xml文件";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(162, 204);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(112, 20);
            this.buttoncancel.TabIndex = 2;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // GetTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(302, 238);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GetTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成Tasks.xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttoncancel;
    }
}