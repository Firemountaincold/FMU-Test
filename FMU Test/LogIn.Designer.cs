
namespace FMU_Test
{
    partial class LogIn
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxuserid = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "用户名：";
            // 
            // textBoxport
            // 
            this.textBoxport.Location = new System.Drawing.Point(92, 60);
            this.textBoxport.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(162, 21);
            this.textBoxport.TabIndex = 12;
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(92, 29);
            this.textBoxip.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(162, 21);
            this.textBoxip.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP:";
            // 
            // textBoxuserid
            // 
            this.textBoxuserid.Location = new System.Drawing.Point(92, 94);
            this.textBoxuserid.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxuserid.Name = "textBoxuserid";
            this.textBoxuserid.Size = new System.Drawing.Size(162, 21);
            this.textBoxuserid.TabIndex = 15;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(92, 129);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(162, 21);
            this.textBoxpassword.TabIndex = 16;
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonok.Location = new System.Drawing.Point(31, 178);
            this.buttonok.Margin = new System.Windows.Forms.Padding(2);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(113, 20);
            this.buttonok.TabIndex = 17;
            this.buttonok.Text = "登录";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(148, 178);
            this.buttoncancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(106, 20);
            this.buttoncancel.TabIndex = 18;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // LogIn
            // 
            this.AcceptButton = this.buttonok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(288, 226);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxuserid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxport);
            this.Controls.Add(this.textBoxip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxuserid;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button buttoncancel;
    }
}