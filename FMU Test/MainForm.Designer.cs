
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxpyTask = new System.Windows.Forms.CheckBox();
            this.buttondisconnsftp = new System.Windows.Forms.Button();
            this.buttonlogsftp = new System.Windows.Forms.Button();
            this.checkBoxtask = new System.Windows.Forms.CheckBox();
            this.textBoxCallstatus = new System.Windows.Forms.TextBox();
            this.textBoxsftplog = new System.Windows.Forms.TextBox();
            this.textBoxFMUstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.checkBoxgetinfo = new System.Windows.Forms.CheckBox();
            this.checkBoxsavelog = new System.Windows.Forms.CheckBox();
            this.buttondisconnfmu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.timersavelog = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxpyTask);
            this.groupBox1.Controls.Add(this.buttondisconnsftp);
            this.groupBox1.Controls.Add(this.buttonlogsftp);
            this.groupBox1.Controls.Add(this.checkBoxtask);
            this.groupBox1.Controls.Add(this.textBoxCallstatus);
            this.groupBox1.Controls.Add(this.textBoxsftplog);
            this.groupBox1.Controls.Add(this.textBoxFMUstatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUpload);
            this.groupBox1.Controls.Add(this.textBoxRemotePath);
            this.groupBox1.Controls.Add(this.buttonCall);
            this.groupBox1.Controls.Add(this.buttonFMU);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(770, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFTP文件部署";
            // 
            // checkBoxpyTask
            // 
            this.checkBoxpyTask.AutoSize = true;
            this.checkBoxpyTask.Location = new System.Drawing.Point(441, 22);
            this.checkBoxpyTask.Name = "checkBoxpyTask";
            this.checkBoxpyTask.Size = new System.Drawing.Size(162, 16);
            this.checkBoxpyTask.TabIndex = 10;
            this.checkBoxpyTask.Text = "自动调用API设置任务目录";
            this.checkBoxpyTask.UseVisualStyleBackColor = true;
            this.checkBoxpyTask.CheckedChanged += new System.EventHandler(this.checkBoxpyTask_CheckedChanged);
            this.checkBoxpyTask.MouseHover += new System.EventHandler(this.checkBoxpyTask_MouseHover);
            // 
            // buttondisconnsftp
            // 
            this.buttondisconnsftp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondisconnsftp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondisconnsftp.Location = new System.Drawing.Point(550, 77);
            this.buttondisconnsftp.Margin = new System.Windows.Forms.Padding(2);
            this.buttondisconnsftp.Name = "buttondisconnsftp";
            this.buttondisconnsftp.Size = new System.Drawing.Size(94, 20);
            this.buttondisconnsftp.TabIndex = 9;
            this.buttondisconnsftp.Text = "断开连接";
            this.buttondisconnsftp.UseVisualStyleBackColor = false;
            this.buttondisconnsftp.Click += new System.EventHandler(this.buttondisconnsftp_Click);
            // 
            // buttonlogsftp
            // 
            this.buttonlogsftp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonlogsftp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogsftp.Location = new System.Drawing.Point(441, 77);
            this.buttonlogsftp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogsftp.Name = "buttonlogsftp";
            this.buttonlogsftp.Size = new System.Drawing.Size(94, 20);
            this.buttonlogsftp.TabIndex = 8;
            this.buttonlogsftp.Text = "登录SFTP";
            this.buttonlogsftp.UseVisualStyleBackColor = false;
            this.buttonlogsftp.Click += new System.EventHandler(this.buttonlogsftp_Click);
            // 
            // checkBoxtask
            // 
            this.checkBoxtask.AutoSize = true;
            this.checkBoxtask.Location = new System.Drawing.Point(623, 22);
            this.checkBoxtask.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxtask.Name = "checkBoxtask";
            this.checkBoxtask.Size = new System.Drawing.Size(120, 16);
            this.checkBoxtask.TabIndex = 7;
            this.checkBoxtask.Text = "同时部署Task.xml";
            this.checkBoxtask.UseVisualStyleBackColor = true;
            this.checkBoxtask.CheckedChanged += new System.EventHandler(this.checkBoxtask_CheckedChanged);
            // 
            // textBoxCallstatus
            // 
            this.textBoxCallstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCallstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCallstatus.Location = new System.Drawing.Point(224, 50);
            this.textBoxCallstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCallstatus.Name = "textBoxCallstatus";
            this.textBoxCallstatus.ReadOnly = true;
            this.textBoxCallstatus.Size = new System.Drawing.Size(52, 14);
            this.textBoxCallstatus.TabIndex = 6;
            this.textBoxCallstatus.Text = "未选择";
            // 
            // textBoxsftplog
            // 
            this.textBoxsftplog.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxsftplog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsftplog.Location = new System.Drawing.Point(505, 52);
            this.textBoxsftplog.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsftplog.Name = "textBoxsftplog";
            this.textBoxsftplog.ReadOnly = true;
            this.textBoxsftplog.Size = new System.Drawing.Size(51, 14);
            this.textBoxsftplog.TabIndex = 6;
            this.textBoxsftplog.Text = "未登录";
            // 
            // textBoxFMUstatus
            // 
            this.textBoxFMUstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFMUstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFMUstatus.Location = new System.Drawing.Point(224, 23);
            this.textBoxFMUstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFMUstatus.Name = "textBoxFMUstatus";
            this.textBoxFMUstatus.ReadOnly = true;
            this.textBoxFMUstatus.Size = new System.Drawing.Size(51, 14);
            this.textBoxFMUstatus.TabIndex = 6;
            this.textBoxFMUstatus.Text = "未选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "py文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "dll文件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "SFTP状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标目录：";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpload.Location = new System.Drawing.Point(661, 77);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(94, 20);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "部署";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxRemotePath
            // 
            this.textBoxRemotePath.Location = new System.Drawing.Point(84, 77);
            this.textBoxRemotePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemotePath.Name = "textBoxRemotePath";
            this.textBoxRemotePath.Size = new System.Drawing.Size(338, 21);
            this.textBoxRemotePath.TabIndex = 1;
            // 
            // buttonCall
            // 
            this.buttonCall.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCall.Location = new System.Drawing.Point(20, 46);
            this.buttonCall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(112, 20);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "选择py文件";
            this.buttonCall.UseVisualStyleBackColor = false;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonFMU
            // 
            this.buttonFMU.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonFMU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFMU.Location = new System.Drawing.Point(20, 19);
            this.buttonFMU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFMU.Name = "buttonFMU";
            this.buttonFMU.Size = new System.Drawing.Size(112, 20);
            this.buttonFMU.TabIndex = 0;
            this.buttonFMU.Text = "选择dll文件";
            this.buttonFMU.UseVisualStyleBackColor = false;
            this.buttonFMU.Click += new System.EventHandler(this.buttonFMU_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenxml);
            this.groupBox2.Controls.Add(this.buttonGetTask);
            this.groupBox2.Location = new System.Drawing.Point(10, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(154, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置任务";
            // 
            // buttonOpenxml
            // 
            this.buttonOpenxml.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonOpenxml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenxml.Location = new System.Drawing.Point(20, 77);
            this.buttonOpenxml.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenxml.Name = "buttonOpenxml";
            this.buttonOpenxml.Size = new System.Drawing.Size(112, 20);
            this.buttonOpenxml.TabIndex = 1;
            this.buttonOpenxml.Text = "打开Task.xml";
            this.buttonOpenxml.UseVisualStyleBackColor = false;
            this.buttonOpenxml.Click += new System.EventHandler(this.buttonOpenxml_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonGetTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetTask.Location = new System.Drawing.Point(20, 35);
            this.buttonGetTask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(112, 20);
            this.buttonGetTask.TabIndex = 0;
            this.buttonGetTask.Text = "生成Task.xml";
            this.buttonGetTask.UseVisualStyleBackColor = false;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // richTextBoxinfo
            // 
            this.richTextBoxinfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBoxinfo.Location = new System.Drawing.Point(11, 254);
            this.richTextBoxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxinfo.Name = "richTextBoxinfo";
            this.richTextBoxinfo.ReadOnly = true;
            this.richTextBoxinfo.Size = new System.Drawing.Size(770, 205);
            this.richTextBoxinfo.TabIndex = 2;
            this.richTextBoxinfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxgetinfo);
            this.groupBox3.Controls.Add(this.checkBoxsavelog);
            this.groupBox3.Controls.Add(this.buttondisconnfmu);
            this.groupBox3.Controls.Add(this.label4);
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
            this.groupBox3.Location = new System.Drawing.Point(169, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(610, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FSU测试";
            // 
            // checkBoxgetinfo
            // 
            this.checkBoxgetinfo.AutoSize = true;
            this.checkBoxgetinfo.Location = new System.Drawing.Point(246, 22);
            this.checkBoxgetinfo.Name = "checkBoxgetinfo";
            this.checkBoxgetinfo.Size = new System.Drawing.Size(132, 16);
            this.checkBoxgetinfo.TabIndex = 20;
            this.checkBoxgetinfo.Text = "登录后自动获取信息";
            this.checkBoxgetinfo.UseVisualStyleBackColor = true;
            this.checkBoxgetinfo.CheckedChanged += new System.EventHandler(this.checkBoxgetinfo_CheckedChanged);
            // 
            // checkBoxsavelog
            // 
            this.checkBoxsavelog.AutoSize = true;
            this.checkBoxsavelog.Checked = true;
            this.checkBoxsavelog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsavelog.Location = new System.Drawing.Point(528, 94);
            this.checkBoxsavelog.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxsavelog.Name = "checkBoxsavelog";
            this.checkBoxsavelog.Size = new System.Drawing.Size(72, 16);
            this.checkBoxsavelog.TabIndex = 19;
            this.checkBoxsavelog.Text = "保存日志";
            this.checkBoxsavelog.UseVisualStyleBackColor = true;
            this.checkBoxsavelog.CheckedChanged += new System.EventHandler(this.checkBoxsavelog_CheckedChanged);
            // 
            // buttondisconnfmu
            // 
            this.buttondisconnfmu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondisconnfmu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondisconnfmu.Location = new System.Drawing.Point(391, 19);
            this.buttondisconnfmu.Margin = new System.Windows.Forms.Padding(2);
            this.buttondisconnfmu.Name = "buttondisconnfmu";
            this.buttondisconnfmu.Size = new System.Drawing.Size(94, 20);
            this.buttondisconnfmu.TabIndex = 18;
            this.buttondisconnfmu.Text = "退出登录";
            this.buttondisconnfmu.UseVisualStyleBackColor = false;
            this.buttondisconnfmu.Click += new System.EventHandler(this.buttondisconnfmu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "API命令：";
            // 
            // comboBoxtask
            // 
            this.comboBoxtask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxtask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxtask.FormattingEnabled = true;
            this.comboBoxtask.Items.AddRange(new object[] {
            "获取控制器运行状态",
            "获取平台版本信息",
            "获取PyTask的路径",
            "获取Python已安装的库"});
            this.comboBoxtask.Location = new System.Drawing.Point(190, 54);
            this.comboBoxtask.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxtask.Name = "comboBoxtask";
            this.comboBoxtask.Size = new System.Drawing.Size(296, 20);
            this.comboBoxtask.TabIndex = 16;
            this.comboBoxtask.SelectedIndexChanged += new System.EventHandler(this.comboBoxtask_SelectedIndexChanged);
            // 
            // radioButtonpost
            // 
            this.radioButtonpost.AutoSize = true;
            this.radioButtonpost.Location = new System.Drawing.Point(75, 57);
            this.radioButtonpost.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonpost.Name = "radioButtonpost";
            this.radioButtonpost.Size = new System.Drawing.Size(47, 16);
            this.radioButtonpost.TabIndex = 15;
            this.radioButtonpost.Text = "设置";
            this.radioButtonpost.UseVisualStyleBackColor = true;
            this.radioButtonpost.CheckedChanged += new System.EventHandler(this.radioButtonpost_CheckedChanged);
            // 
            // textBoxlogstatus
            // 
            this.textBoxlogstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxlogstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlogstatus.Location = new System.Drawing.Point(190, 23);
            this.textBoxlogstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxlogstatus.Name = "textBoxlogstatus";
            this.textBoxlogstatus.ReadOnly = true;
            this.textBoxlogstatus.Size = new System.Drawing.Size(51, 14);
            this.textBoxlogstatus.TabIndex = 6;
            this.textBoxlogstatus.Text = "未登录";
            // 
            // radioButtonget
            // 
            this.radioButtonget.AutoSize = true;
            this.radioButtonget.Checked = true;
            this.radioButtonget.Location = new System.Drawing.Point(27, 57);
            this.radioButtonget.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonget.Name = "radioButtonget";
            this.radioButtonget.Size = new System.Drawing.Size(47, 16);
            this.radioButtonget.TabIndex = 14;
            this.radioButtonget.TabStop = true;
            this.radioButtonget.Text = "获取";
            this.radioButtonget.UseVisualStyleBackColor = true;
            this.radioButtonget.CheckedChanged += new System.EventHandler(this.radioButtonget_CheckedChanged);
            // 
            // buttondo
            // 
            this.buttondo.BackColor = System.Drawing.Color.OldLace;
            this.buttondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondo.Location = new System.Drawing.Point(501, 54);
            this.buttondo.Margin = new System.Windows.Forms.Padding(2);
            this.buttondo.Name = "buttondo";
            this.buttondo.Size = new System.Drawing.Size(94, 20);
            this.buttondo.TabIndex = 13;
            this.buttondo.Text = "执行命令";
            this.buttondo.UseVisualStyleBackColor = false;
            this.buttondo.Click += new System.EventHandler(this.buttondo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态：";
            // 
            // textBoxpost2
            // 
            this.textBoxpost2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost2.Enabled = false;
            this.textBoxpost2.Location = new System.Drawing.Point(340, 91);
            this.textBoxpost2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpost2.Name = "textBoxpost2";
            this.textBoxpost2.Size = new System.Drawing.Size(174, 21);
            this.textBoxpost2.TabIndex = 11;
            this.textBoxpost2.MouseHover += new System.EventHandler(this.textBoxpost2_MouseHover);
            // 
            // textBoxpost1
            // 
            this.textBoxpost1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost1.Enabled = false;
            this.textBoxpost1.Location = new System.Drawing.Point(98, 91);
            this.textBoxpost1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpost1.Name = "textBoxpost1";
            this.textBoxpost1.Size = new System.Drawing.Size(164, 21);
            this.textBoxpost1.TabIndex = 10;
            this.textBoxpost1.MouseHover += new System.EventHandler(this.textBoxpost1_MouseHover);
            // 
            // labelpost2
            // 
            this.labelpost2.AutoSize = true;
            this.labelpost2.Location = new System.Drawing.Point(266, 94);
            this.labelpost2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpost2.Name = "labelpost2";
            this.labelpost2.Size = new System.Drawing.Size(71, 12);
            this.labelpost2.TabIndex = 9;
            this.labelpost2.Text = "post字段2：";
            // 
            // labelpost1
            // 
            this.labelpost1.AutoSize = true;
            this.labelpost1.Location = new System.Drawing.Point(25, 94);
            this.labelpost1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpost1.Name = "labelpost1";
            this.labelpost1.Size = new System.Drawing.Size(71, 12);
            this.labelpost1.TabIndex = 8;
            this.labelpost1.Text = "post字段1：";
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogin.Location = new System.Drawing.Point(27, 19);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(94, 20);
            this.buttonlogin.TabIndex = 7;
            this.buttonlogin.Text = "登录";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_ClickAsync);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Location = new System.Drawing.Point(501, 19);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(94, 20);
            this.buttonexit.TabIndex = 6;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // timerNOP
            // 
            this.timerNOP.Interval = 1000;
            this.timerNOP.Tick += new System.EventHandler(this.timerNOP_Tick);
            // 
            // timersavelog
            // 
            this.timersavelog.Tick += new System.EventHandler(this.timersavelog_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBoxinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button buttondisconnsftp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttondisconnfmu;
        private System.Windows.Forms.CheckBox checkBoxsavelog;
        private System.Windows.Forms.Timer timersavelog;
        private System.Windows.Forms.CheckBox checkBoxpyTask;
        private System.Windows.Forms.TextBox textBoxsftplog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxgetinfo;
    }
}

