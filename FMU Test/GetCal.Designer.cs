
namespace FMU_Test
{
    partial class GetCal
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxuri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadd.Location = new System.Drawing.Point(39, 80);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 20);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "添加";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(166, 80);
            this.buttoncancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(94, 20);
            this.buttoncancel.TabIndex = 3;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算任务名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件位置：";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(105, 14);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(176, 21);
            this.textBoxname.TabIndex = 0;
            this.textBoxname.MouseHover += new System.EventHandler(this.textBoxname_MouseHover);
            // 
            // textBoxuri
            // 
            this.textBoxuri.Location = new System.Drawing.Point(105, 38);
            this.textBoxuri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxuri.Name = "textBoxuri";
            this.textBoxuri.Size = new System.Drawing.Size(176, 21);
            this.textBoxuri.TabIndex = 1;
            this.textBoxuri.MouseHover += new System.EventHandler(this.textBoxuri_MouseHover);
            // 
            // GetCal
            // 
            this.AcceptButton = this.buttonadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(290, 116);
            this.Controls.Add(this.textBoxuri);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加计算任务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxuri;
    }
}