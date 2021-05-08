
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
            this.label7.Location = new System.Drawing.Point(39, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "用户名：";
            // 
            // textBoxport
            // 
            this.textBoxport.Location = new System.Drawing.Point(123, 75);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(215, 25);
            this.textBoxport.TabIndex = 12;
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(123, 36);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(215, 25);
            this.textBoxip.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP:";
            // 
            // textBoxuserid
            // 
            this.textBoxuserid.Location = new System.Drawing.Point(123, 117);
            this.textBoxuserid.Name = "textBoxuserid";
            this.textBoxuserid.Size = new System.Drawing.Size(215, 25);
            this.textBoxuserid.TabIndex = 15;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(123, 161);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(215, 25);
            this.textBoxpassword.TabIndex = 16;
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(42, 223);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(125, 25);
            this.buttonok.TabIndex = 17;
            this.buttonok.Text = "登录";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(213, 223);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 18;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // LogIn
            // 
            this.AcceptButton = this.buttonok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 283);
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