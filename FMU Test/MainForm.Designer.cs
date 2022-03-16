
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
            this.panelfmu = new System.Windows.Forms.Panel();
            this.buttongetsftpdirfmu = new System.Windows.Forms.Button();
            this.buttonFMU = new System.Windows.Forms.Button();
            this.textBoxRePathfmu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFMUstatus = new System.Windows.Forms.TextBox();
            this.panelpy = new System.Windows.Forms.Panel();
            this.buttongetsftpdirpy = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.textBoxRePathpy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonopenpy = new System.Windows.Forms.Button();
            this.textBoxCallstatus = new System.Windows.Forms.TextBox();
            this.paneltask = new System.Windows.Forms.Panel();
            this.buttongetsftpdirtask = new System.Windows.Forms.Button();
            this.buttontask = new System.Windows.Forms.Button();
            this.textBoxRePathtask = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxtaskstatus = new System.Windows.Forms.TextBox();
            this.buttonopenxml = new System.Windows.Forms.Button();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.checkBoxtask = new System.Windows.Forms.CheckBox();
            this.checkBoxpy = new System.Windows.Forms.CheckBox();
            this.checkBoxfmu = new System.Windows.Forms.CheckBox();
            this.buttonsftpdldir = new System.Windows.Forms.Button();
            this.buttonsftpdl = new System.Windows.Forms.Button();
            this.buttonlogsftp = new System.Windows.Forms.Button();
            this.textBoxsftplog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.richTextBoxinfo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxloading2 = new System.Windows.Forms.PictureBox();
            this.panelwait = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxloading = new System.Windows.Forms.PictureBox();
            this.buttonpost1 = new System.Windows.Forms.Button();
            this.buttonpost2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonrefreshinfo = new System.Windows.Forms.Button();
            this.textBoxserverinfo = new System.Windows.Forms.TextBox();
            this.checkBoxsavelog = new System.Windows.Forms.CheckBox();
            this.buttondisconnfmu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxtask = new System.Windows.Forms.ComboBox();
            this.textBoxlogstatus = new System.Windows.Forms.TextBox();
            this.buttondo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxpost2 = new System.Windows.Forms.TextBox();
            this.textBoxpost1 = new System.Windows.Forms.TextBox();
            this.labelpost2 = new System.Windows.Forms.Label();
            this.labelpost1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.timerNOP = new System.Windows.Forms.Timer(this.components);
            this.buttontteesstt = new System.Windows.Forms.Button();
            this.timerReConnect = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panelfmu.SuspendLayout();
            this.panelpy.SuspendLayout();
            this.paneltask.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading2)).BeginInit();
            this.panelwait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelfmu);
            this.groupBox1.Controls.Add(this.panelpy);
            this.groupBox1.Controls.Add(this.paneltask);
            this.groupBox1.Controls.Add(this.checkBoxtask);
            this.groupBox1.Controls.Add(this.checkBoxpy);
            this.groupBox1.Controls.Add(this.checkBoxfmu);
            this.groupBox1.Controls.Add(this.buttonsftpdldir);
            this.groupBox1.Controls.Add(this.buttonsftpdl);
            this.groupBox1.Controls.Add(this.buttonlogsftp);
            this.groupBox1.Controls.Add(this.textBoxsftplog);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonUpload);
            this.groupBox1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(964, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FMU部署";
            // 
            // panelfmu
            // 
            this.panelfmu.BackColor = System.Drawing.SystemColors.Control;
            this.panelfmu.Controls.Add(this.buttongetsftpdirfmu);
            this.panelfmu.Controls.Add(this.buttonFMU);
            this.panelfmu.Controls.Add(this.textBoxRePathfmu);
            this.panelfmu.Controls.Add(this.label1);
            this.panelfmu.Controls.Add(this.label2);
            this.panelfmu.Controls.Add(this.textBoxFMUstatus);
            this.panelfmu.Enabled = false;
            this.panelfmu.Location = new System.Drawing.Point(60, 13);
            this.panelfmu.Name = "panelfmu";
            this.panelfmu.Size = new System.Drawing.Size(890, 28);
            this.panelfmu.TabIndex = 20;
            // 
            // buttongetsftpdirfmu
            // 
            this.buttongetsftpdirfmu.BackColor = System.Drawing.SystemColors.Control;
            this.buttongetsftpdirfmu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttongetsftpdirfmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetsftpdirfmu.Location = new System.Drawing.Point(850, 3);
            this.buttongetsftpdirfmu.Name = "buttongetsftpdirfmu";
            this.buttongetsftpdirfmu.Size = new System.Drawing.Size(34, 21);
            this.buttongetsftpdirfmu.TabIndex = 17;
            this.buttongetsftpdirfmu.Text = "...";
            this.buttongetsftpdirfmu.UseVisualStyleBackColor = false;
            this.buttongetsftpdirfmu.Click += new System.EventHandler(this.buttongetsftpdirfmu_Click);
            // 
            // buttonFMU
            // 
            this.buttonFMU.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonFMU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFMU.Location = new System.Drawing.Point(7, 3);
            this.buttonFMU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFMU.Name = "buttonFMU";
            this.buttonFMU.Size = new System.Drawing.Size(112, 20);
            this.buttonFMU.TabIndex = 0;
            this.buttonFMU.Text = "选择FMU模型";
            this.buttonFMU.UseVisualStyleBackColor = false;
            this.buttonFMU.Click += new System.EventHandler(this.buttonFMU_Click);
            // 
            // textBoxRePathfmu
            // 
            this.textBoxRePathfmu.Location = new System.Drawing.Point(513, 3);
            this.textBoxRePathfmu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRePathfmu.Name = "textBoxRePathfmu";
            this.textBoxRePathfmu.Size = new System.Drawing.Size(338, 21);
            this.textBoxRePathfmu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "目标目录：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "选择文件：";
            // 
            // textBoxFMUstatus
            // 
            this.textBoxFMUstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFMUstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFMUstatus.Location = new System.Drawing.Point(211, 7);
            this.textBoxFMUstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFMUstatus.Name = "textBoxFMUstatus";
            this.textBoxFMUstatus.ReadOnly = true;
            this.textBoxFMUstatus.Size = new System.Drawing.Size(124, 14);
            this.textBoxFMUstatus.TabIndex = 11;
            this.textBoxFMUstatus.Text = "未选择";
            // 
            // panelpy
            // 
            this.panelpy.BackColor = System.Drawing.SystemColors.Control;
            this.panelpy.Controls.Add(this.buttongetsftpdirpy);
            this.panelpy.Controls.Add(this.buttonCall);
            this.panelpy.Controls.Add(this.textBoxRePathpy);
            this.panelpy.Controls.Add(this.label9);
            this.panelpy.Controls.Add(this.label3);
            this.panelpy.Controls.Add(this.buttonopenpy);
            this.panelpy.Controls.Add(this.textBoxCallstatus);
            this.panelpy.Enabled = false;
            this.panelpy.Location = new System.Drawing.Point(60, 49);
            this.panelpy.Name = "panelpy";
            this.panelpy.Size = new System.Drawing.Size(890, 28);
            this.panelpy.TabIndex = 20;
            // 
            // buttongetsftpdirpy
            // 
            this.buttongetsftpdirpy.BackColor = System.Drawing.SystemColors.Control;
            this.buttongetsftpdirpy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttongetsftpdirpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetsftpdirpy.Location = new System.Drawing.Point(850, 4);
            this.buttongetsftpdirpy.Name = "buttongetsftpdirpy";
            this.buttongetsftpdirpy.Size = new System.Drawing.Size(34, 21);
            this.buttongetsftpdirpy.TabIndex = 17;
            this.buttongetsftpdirpy.Text = "...";
            this.buttongetsftpdirpy.UseVisualStyleBackColor = false;
            this.buttongetsftpdirpy.Click += new System.EventHandler(this.buttongetsftpdirpy_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCall.Location = new System.Drawing.Point(7, 4);
            this.buttonCall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(112, 20);
            this.buttonCall.TabIndex = 1;
            this.buttonCall.Text = "选择控制模型";
            this.buttonCall.UseVisualStyleBackColor = false;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // textBoxRePathpy
            // 
            this.textBoxRePathpy.Location = new System.Drawing.Point(513, 4);
            this.textBoxRePathpy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRePathpy.Name = "textBoxRePathpy";
            this.textBoxRePathpy.Size = new System.Drawing.Size(338, 21);
            this.textBoxRePathpy.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "目标目录：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择文件：";
            // 
            // buttonopenpy
            // 
            this.buttonopenpy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonopenpy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopenpy.Location = new System.Drawing.Point(339, 4);
            this.buttonopenpy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenpy.Name = "buttonopenpy";
            this.buttonopenpy.Size = new System.Drawing.Size(98, 20);
            this.buttonopenpy.TabIndex = 0;
            this.buttonopenpy.Text = "打开控制模型";
            this.buttonopenpy.UseVisualStyleBackColor = false;
            this.buttonopenpy.Click += new System.EventHandler(this.buttonopenpy_Click);
            // 
            // textBoxCallstatus
            // 
            this.textBoxCallstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCallstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCallstatus.Location = new System.Drawing.Point(211, 8);
            this.textBoxCallstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCallstatus.Name = "textBoxCallstatus";
            this.textBoxCallstatus.ReadOnly = true;
            this.textBoxCallstatus.Size = new System.Drawing.Size(124, 14);
            this.textBoxCallstatus.TabIndex = 14;
            this.textBoxCallstatus.Text = "未选择";
            // 
            // paneltask
            // 
            this.paneltask.BackColor = System.Drawing.SystemColors.Control;
            this.paneltask.Controls.Add(this.buttongetsftpdirtask);
            this.paneltask.Controls.Add(this.buttontask);
            this.paneltask.Controls.Add(this.textBoxRePathtask);
            this.paneltask.Controls.Add(this.label10);
            this.paneltask.Controls.Add(this.label11);
            this.paneltask.Controls.Add(this.textBoxtaskstatus);
            this.paneltask.Controls.Add(this.buttonopenxml);
            this.paneltask.Controls.Add(this.buttonGetTask);
            this.paneltask.Enabled = false;
            this.paneltask.Location = new System.Drawing.Point(60, 85);
            this.paneltask.Name = "paneltask";
            this.paneltask.Size = new System.Drawing.Size(890, 28);
            this.paneltask.TabIndex = 19;
            // 
            // buttongetsftpdirtask
            // 
            this.buttongetsftpdirtask.BackColor = System.Drawing.SystemColors.Control;
            this.buttongetsftpdirtask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttongetsftpdirtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetsftpdirtask.Location = new System.Drawing.Point(850, 4);
            this.buttongetsftpdirtask.Name = "buttongetsftpdirtask";
            this.buttongetsftpdirtask.Size = new System.Drawing.Size(34, 21);
            this.buttongetsftpdirtask.TabIndex = 17;
            this.buttongetsftpdirtask.Text = "...";
            this.buttongetsftpdirtask.UseVisualStyleBackColor = false;
            this.buttongetsftpdirtask.Click += new System.EventHandler(this.buttongetsftpdirtask_Click);
            // 
            // buttontask
            // 
            this.buttontask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttontask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontask.Location = new System.Drawing.Point(7, 4);
            this.buttontask.Margin = new System.Windows.Forms.Padding(2);
            this.buttontask.Name = "buttontask";
            this.buttontask.Size = new System.Drawing.Size(112, 20);
            this.buttontask.TabIndex = 0;
            this.buttontask.Text = "选择调度策略";
            this.buttontask.UseVisualStyleBackColor = false;
            this.buttontask.Click += new System.EventHandler(this.buttontask_Click);
            // 
            // textBoxRePathtask
            // 
            this.textBoxRePathtask.Location = new System.Drawing.Point(513, 4);
            this.textBoxRePathtask.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRePathtask.Name = "textBoxRePathtask";
            this.textBoxRePathtask.Size = new System.Drawing.Size(338, 21);
            this.textBoxRePathtask.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "目标目录：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "选择文件：";
            // 
            // textBoxtaskstatus
            // 
            this.textBoxtaskstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxtaskstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtaskstatus.Location = new System.Drawing.Point(211, 8);
            this.textBoxtaskstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtaskstatus.Name = "textBoxtaskstatus";
            this.textBoxtaskstatus.ReadOnly = true;
            this.textBoxtaskstatus.Size = new System.Drawing.Size(76, 14);
            this.textBoxtaskstatus.TabIndex = 11;
            this.textBoxtaskstatus.Text = "未选择";
            // 
            // buttonopenxml
            // 
            this.buttonopenxml.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonopenxml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopenxml.Location = new System.Drawing.Point(291, 4);
            this.buttonopenxml.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenxml.Name = "buttonopenxml";
            this.buttonopenxml.Size = new System.Drawing.Size(72, 20);
            this.buttonopenxml.TabIndex = 0;
            this.buttonopenxml.Text = "打开策略";
            this.buttonopenxml.UseVisualStyleBackColor = false;
            this.buttonopenxml.Click += new System.EventHandler(this.buttonopenxml_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonGetTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetTask.Location = new System.Drawing.Point(365, 4);
            this.buttonGetTask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(72, 20);
            this.buttonGetTask.TabIndex = 0;
            this.buttonGetTask.Text = "配置策略";
            this.buttonGetTask.UseVisualStyleBackColor = false;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // checkBoxtask
            // 
            this.checkBoxtask.AutoSize = true;
            this.checkBoxtask.Location = new System.Drawing.Point(35, 92);
            this.checkBoxtask.Name = "checkBoxtask";
            this.checkBoxtask.Size = new System.Drawing.Size(15, 14);
            this.checkBoxtask.TabIndex = 18;
            this.checkBoxtask.UseVisualStyleBackColor = true;
            this.checkBoxtask.CheckedChanged += new System.EventHandler(this.checkBoxtask_CheckedChanged);
            // 
            // checkBoxpy
            // 
            this.checkBoxpy.AutoSize = true;
            this.checkBoxpy.Location = new System.Drawing.Point(35, 58);
            this.checkBoxpy.Name = "checkBoxpy";
            this.checkBoxpy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxpy.TabIndex = 18;
            this.checkBoxpy.UseVisualStyleBackColor = true;
            this.checkBoxpy.CheckedChanged += new System.EventHandler(this.checkBoxpy_CheckedChanged);
            // 
            // checkBoxfmu
            // 
            this.checkBoxfmu.AutoSize = true;
            this.checkBoxfmu.Location = new System.Drawing.Point(35, 22);
            this.checkBoxfmu.Name = "checkBoxfmu";
            this.checkBoxfmu.Size = new System.Drawing.Size(15, 14);
            this.checkBoxfmu.TabIndex = 18;
            this.checkBoxfmu.UseVisualStyleBackColor = true;
            this.checkBoxfmu.CheckedChanged += new System.EventHandler(this.checkBoxfmu_CheckedChanged);
            // 
            // buttonsftpdldir
            // 
            this.buttonsftpdldir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsftpdldir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsftpdldir.Location = new System.Drawing.Point(850, 131);
            this.buttonsftpdldir.Name = "buttonsftpdldir";
            this.buttonsftpdldir.Size = new System.Drawing.Size(94, 20);
            this.buttonsftpdldir.TabIndex = 16;
            this.buttonsftpdldir.Text = "本地下载目录";
            this.buttonsftpdldir.UseVisualStyleBackColor = false;
            this.buttonsftpdldir.Click += new System.EventHandler(this.buttonsftpdldir_Click);
            // 
            // buttonsftpdl
            // 
            this.buttonsftpdl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsftpdl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsftpdl.Location = new System.Drawing.Point(731, 131);
            this.buttonsftpdl.Name = "buttonsftpdl";
            this.buttonsftpdl.Size = new System.Drawing.Size(94, 20);
            this.buttonsftpdl.TabIndex = 16;
            this.buttonsftpdl.Text = "下载到本地";
            this.buttonsftpdl.UseVisualStyleBackColor = false;
            this.buttonsftpdl.Click += new System.EventHandler(this.buttonsftpdl_Click);
            // 
            // buttonlogsftp
            // 
            this.buttonlogsftp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonlogsftp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogsftp.Location = new System.Drawing.Point(612, 131);
            this.buttonlogsftp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogsftp.Name = "buttonlogsftp";
            this.buttonlogsftp.Size = new System.Drawing.Size(94, 20);
            this.buttonlogsftp.TabIndex = 5;
            this.buttonlogsftp.Text = "配置SFTP";
            this.buttonlogsftp.UseVisualStyleBackColor = false;
            this.buttonlogsftp.Click += new System.EventHandler(this.buttonlogsftp_Click);
            // 
            // textBoxsftplog
            // 
            this.textBoxsftplog.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxsftplog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsftplog.Location = new System.Drawing.Point(99, 135);
            this.textBoxsftplog.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsftplog.Name = "textBoxsftplog";
            this.textBoxsftplog.ReadOnly = true;
            this.textBoxsftplog.Size = new System.Drawing.Size(51, 14);
            this.textBoxsftplog.TabIndex = 6;
            this.textBoxsftplog.Text = "未登录";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "SFTP状态：";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.OldLace;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpload.Location = new System.Drawing.Point(204, 131);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(143, 20);
            this.buttonUpload.TabIndex = 7;
            this.buttonUpload.Text = "部署选中的文件";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // richTextBoxinfo
            // 
            this.richTextBoxinfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBoxinfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxinfo.Location = new System.Drawing.Point(10, 370);
            this.richTextBoxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxinfo.Name = "richTextBoxinfo";
            this.richTextBoxinfo.ReadOnly = true;
            this.richTextBoxinfo.Size = new System.Drawing.Size(964, 255);
            this.richTextBoxinfo.TabIndex = 2;
            this.richTextBoxinfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxloading2);
            this.groupBox3.Controls.Add(this.panelwait);
            this.groupBox3.Controls.Add(this.buttonpost1);
            this.groupBox3.Controls.Add(this.buttonpost2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonrefreshinfo);
            this.groupBox3.Controls.Add(this.textBoxserverinfo);
            this.groupBox3.Controls.Add(this.checkBoxsavelog);
            this.groupBox3.Controls.Add(this.buttondisconnfmu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxtask);
            this.groupBox3.Controls.Add(this.textBoxlogstatus);
            this.groupBox3.Controls.Add(this.buttondo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxpost2);
            this.groupBox3.Controls.Add(this.textBoxpost1);
            this.groupBox3.Controls.Add(this.labelpost2);
            this.groupBox3.Controls.Add(this.labelpost1);
            this.groupBox3.Controls.Add(this.buttonlogin);
            this.groupBox3.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(11, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(964, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FMU调度";
            // 
            // pictureBoxloading2
            // 
            this.pictureBoxloading2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxloading2.Image")));
            this.pictureBoxloading2.Location = new System.Drawing.Point(689, 152);
            this.pictureBoxloading2.Name = "pictureBoxloading2";
            this.pictureBoxloading2.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxloading2.TabIndex = 25;
            this.pictureBoxloading2.TabStop = false;
            this.pictureBoxloading2.Visible = false;
            // 
            // panelwait
            // 
            this.panelwait.BackColor = System.Drawing.SystemColors.Control;
            this.panelwait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelwait.Controls.Add(this.label12);
            this.panelwait.Controls.Add(this.label8);
            this.panelwait.Controls.Add(this.pictureBoxloading);
            this.panelwait.Font = new System.Drawing.Font("新宋体", 11F);
            this.panelwait.Location = new System.Drawing.Point(59, 61);
            this.panelwait.Name = "panelwait";
            this.panelwait.Size = new System.Drawing.Size(295, 91);
            this.panelwait.TabIndex = 24;
            this.panelwait.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "更新时请勿执行命令。";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "更新运行信息中……";
            // 
            // pictureBoxloading
            // 
            this.pictureBoxloading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxloading.Image")));
            this.pictureBoxloading.Location = new System.Drawing.Point(25, 22);
            this.pictureBoxloading.Name = "pictureBoxloading";
            this.pictureBoxloading.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxloading.TabIndex = 23;
            this.pictureBoxloading.TabStop = false;
            // 
            // buttonpost1
            // 
            this.buttonpost1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonpost1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonpost1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpost1.Location = new System.Drawing.Point(909, 70);
            this.buttonpost1.Name = "buttonpost1";
            this.buttonpost1.Size = new System.Drawing.Size(34, 21);
            this.buttonpost1.TabIndex = 22;
            this.buttonpost1.Text = "...";
            this.buttonpost1.UseVisualStyleBackColor = false;
            this.buttonpost1.Click += new System.EventHandler(this.buttonpost1_Click);
            // 
            // buttonpost2
            // 
            this.buttonpost2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonpost2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonpost2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpost2.Location = new System.Drawing.Point(909, 110);
            this.buttonpost2.Name = "buttonpost2";
            this.buttonpost2.Size = new System.Drawing.Size(34, 21);
            this.buttonpost2.TabIndex = 22;
            this.buttonpost2.Text = "...";
            this.buttonpost2.UseVisualStyleBackColor = false;
            this.buttonpost2.Click += new System.EventHandler(this.buttonpost2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "混合控制器运行信息：";
            // 
            // buttonrefreshinfo
            // 
            this.buttonrefreshinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonrefreshinfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonrefreshinfo.Location = new System.Drawing.Point(328, 15);
            this.buttonrefreshinfo.Name = "buttonrefreshinfo";
            this.buttonrefreshinfo.Size = new System.Drawing.Size(94, 20);
            this.buttonrefreshinfo.TabIndex = 19;
            this.buttonrefreshinfo.Text = "刷新信息";
            this.buttonrefreshinfo.UseVisualStyleBackColor = true;
            this.buttonrefreshinfo.Click += new System.EventHandler(this.buttonrefreshinfo_Click);
            // 
            // textBoxserverinfo
            // 
            this.textBoxserverinfo.BackColor = System.Drawing.Color.White;
            this.textBoxserverinfo.Location = new System.Drawing.Point(8, 38);
            this.textBoxserverinfo.Multiline = true;
            this.textBoxserverinfo.Name = "textBoxserverinfo";
            this.textBoxserverinfo.ReadOnly = true;
            this.textBoxserverinfo.Size = new System.Drawing.Size(414, 139);
            this.textBoxserverinfo.TabIndex = 18;
            // 
            // checkBoxsavelog
            // 
            this.checkBoxsavelog.AutoSize = true;
            this.checkBoxsavelog.Checked = true;
            this.checkBoxsavelog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsavelog.Location = new System.Drawing.Point(871, 154);
            this.checkBoxsavelog.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxsavelog.Name = "checkBoxsavelog";
            this.checkBoxsavelog.Size = new System.Drawing.Size(72, 16);
            this.checkBoxsavelog.TabIndex = 8;
            this.checkBoxsavelog.Text = "保存日志";
            this.checkBoxsavelog.UseVisualStyleBackColor = true;
            this.checkBoxsavelog.CheckedChanged += new System.EventHandler(this.checkBoxsavelog_CheckedChanged);
            // 
            // buttondisconnfmu
            // 
            this.buttondisconnfmu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondisconnfmu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondisconnfmu.Location = new System.Drawing.Point(442, 70);
            this.buttondisconnfmu.Margin = new System.Windows.Forms.Padding(2);
            this.buttondisconnfmu.Name = "buttondisconnfmu";
            this.buttondisconnfmu.Size = new System.Drawing.Size(94, 20);
            this.buttondisconnfmu.TabIndex = 2;
            this.buttondisconnfmu.Text = "退出登录";
            this.buttondisconnfmu.UseVisualStyleBackColor = false;
            this.buttondisconnfmu.Click += new System.EventHandler(this.buttondisconnfmu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 34);
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
            this.comboBoxtask.Location = new System.Drawing.Point(651, 30);
            this.comboBoxtask.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxtask.Name = "comboBoxtask";
            this.comboBoxtask.Size = new System.Drawing.Size(292, 20);
            this.comboBoxtask.TabIndex = 4;
            this.comboBoxtask.SelectedIndexChanged += new System.EventHandler(this.comboBoxtask_SelectedIndexChanged);
            // 
            // textBoxlogstatus
            // 
            this.textBoxlogstatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxlogstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlogstatus.Location = new System.Drawing.Point(492, 114);
            this.textBoxlogstatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxlogstatus.Name = "textBoxlogstatus";
            this.textBoxlogstatus.ReadOnly = true;
            this.textBoxlogstatus.Size = new System.Drawing.Size(51, 14);
            this.textBoxlogstatus.TabIndex = 14;
            this.textBoxlogstatus.Text = "未登录";
            // 
            // buttondo
            // 
            this.buttondo.BackColor = System.Drawing.Color.OldLace;
            this.buttondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondo.Location = new System.Drawing.Point(730, 150);
            this.buttondo.Margin = new System.Windows.Forms.Padding(2);
            this.buttondo.Name = "buttondo";
            this.buttondo.Size = new System.Drawing.Size(94, 20);
            this.buttondo.TabIndex = 7;
            this.buttondo.Text = "执行命令";
            this.buttondo.UseVisualStyleBackColor = false;
            this.buttondo.Click += new System.EventHandler(this.buttondo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态：";
            // 
            // textBoxpost2
            // 
            this.textBoxpost2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost2.Location = new System.Drawing.Point(651, 110);
            this.textBoxpost2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpost2.Name = "textBoxpost2";
            this.textBoxpost2.Size = new System.Drawing.Size(292, 21);
            this.textBoxpost2.TabIndex = 6;
            this.textBoxpost2.MouseHover += new System.EventHandler(this.textBoxpost2_MouseHover);
            // 
            // textBoxpost1
            // 
            this.textBoxpost1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxpost1.Location = new System.Drawing.Point(651, 70);
            this.textBoxpost1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpost1.Name = "textBoxpost1";
            this.textBoxpost1.Size = new System.Drawing.Size(292, 21);
            this.textBoxpost1.TabIndex = 5;
            this.textBoxpost1.MouseHover += new System.EventHandler(this.textBoxpost1_MouseHover);
            // 
            // labelpost2
            // 
            this.labelpost2.AutoSize = true;
            this.labelpost2.Location = new System.Drawing.Point(570, 114);
            this.labelpost2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpost2.Name = "labelpost2";
            this.labelpost2.Size = new System.Drawing.Size(71, 12);
            this.labelpost2.TabIndex = 9;
            this.labelpost2.Text = "post字段2：";
            // 
            // labelpost1
            // 
            this.labelpost1.AutoSize = true;
            this.labelpost1.Location = new System.Drawing.Point(570, 74);
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
            this.buttonlogin.Location = new System.Drawing.Point(442, 30);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(94, 20);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "配置RESTful";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_ClickAsync);
            // 
            // timerNOP
            // 
            this.timerNOP.Interval = 50000;
            this.timerNOP.Tick += new System.EventHandler(this.timerNOP_Tick);
            // 
            // buttontteesstt
            // 
            this.buttontteesstt.BackColor = System.Drawing.SystemColors.Window;
            this.buttontteesstt.Enabled = false;
            this.buttontteesstt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontteesstt.Location = new System.Drawing.Point(866, 384);
            this.buttontteesstt.Name = "buttontteesstt";
            this.buttontteesstt.Size = new System.Drawing.Size(94, 20);
            this.buttontteesstt.TabIndex = 16;
            this.buttontteesstt.Text = "测试模式";
            this.buttontteesstt.UseVisualStyleBackColor = false;
            this.buttontteesstt.Visible = false;
            this.buttontteesstt.Click += new System.EventHandler(this.buttontteesstt_Click);
            // 
            // timerReConnect
            // 
            this.timerReConnect.Tick += new System.EventHandler(this.timerReConnect_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(985, 636);
            this.Controls.Add(this.buttontteesstt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBoxinfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMU部署工具 2.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelfmu.ResumeLayout(false);
            this.panelfmu.PerformLayout();
            this.panelpy.ResumeLayout(false);
            this.panelpy.PerformLayout();
            this.paneltask.ResumeLayout(false);
            this.paneltask.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading2)).EndInit();
            this.panelwait.ResumeLayout(false);
            this.panelwait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxinfo;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxRePathfmu;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFMU;
        private System.Windows.Forms.Button buttonGetTask;
        private System.Windows.Forms.TextBox textBoxCallstatus;
        private System.Windows.Forms.TextBox textBoxFMUstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timerNOP;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.ComboBox comboBoxtask;
        private System.Windows.Forms.Button buttondo;
        private System.Windows.Forms.TextBox textBoxpost2;
        private System.Windows.Forms.TextBox textBoxpost1;
        private System.Windows.Forms.Label labelpost2;
        private System.Windows.Forms.Label labelpost1;
        private System.Windows.Forms.TextBox textBoxlogstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonlogsftp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttondisconnfmu;
        private System.Windows.Forms.CheckBox checkBoxsavelog;
        private System.Windows.Forms.TextBox textBoxsftplog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttontteesstt;
        private System.Windows.Forms.Button buttonsftpdldir;
        private System.Windows.Forms.Button buttonsftpdl;
        private System.Windows.Forms.CheckBox checkBoxtask;
        private System.Windows.Forms.CheckBox checkBoxpy;
        private System.Windows.Forms.CheckBox checkBoxfmu;
        private System.Windows.Forms.Button buttongetsftpdirtask;
        private System.Windows.Forms.Button buttongetsftpdirpy;
        private System.Windows.Forms.Button buttongetsftpdirfmu;
        private System.Windows.Forms.TextBox textBoxtaskstatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRePathpy;
        private System.Windows.Forms.TextBox textBoxRePathtask;
        private System.Windows.Forms.Button buttontask;
        private System.Windows.Forms.Button buttonopenpy;
        private System.Windows.Forms.TextBox textBoxserverinfo;
        private System.Windows.Forms.Panel panelfmu;
        private System.Windows.Forms.Panel panelpy;
        private System.Windows.Forms.Panel paneltask;
        private System.Windows.Forms.Button buttonrefreshinfo;
        private System.Windows.Forms.Button buttonopenxml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerReConnect;
        private System.Windows.Forms.Button buttonpost2;
        private System.Windows.Forms.Button buttonpost1;
        private System.Windows.Forms.PictureBox pictureBoxloading;
        private System.Windows.Forms.Panel panelwait;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxloading2;
    }
}

