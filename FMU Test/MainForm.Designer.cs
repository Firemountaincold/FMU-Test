
namespace FMU_Test
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxinfo = new System.Windows.Forms.RichTextBox();
            this.buttonFMU = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.textBoxRemotePath = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFMUstatus = new System.Windows.Forms.TextBox();
            this.textBoxCallstatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCallstatus);
            this.groupBox1.Controls.Add(this.textBoxFMUstatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUpload);
            this.groupBox1.Controls.Add(this.textBoxRemotePath);
            this.groupBox1.Controls.Add(this.buttonCall);
            this.groupBox1.Controls.Add(this.buttonFMU);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件部署";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGetTask);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // richTextBoxinfo
            // 
            this.richTextBoxinfo.Location = new System.Drawing.Point(13, 291);
            this.richTextBoxinfo.Name = "richTextBoxinfo";
            this.richTextBoxinfo.Size = new System.Drawing.Size(821, 255);
            this.richTextBoxinfo.TabIndex = 2;
            this.richTextBoxinfo.Text = "";
            // 
            // buttonFMU
            // 
            this.buttonFMU.Location = new System.Drawing.Point(27, 24);
            this.buttonFMU.Name = "buttonFMU";
            this.buttonFMU.Size = new System.Drawing.Size(150, 25);
            this.buttonFMU.TabIndex = 0;
            this.buttonFMU.Text = "选择FMU.dll";
            this.buttonFMU.UseVisualStyleBackColor = true;
            this.buttonFMU.Click += new System.EventHandler(this.buttonFMU_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(375, 24);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(150, 25);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "选择call.py";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // textBoxRemotePath
            // 
            this.textBoxRemotePath.Location = new System.Drawing.Point(112, 63);
            this.textBoxRemotePath.Name = "textBoxRemotePath";
            this.textBoxRemotePath.Size = new System.Drawing.Size(513, 25);
            this.textBoxRemotePath.TabIndex = 1;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(678, 63);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(125, 25);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "部署";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.Location = new System.Drawing.Point(47, 25);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(150, 25);
            this.buttonGetTask.TabIndex = 0;
            this.buttonGetTask.Text = "生成Task.xml";
            this.buttonGetTask.UseVisualStyleBackColor = true;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标目录：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态：";
            // 
            // textBoxFMUstatus
            // 
            this.textBoxFMUstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFMUstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFMUstatus.Location = new System.Drawing.Point(268, 29);
            this.textBoxFMUstatus.Name = "textBoxFMUstatus";
            this.textBoxFMUstatus.ReadOnly = true;
            this.textBoxFMUstatus.Size = new System.Drawing.Size(100, 18);
            this.textBoxFMUstatus.TabIndex = 6;
            this.textBoxFMUstatus.Text = "未选择";
            // 
            // textBoxCallstatus
            // 
            this.textBoxCallstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCallstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCallstatus.Location = new System.Drawing.Point(618, 29);
            this.textBoxCallstatus.Name = "textBoxCallstatus";
            this.textBoxCallstatus.ReadOnly = true;
            this.textBoxCallstatus.Size = new System.Drawing.Size(100, 18);
            this.textBoxCallstatus.TabIndex = 6;
            this.textBoxCallstatus.Text = "未选择";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(846, 558);
            this.Controls.Add(this.richTextBoxinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FMU测试工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxinfo;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxRemotePath;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFMU;
        private System.Windows.Forms.Button buttonGetTask;
        private System.Windows.Forms.TextBox textBoxCallstatus;
        private System.Windows.Forms.TextBox textBoxFMUstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

