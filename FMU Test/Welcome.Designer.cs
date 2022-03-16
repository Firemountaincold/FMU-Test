
namespace FMU_Test
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.labelsftp = new System.Windows.Forms.Label();
            this.labelrest = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsftp
            // 
            this.labelsftp.AutoSize = true;
            this.labelsftp.Font = new System.Drawing.Font("宋体", 11F);
            this.labelsftp.Location = new System.Drawing.Point(143, 32);
            this.labelsftp.Name = "labelsftp";
            this.labelsftp.Size = new System.Drawing.Size(15, 15);
            this.labelsftp.TabIndex = 0;
            this.labelsftp.Text = " ";
            // 
            // labelrest
            // 
            this.labelrest.AutoSize = true;
            this.labelrest.Font = new System.Drawing.Font("宋体", 11F);
            this.labelrest.Location = new System.Drawing.Point(143, 85);
            this.labelrest.Name = "labelrest";
            this.labelrest.Size = new System.Drawing.Size(15, 15);
            this.labelrest.TabIndex = 0;
            this.labelrest.Text = " ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 11F);
            this.label.Location = new System.Drawing.Point(143, 137);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(15, 15);
            this.label.TabIndex = 0;
            this.label.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(358, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelrest);
            this.Controls.Add(this.labelsftp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用FMU部署工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsftp;
        private System.Windows.Forms.Label labelrest;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}