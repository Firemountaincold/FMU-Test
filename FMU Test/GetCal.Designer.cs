
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
            this.buttonadd.Location = new System.Drawing.Point(52, 100);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(125, 25);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "添加";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(221, 100);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 3;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算任务名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件位置：";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(140, 18);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(234, 25);
            this.textBoxname.TabIndex = 0;
            // 
            // textBoxuri
            // 
            this.textBoxuri.Location = new System.Drawing.Point(140, 48);
            this.textBoxuri.Name = "textBoxuri";
            this.textBoxuri.Size = new System.Drawing.Size(234, 25);
            this.textBoxuri.TabIndex = 1;
            // 
            // GetCal
            // 
            this.AcceptButton = this.buttonadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(386, 145);
            this.Controls.Add(this.textBoxuri);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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