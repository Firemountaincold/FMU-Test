
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxtask = new System.Windows.Forms.CheckBox();
            this.textBoxCallstatus = new System.Windows.Forms.TextBox();
            this.textBoxFMUstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxRemotePath = new System.Windows.Forms.TextBox();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonFMU = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenxml = new System.Windows.Forms.Button();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.richTextBoxinfo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxtask = new System.Windows.Forms.ComboBox();
            this.radioButtonpost = new System.Windows.Forms.RadioButton();
            this.textBoxlogstatus = new System.Windows.Forms.TextBox();
            this.radioButtonget = new System.Windows.Forms.RadioButton();
            this.buttondo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxpost2 = new System.Windows.Forms.TextBox();
            this.textBoxpost1 = new System.Windows.Forms.TextBox();
            this.labelpost2 = new System.Windows.Forms.Label();
            this.labelpost1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.timerNOP = new System.Windows.Forms.Timer(this.components);
            this.buttonlogsftp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonlogsftp);
            this.groupBox1.Controls.Add(this.checkBoxtask);
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
            this.groupBox1.Size = new System.Drawing.Size(919, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFTP文件部署";
            // 
            // checkBoxtask
            // 
            this.checkBoxtask.AutoSize = true;
            this.checkBoxtask.Location = new System.Drawing.Point(771, 24);
            this.checkBoxtask.Name = "checkBoxtask";
            this.checkBoxtask.Size = new System.Drawing.Size(123, 19);
            this.checkBoxtask.TabIndex = 7;
            this.checkBoxtask.Text = "部署Task.xml";
            this.checkBoxtask.UseVisualStyleBackColor = true;
            // 
            // textBoxCallstatus
            // 
            this.textBoxCallstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCallstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCallstatus.Location = new System.Drawing.Point(644, 29);
            this.textBoxCallstatus.Name = "textBoxCallstatus";
            this.textBoxCallstatus.ReadOnly = true;
            this.textBoxCallstatus.Size = new System.Drawing.Size(69, 18);
            this.textBoxCallstatus.TabIndex = 6;
            this.textBoxCallstatus.Text = "未选择";
            // 
            // textBoxFMUstatus
            // 
            this.textBoxFMUstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFMUstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFMUstatus.Location = new System.Drawing.Point(268, 29);
            this.textBoxFMUstatus.Name = "textBoxFMUstatus";
            this.textBoxFMUstatus.ReadOnly = true;
            this.textBoxFMUstatus.Size = new System.Drawing.Size(68, 18);
            this.textBoxFMUstatus.TabIndex = 6;
            this.textBoxFMUstatus.Text = "未选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态：";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标目录：";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(771, 63);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(125, 25);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "部署";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxRemotePath
            // 
            this.textBoxRemotePath.Location = new System.Drawing.Point(112, 63);
            this.textBoxRemotePath.Name = "textBoxRemotePath";
            this.textBoxRemotePath.Size = new System.Drawing.Size(450, 25);
            this.textBoxRemotePath.TabIndex = 1;
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(394, 24);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(150, 25);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "选择cal1.py";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenxml);
            this.groupBox2.Controls.Add(this.buttonGetTask);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置任务";
            // 
            // buttonOpenxml
            // 
            this.buttonOpenxml.Location = new System.Drawing.Point(27, 88);
            this.buttonOpenxml.Name = "buttonOpenxml";
            this.buttonOpenxml.Size = new System.Drawing.Size(150, 25);
            this.buttonOpenxml.TabIndex = 1;
            this.buttonOpenxml.Text = "打开Task.xml";
            this.buttonOpenxml.UseVisualStyleBackColor = true;
            this.buttonOpenxml.Click += new System.EventHandler(this.buttonOpenxml_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.Location = new System.Drawing.Point(27, 46);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(150, 25);
            this.buttonGetTask.TabIndex = 0;
            this.buttonGetTask.Text = "生成Task.xml";
            this.buttonGetTask.UseVisualStyleBackColor = true;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // richTextBoxinfo
            // 
            this.richTextBoxinfo.Location = new System.Drawing.Point(13, 291);
            this.richTextBoxinfo.Name = "richTextBoxinfo";
            this.richTextBoxinfo.Size = new System.Drawing.Size(919, 255);
            this.richTextBoxinfo.TabIndex = 2;
            this.richTextBoxinfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxtask);
            this.groupBox3.Controls.Add(this.radioButtonpost);
            this.groupBox3.Controls.Add(this.textBoxlogstatus);
            this.groupBox3.Controls.Add(this.radioButtonget);
            this.groupBox3.Controls.Add(this.buttondo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxpost2);
            this.groupBox3.Controls.Add(this.textBoxpost1);
            this.groupBox3.Controls.Add(this.labelpost2);
            this.groupBox3.Controls.Add(this.labelpost1);
            this.groupBox3.Controls.Add(this.buttonlogin);
            this.groupBox3.Controls.Add(this.buttonexit);
            this.groupBox3.Location = new System.Drawing.Point(226, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试";
            // 
            // comboBoxtask
            // 
            this.comboBoxtask.FormattingEnabled = true;
            this.comboBoxtask.Items.AddRange(new object[] {
            "获取控制器运行状态",
            "获取控制器的诊断状态",
            "获取PyTask的路径",
            "获取Python已安装的库"});
            this.comboBoxtask.Location = new System.Drawing.Point(169, 68);
            this.comboBoxtask.Name = "comboBoxtask";
            this.comboBoxtask.Size = new System.Drawing.Size(356, 23);
            this.comboBoxtask.TabIndex = 16;
            this.comboBoxtask.SelectedIndexChanged += new System.EventHandler(this.comboBoxtask_SelectedIndexChanged);
            // 
            // radioButtonpost
            // 
            this.radioButtonpost.AutoSize = true;
            this.radioButtonpost.Location = new System.Drawing.Point(100, 71);
            this.radioButtonpost.Name = "radioButtonpost";
            this.radioButtonpost.Size = new System.Drawing.Size(58, 19);
            this.radioButtonpost.TabIndex = 15;
            this.radioButtonpost.Text = "设置";
            this.radioButtonpost.UseVisualStyleBackColor = true;
            this.radioButtonpost.CheckedChanged += new System.EventHandler(this.radioButtonpost_CheckedChanged);
            // 
            // textBoxlogstatus
            // 
            this.textBoxlogstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxlogstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlogstatus.Location = new System.Drawing.Point(253, 29);
            this.textBoxlogstatus.Name = "textBoxlogstatus";
            this.textBoxlogstatus.ReadOnly = true;
            this.textBoxlogstatus.Size = new System.Drawing.Size(68, 18);
            this.textBoxlogstatus.TabIndex = 6;
            this.textBoxlogstatus.Text = "未登录";
            // 
            // radioButtonget
            // 
            this.radioButtonget.AutoSize = true;
            this.radioButtonget.Checked = true;
            this.radioButtonget.Location = new System.Drawing.Point(36, 71);
            this.radioButtonget.Name = "radioButtonget";
            this.radioButtonget.Size = new System.Drawing.Size(58, 19);
            this.radioButtonget.TabIndex = 14;
            this.radioButtonget.TabStop = true;
            this.radioButtonget.Text = "获取";
            this.radioButtonget.UseVisualStyleBackColor = true;
            this.radioButtonget.CheckedChanged += new System.EventHandler(this.radioButtonget_CheckedChanged);
            // 
            // buttondo
            // 
            this.buttondo.Location = new System.Drawing.Point(558, 68);
            this.buttondo.Name = "buttondo";
            this.buttondo.Size = new System.Drawing.Size(125, 25);
            this.buttondo.TabIndex = 13;
            this.buttondo.Text = "执行";
            this.buttondo.UseVisualStyleBackColor = true;
            this.buttondo.Click += new System.EventHandler(this.buttondo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态：";
            // 
            // textBoxpost2
            // 
            this.textBoxpost2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost2.Enabled = false;
            this.textBoxpost2.Location = new System.Drawing.Point(453, 114);
            this.textBoxpost2.Name = "textBoxpost2";
            this.textBoxpost2.Size = new System.Drawing.Size(230, 25);
            this.textBoxpost2.TabIndex = 11;
            // 
            // textBoxpost1
            // 
            this.textBoxpost1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost1.Enabled = false;
            this.textBoxpost1.Location = new System.Drawing.Point(131, 114);
            this.textBoxpost1.Name = "textBoxpost1";
            this.textBoxpost1.Size = new System.Drawing.Size(218, 25);
            this.textBoxpost1.TabIndex = 10;
            // 
            // labelpost2
            // 
            this.labelpost2.AutoSize = true;
            this.labelpost2.Location = new System.Drawing.Point(355, 117);
            this.labelpost2.Name = "labelpost2";
            this.labelpost2.Size = new System.Drawing.Size(92, 15);
            this.labelpost2.TabIndex = 9;
            this.labelpost2.Text = "post字段2：";
            // 
            // labelpost1
            // 
            this.labelpost1.AutoSize = true;
            this.labelpost1.Location = new System.Drawing.Point(33, 117);
            this.labelpost1.Name = "labelpost1";
            this.labelpost1.Size = new System.Drawing.Size(92, 15);
            this.labelpost1.TabIndex = 8;
            this.labelpost1.Text = "post字段1：";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(36, 24);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(125, 25);
            this.buttonlogin.TabIndex = 7;
            this.buttonlogin.Text = "登录";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_ClickAsync);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(558, 24);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(125, 25);
            this.buttonexit.TabIndex = 6;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // timerNOP
            // 
            this.timerNOP.Tick += new System.EventHandler(this.timerNOP_Tick);
            // 
            // buttonlogsftp
            // 
            this.buttonlogsftp.Location = new System.Drawing.Point(613, 63);
            this.buttonlogsftp.Name = "buttonlogsftp";
            this.buttonlogsftp.Size = new System.Drawing.Size(125, 25);
            this.buttonlogsftp.TabIndex = 8;
            this.buttonlogsftp.Text = "登录SFTP";
            this.buttonlogsftp.UseVisualStyleBackColor = true;
            this.buttonlogsftp.Click += new System.EventHandler(this.buttonlogsftp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(944, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBoxinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMU测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button buttonOpenxml;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxtask;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Timer timerNOP;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.ComboBox comboBoxtask;
        private System.Windows.Forms.RadioButton radioButtonpost;
        private System.Windows.Forms.RadioButton radioButtonget;
        private System.Windows.Forms.Button buttondo;
        private System.Windows.Forms.TextBox textBoxpost2;
        private System.Windows.Forms.TextBox textBoxpost1;
        private System.Windows.Forms.Label labelpost2;
        private System.Windows.Forms.Label labelpost1;
        private System.Windows.Forms.TextBox textBoxlogstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonlogsftp;
    }
}

