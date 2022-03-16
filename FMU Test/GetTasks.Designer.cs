
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
            this.components = new System.ComponentModel.Container();
            this.buttonaddtask = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.paneltask = new System.Windows.Forms.Panel();
            this.richTextBoxtaskinfo = new System.Windows.Forms.RichTextBox();
            this.labelrelation = new System.Windows.Forms.Label();
            this.comboBoxtrigger = new System.Windows.Forms.ComboBox();
            this.buttonsavetask = new System.Windows.Forms.Button();
            this.comboBoxtasktype = new System.Windows.Forms.ComboBox();
            this.textBoxrelation = new System.Windows.Forms.TextBox();
            this.textBoxperiod = new System.Windows.Forms.TextBox();
            this.textBoxtaskname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxcal = new System.Windows.Forms.ListBox();
            this.listBoxevent = new System.Windows.Forms.ListBox();
            this.buttondelcal = new System.Windows.Forms.Button();
            this.buttonAddcal = new System.Windows.Forms.Button();
            this.buttondelevent = new System.Windows.Forms.Button();
            this.buttonAddevent = new System.Windows.Forms.Button();
            this.panelevent = new System.Windows.Forms.Panel();
            this.buttonvaluevar = new System.Windows.Forms.Button();
            this.buttongetvar = new System.Windows.Forms.Button();
            this.comboBoxjudge = new System.Windows.Forms.ComboBox();
            this.labelparamtype = new System.Windows.Forms.Label();
            this.comboBoxeventtype = new System.Windows.Forms.ComboBox();
            this.textBoxvalue = new System.Windows.Forms.TextBox();
            this.textBoxtag = new System.Windows.Forms.TextBox();
            this.buttonloadxml = new System.Windows.Forms.Button();
            this.textBoxeventname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonsaveevent = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxxml = new System.Windows.Forms.TextBox();
            this.listBoxtask = new System.Windows.Forms.ListBox();
            this.panelcal = new System.Windows.Forms.Panel();
            this.buttongetsftpcal = new System.Windows.Forms.Button();
            this.textBoxuri = new System.Windows.Forms.TextBox();
            this.textBoxcalname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonsavecal = new System.Windows.Forms.Button();
            this.buttondeltask = new System.Windows.Forms.Button();
            this.panelcallist = new System.Windows.Forms.Panel();
            this.paneleventlist = new System.Windows.Forms.Panel();
            this.groupBoxtask = new System.Windows.Forms.GroupBox();
            this.groupBoxevent = new System.Windows.Forms.GroupBox();
            this.groupBoxcal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerinfo = new System.Windows.Forms.Timer(this.components);
            this.paneltask.SuspendLayout();
            this.panelevent.SuspendLayout();
            this.panelcal.SuspendLayout();
            this.panelcallist.SuspendLayout();
            this.paneleventlist.SuspendLayout();
            this.groupBoxtask.SuspendLayout();
            this.groupBoxevent.SuspendLayout();
            this.groupBoxcal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonaddtask
            // 
            this.buttonaddtask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonaddtask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonaddtask.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonaddtask.Location = new System.Drawing.Point(197, 20);
            this.buttonaddtask.Name = "buttonaddtask";
            this.buttonaddtask.Size = new System.Drawing.Size(23, 23);
            this.buttonaddtask.TabIndex = 0;
            this.buttonaddtask.Text = "+";
            this.buttonaddtask.UseVisualStyleBackColor = false;
            this.buttonaddtask.Click += new System.EventHandler(this.buttonaddtask_Click);
            this.buttonaddtask.MouseHover += new System.EventHandler(this.buttonadd_MouseHover);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.SeaShell;
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsave.Location = new System.Drawing.Point(733, 362);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(125, 27);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "生成xml文件";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(874, 362);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 27);
            this.buttoncancel.TabIndex = 2;
            this.buttoncancel.Text = "退出";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // paneltask
            // 
            this.paneltask.Controls.Add(this.richTextBoxtaskinfo);
            this.paneltask.Controls.Add(this.labelrelation);
            this.paneltask.Controls.Add(this.comboBoxtrigger);
            this.paneltask.Controls.Add(this.buttonsavetask);
            this.paneltask.Controls.Add(this.comboBoxtasktype);
            this.paneltask.Controls.Add(this.textBoxrelation);
            this.paneltask.Controls.Add(this.textBoxperiod);
            this.paneltask.Controls.Add(this.textBoxtaskname);
            this.paneltask.Controls.Add(this.label6);
            this.paneltask.Controls.Add(this.label5);
            this.paneltask.Controls.Add(this.label4);
            this.paneltask.Controls.Add(this.label3);
            this.paneltask.Enabled = false;
            this.paneltask.Location = new System.Drawing.Point(229, 11);
            this.paneltask.Name = "paneltask";
            this.paneltask.Size = new System.Drawing.Size(766, 144);
            this.paneltask.TabIndex = 5;
            // 
            // richTextBoxtaskinfo
            // 
            this.richTextBoxtaskinfo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxtaskinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxtaskinfo.Location = new System.Drawing.Point(612, 10);
            this.richTextBoxtaskinfo.Name = "richTextBoxtaskinfo";
            this.richTextBoxtaskinfo.ReadOnly = true;
            this.richTextBoxtaskinfo.Size = new System.Drawing.Size(146, 122);
            this.richTextBoxtaskinfo.TabIndex = 33;
            this.richTextBoxtaskinfo.Text = "";
            // 
            // labelrelation
            // 
            this.labelrelation.AutoSize = true;
            this.labelrelation.Location = new System.Drawing.Point(10, 79);
            this.labelrelation.Name = "labelrelation";
            this.labelrelation.Size = new System.Drawing.Size(89, 12);
            this.labelrelation.TabIndex = 32;
            this.labelrelation.Text = "触发条件逻辑：";
            // 
            // comboBoxtrigger
            // 
            this.comboBoxtrigger.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxtrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtrigger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxtrigger.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBoxtrigger.FormattingEnabled = true;
            this.comboBoxtrigger.Items.AddRange(new object[] {
            "Cycle",
            "Period",
            "Event",
            "Periodevent"});
            this.comboBoxtrigger.Location = new System.Drawing.Point(417, 9);
            this.comboBoxtrigger.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxtrigger.Name = "comboBoxtrigger";
            this.comboBoxtrigger.Size = new System.Drawing.Size(178, 21);
            this.comboBoxtrigger.TabIndex = 29;
            this.comboBoxtrigger.SelectedIndexChanged += new System.EventHandler(this.comboBoxtrigger_SelectedIndexChanged);
            this.comboBoxtrigger.MouseHover += new System.EventHandler(this.comboBoxtrigger_MouseHover);
            // 
            // buttonsavetask
            // 
            this.buttonsavetask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsavetask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsavetask.Location = new System.Drawing.Point(452, 112);
            this.buttonsavetask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsavetask.Name = "buttonsavetask";
            this.buttonsavetask.Size = new System.Drawing.Size(143, 20);
            this.buttonsavetask.TabIndex = 20;
            this.buttonsavetask.Text = "保存任务配置";
            this.buttonsavetask.UseVisualStyleBackColor = false;
            this.buttonsavetask.Click += new System.EventHandler(this.buttonsavetask_Click);
            // 
            // comboBoxtasktype
            // 
            this.comboBoxtasktype.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxtasktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtasktype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxtasktype.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxtasktype.FormattingEnabled = true;
            this.comboBoxtasktype.Items.AddRange(new object[] {
            "once",
            "repeat"});
            this.comboBoxtasktype.Location = new System.Drawing.Point(103, 42);
            this.comboBoxtasktype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxtasktype.Name = "comboBoxtasktype";
            this.comboBoxtasktype.Size = new System.Drawing.Size(178, 21);
            this.comboBoxtasktype.TabIndex = 28;
            this.comboBoxtasktype.MouseHover += new System.EventHandler(this.comboBoxtype_MouseHover);
            // 
            // textBoxrelation
            // 
            this.textBoxrelation.Location = new System.Drawing.Point(103, 75);
            this.textBoxrelation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxrelation.Name = "textBoxrelation";
            this.textBoxrelation.Size = new System.Drawing.Size(492, 21);
            this.textBoxrelation.TabIndex = 16;
            this.textBoxrelation.MouseHover += new System.EventHandler(this.textBoxrelation_MouseHover);
            // 
            // textBoxperiod
            // 
            this.textBoxperiod.Location = new System.Drawing.Point(417, 42);
            this.textBoxperiod.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxperiod.Name = "textBoxperiod";
            this.textBoxperiod.Size = new System.Drawing.Size(178, 21);
            this.textBoxperiod.TabIndex = 16;
            this.textBoxperiod.MouseHover += new System.EventHandler(this.textBoxperiod_MouseHover);
            // 
            // textBoxtaskname
            // 
            this.textBoxtaskname.Location = new System.Drawing.Point(103, 9);
            this.textBoxtaskname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtaskname.Name = "textBoxtaskname";
            this.textBoxtaskname.Size = new System.Drawing.Size(178, 21);
            this.textBoxtaskname.TabIndex = 14;
            this.textBoxtaskname.MouseHover += new System.EventHandler(this.textBoxname_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "调度任务名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "调度类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "调度触发条件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "调度周期：";
            // 
            // listBoxcal
            // 
            this.listBoxcal.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxcal.FormattingEnabled = true;
            this.listBoxcal.Location = new System.Drawing.Point(4, 2);
            this.listBoxcal.Name = "listBoxcal";
            this.listBoxcal.Size = new System.Drawing.Size(135, 134);
            this.listBoxcal.TabIndex = 32;
            this.listBoxcal.SelectedIndexChanged += new System.EventHandler(this.listBoxcal_SelectedIndexChanged);
            // 
            // listBoxevent
            // 
            this.listBoxevent.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxevent.FormattingEnabled = true;
            this.listBoxevent.Location = new System.Drawing.Point(4, 2);
            this.listBoxevent.Name = "listBoxevent";
            this.listBoxevent.Size = new System.Drawing.Size(180, 173);
            this.listBoxevent.TabIndex = 31;
            this.listBoxevent.SelectedIndexChanged += new System.EventHandler(this.listBoxevent_SelectedIndexChanged);
            // 
            // buttondelcal
            // 
            this.buttondelcal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondelcal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondelcal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttondelcal.ForeColor = System.Drawing.Color.Red;
            this.buttondelcal.Location = new System.Drawing.Point(151, 32);
            this.buttondelcal.Margin = new System.Windows.Forms.Padding(2);
            this.buttondelcal.Name = "buttondelcal";
            this.buttondelcal.Size = new System.Drawing.Size(23, 23);
            this.buttondelcal.TabIndex = 19;
            this.buttondelcal.Tag = "";
            this.buttondelcal.Text = "×";
            this.buttondelcal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondelcal.UseVisualStyleBackColor = false;
            this.buttondelcal.Click += new System.EventHandler(this.buttondelcal_Click);
            // 
            // buttonAddcal
            // 
            this.buttonAddcal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAddcal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddcal.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddcal.Location = new System.Drawing.Point(151, 2);
            this.buttonAddcal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddcal.Name = "buttonAddcal";
            this.buttonAddcal.Size = new System.Drawing.Size(23, 23);
            this.buttonAddcal.TabIndex = 19;
            this.buttonAddcal.Text = "+";
            this.buttonAddcal.UseVisualStyleBackColor = false;
            this.buttonAddcal.Click += new System.EventHandler(this.buttonAddcal_Click);
            this.buttonAddcal.MouseHover += new System.EventHandler(this.buttonAddcal_MouseHover);
            // 
            // buttondelevent
            // 
            this.buttondelevent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondelevent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondelevent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttondelevent.ForeColor = System.Drawing.Color.Red;
            this.buttondelevent.Location = new System.Drawing.Point(194, 32);
            this.buttondelevent.Margin = new System.Windows.Forms.Padding(2);
            this.buttondelevent.Name = "buttondelevent";
            this.buttondelevent.Size = new System.Drawing.Size(23, 23);
            this.buttondelevent.TabIndex = 18;
            this.buttondelevent.Text = "×";
            this.buttondelevent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondelevent.UseVisualStyleBackColor = false;
            this.buttondelevent.Click += new System.EventHandler(this.buttondelevent_Click);
            // 
            // buttonAddevent
            // 
            this.buttonAddevent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAddevent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddevent.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddevent.Location = new System.Drawing.Point(194, 2);
            this.buttonAddevent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddevent.Name = "buttonAddevent";
            this.buttonAddevent.Size = new System.Drawing.Size(23, 23);
            this.buttonAddevent.TabIndex = 18;
            this.buttonAddevent.Text = "+";
            this.buttonAddevent.UseVisualStyleBackColor = false;
            this.buttonAddevent.Click += new System.EventHandler(this.buttonAddevent_Click);
            this.buttonAddevent.MouseHover += new System.EventHandler(this.buttonAddevent_MouseHover);
            // 
            // panelevent
            // 
            this.panelevent.Controls.Add(this.buttonvaluevar);
            this.panelevent.Controls.Add(this.buttongetvar);
            this.panelevent.Controls.Add(this.comboBoxjudge);
            this.panelevent.Controls.Add(this.labelparamtype);
            this.panelevent.Controls.Add(this.comboBoxeventtype);
            this.panelevent.Controls.Add(this.textBoxvalue);
            this.panelevent.Controls.Add(this.textBoxtag);
            this.panelevent.Controls.Add(this.buttonloadxml);
            this.panelevent.Controls.Add(this.textBoxeventname);
            this.panelevent.Controls.Add(this.label8);
            this.panelevent.Controls.Add(this.label9);
            this.panelevent.Controls.Add(this.label10);
            this.panelevent.Controls.Add(this.buttonsaveevent);
            this.panelevent.Controls.Add(this.label11);
            this.panelevent.Controls.Add(this.label12);
            this.panelevent.Enabled = false;
            this.panelevent.Location = new System.Drawing.Point(229, 15);
            this.panelevent.Name = "panelevent";
            this.panelevent.Size = new System.Drawing.Size(281, 174);
            this.panelevent.TabIndex = 6;
            // 
            // buttonvaluevar
            // 
            this.buttonvaluevar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonvaluevar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonvaluevar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonvaluevar.Location = new System.Drawing.Point(233, 106);
            this.buttonvaluevar.Name = "buttonvaluevar";
            this.buttonvaluevar.Size = new System.Drawing.Size(34, 21);
            this.buttonvaluevar.TabIndex = 38;
            this.buttonvaluevar.Text = "...";
            this.buttonvaluevar.UseVisualStyleBackColor = false;
            this.buttonvaluevar.Click += new System.EventHandler(this.buttonvaluevar_Click);
            // 
            // buttongetvar
            // 
            this.buttongetvar.BackColor = System.Drawing.SystemColors.Control;
            this.buttongetvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttongetvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetvar.Location = new System.Drawing.Point(233, 58);
            this.buttongetvar.Name = "buttongetvar";
            this.buttongetvar.Size = new System.Drawing.Size(34, 21);
            this.buttongetvar.TabIndex = 37;
            this.buttongetvar.Text = "...";
            this.buttongetvar.UseVisualStyleBackColor = false;
            this.buttongetvar.Click += new System.EventHandler(this.buttongetvar_Click);
            // 
            // comboBoxjudge
            // 
            this.comboBoxjudge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxjudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxjudge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxjudge.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBoxjudge.FormattingEnabled = true;
            this.comboBoxjudge.Items.AddRange(new object[] {
            "=",
            "!=",
            ">",
            "<",
            ">=",
            "<="});
            this.comboBoxjudge.Location = new System.Drawing.Point(91, 82);
            this.comboBoxjudge.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxjudge.Name = "comboBoxjudge";
            this.comboBoxjudge.Size = new System.Drawing.Size(176, 21);
            this.comboBoxjudge.TabIndex = 18;
            this.comboBoxjudge.MouseHover += new System.EventHandler(this.comboBoxjudge_MouseHover);
            // 
            // labelparamtype
            // 
            this.labelparamtype.AutoSize = true;
            this.labelparamtype.Location = new System.Drawing.Point(292, 153);
            this.labelparamtype.Name = "labelparamtype";
            this.labelparamtype.Size = new System.Drawing.Size(0, 12);
            this.labelparamtype.TabIndex = 36;
            // 
            // comboBoxeventtype
            // 
            this.comboBoxeventtype.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxeventtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxeventtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxeventtype.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBoxeventtype.FormattingEnabled = true;
            this.comboBoxeventtype.Items.AddRange(new object[] {
            "Tag",
            "Time"});
            this.comboBoxeventtype.Location = new System.Drawing.Point(91, 34);
            this.comboBoxeventtype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxeventtype.Name = "comboBoxeventtype";
            this.comboBoxeventtype.Size = new System.Drawing.Size(176, 21);
            this.comboBoxeventtype.TabIndex = 17;
            this.comboBoxeventtype.MouseHover += new System.EventHandler(this.comboBoxeventtype_MouseHover);
            // 
            // textBoxvalue
            // 
            this.textBoxvalue.Location = new System.Drawing.Point(91, 106);
            this.textBoxvalue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxvalue.Name = "textBoxvalue";
            this.textBoxvalue.Size = new System.Drawing.Size(144, 21);
            this.textBoxvalue.TabIndex = 15;
            this.textBoxvalue.MouseHover += new System.EventHandler(this.textBoxvalue_MouseHover);
            // 
            // textBoxtag
            // 
            this.textBoxtag.Location = new System.Drawing.Point(91, 58);
            this.textBoxtag.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtag.Name = "textBoxtag";
            this.textBoxtag.Size = new System.Drawing.Size(144, 21);
            this.textBoxtag.TabIndex = 12;
            this.textBoxtag.MouseHover += new System.EventHandler(this.textBoxtag_MouseHover);
            // 
            // buttonloadxml
            // 
            this.buttonloadxml.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonloadxml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonloadxml.Location = new System.Drawing.Point(12, 145);
            this.buttonloadxml.Name = "buttonloadxml";
            this.buttonloadxml.Size = new System.Drawing.Size(120, 20);
            this.buttonloadxml.TabIndex = 2;
            this.buttonloadxml.Text = "选择组态文件";
            this.buttonloadxml.UseVisualStyleBackColor = false;
            this.buttonloadxml.Click += new System.EventHandler(this.buttonloadxml_Click);
            // 
            // textBoxeventname
            // 
            this.textBoxeventname.Location = new System.Drawing.Point(91, 10);
            this.textBoxeventname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxeventname.Name = "textBoxeventname";
            this.textBoxeventname.Size = new System.Drawing.Size(176, 21);
            this.textBoxeventname.TabIndex = 9;
            this.textBoxeventname.MouseHover += new System.EventHandler(this.textBoxeventname_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "数值：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "判断条件：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "变量名：";
            // 
            // buttonsaveevent
            // 
            this.buttonsaveevent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsaveevent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsaveevent.Location = new System.Drawing.Point(147, 145);
            this.buttonsaveevent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsaveevent.Name = "buttonsaveevent";
            this.buttonsaveevent.Size = new System.Drawing.Size(120, 20);
            this.buttonsaveevent.TabIndex = 20;
            this.buttonsaveevent.Text = "保存事件配置";
            this.buttonsaveevent.UseVisualStyleBackColor = false;
            this.buttonsaveevent.Click += new System.EventHandler(this.buttonsaveevent_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "触发类型：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "事件名：";
            // 
            // textBoxxml
            // 
            this.textBoxxml.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxxml.Location = new System.Drawing.Point(12, 414);
            this.textBoxxml.Multiline = true;
            this.textBoxxml.Name = "textBoxxml";
            this.textBoxxml.ReadOnly = true;
            this.textBoxxml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxxml.Size = new System.Drawing.Size(1001, 196);
            this.textBoxxml.TabIndex = 7;
            // 
            // listBoxtask
            // 
            this.listBoxtask.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxtask.FormattingEnabled = true;
            this.listBoxtask.Location = new System.Drawing.Point(7, 20);
            this.listBoxtask.Name = "listBoxtask";
            this.listBoxtask.Size = new System.Drawing.Size(180, 134);
            this.listBoxtask.TabIndex = 8;
            this.listBoxtask.SelectedIndexChanged += new System.EventHandler(this.listBoxtask_SelectedIndexChanged);
            // 
            // panelcal
            // 
            this.panelcal.Controls.Add(this.buttongetsftpcal);
            this.panelcal.Controls.Add(this.textBoxuri);
            this.panelcal.Controls.Add(this.textBoxcalname);
            this.panelcal.Controls.Add(this.label13);
            this.panelcal.Controls.Add(this.label14);
            this.panelcal.Controls.Add(this.buttonsavecal);
            this.panelcal.Enabled = false;
            this.panelcal.Location = new System.Drawing.Point(182, 14);
            this.panelcal.Name = "panelcal";
            this.panelcal.Size = new System.Drawing.Size(278, 107);
            this.panelcal.TabIndex = 9;
            // 
            // buttongetsftpcal
            // 
            this.buttongetsftpcal.BackColor = System.Drawing.SystemColors.Control;
            this.buttongetsftpcal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttongetsftpcal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetsftpcal.Location = new System.Drawing.Point(233, 36);
            this.buttongetsftpcal.Name = "buttongetsftpcal";
            this.buttongetsftpcal.Size = new System.Drawing.Size(34, 21);
            this.buttongetsftpcal.TabIndex = 21;
            this.buttongetsftpcal.Text = "...";
            this.buttongetsftpcal.UseVisualStyleBackColor = false;
            this.buttongetsftpcal.Click += new System.EventHandler(this.buttongetsftpcal_Click);
            // 
            // textBoxuri
            // 
            this.textBoxuri.Location = new System.Drawing.Point(91, 36);
            this.textBoxuri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxuri.Name = "textBoxuri";
            this.textBoxuri.Size = new System.Drawing.Size(142, 21);
            this.textBoxuri.TabIndex = 3;
            this.textBoxuri.MouseHover += new System.EventHandler(this.textBoxuri_MouseHover);
            // 
            // textBoxcalname
            // 
            this.textBoxcalname.Location = new System.Drawing.Point(91, 11);
            this.textBoxcalname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcalname.Name = "textBoxcalname";
            this.textBoxcalname.Size = new System.Drawing.Size(176, 21);
            this.textBoxcalname.TabIndex = 2;
            this.textBoxcalname.MouseHover += new System.EventHandler(this.textBoxcalname_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "文件位置：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "控制算法名：";
            // 
            // buttonsavecal
            // 
            this.buttonsavecal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonsavecal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsavecal.Location = new System.Drawing.Point(147, 74);
            this.buttonsavecal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsavecal.Name = "buttonsavecal";
            this.buttonsavecal.Size = new System.Drawing.Size(120, 20);
            this.buttonsavecal.TabIndex = 20;
            this.buttonsavecal.Text = "保存算法配置";
            this.buttonsavecal.UseVisualStyleBackColor = false;
            this.buttonsavecal.Click += new System.EventHandler(this.buttonsavecal_Click);
            // 
            // buttondeltask
            // 
            this.buttondeltask.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondeltask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondeltask.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttondeltask.ForeColor = System.Drawing.Color.Red;
            this.buttondeltask.Location = new System.Drawing.Point(197, 50);
            this.buttondeltask.Name = "buttondeltask";
            this.buttondeltask.Size = new System.Drawing.Size(23, 23);
            this.buttondeltask.TabIndex = 0;
            this.buttondeltask.Text = "×";
            this.buttondeltask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondeltask.UseVisualStyleBackColor = false;
            this.buttondeltask.Click += new System.EventHandler(this.buttondeltask_Click);
            // 
            // panelcallist
            // 
            this.panelcallist.Controls.Add(this.listBoxcal);
            this.panelcallist.Controls.Add(this.buttonAddcal);
            this.panelcallist.Controls.Add(this.buttondelcal);
            this.panelcallist.Location = new System.Drawing.Point(3, 14);
            this.panelcallist.Name = "panelcallist";
            this.panelcallist.Size = new System.Drawing.Size(176, 137);
            this.panelcallist.TabIndex = 33;
            // 
            // paneleventlist
            // 
            this.paneleventlist.Controls.Add(this.listBoxevent);
            this.paneleventlist.Controls.Add(this.buttondelevent);
            this.paneleventlist.Controls.Add(this.buttonAddevent);
            this.paneleventlist.Location = new System.Drawing.Point(3, 14);
            this.paneleventlist.Name = "paneleventlist";
            this.paneleventlist.Size = new System.Drawing.Size(220, 180);
            this.paneleventlist.TabIndex = 34;
            // 
            // groupBoxtask
            // 
            this.groupBoxtask.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxtask.Controls.Add(this.listBoxtask);
            this.groupBoxtask.Controls.Add(this.paneltask);
            this.groupBoxtask.Controls.Add(this.buttonaddtask);
            this.groupBoxtask.Controls.Add(this.buttondeltask);
            this.groupBoxtask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxtask.Name = "groupBoxtask";
            this.groupBoxtask.Size = new System.Drawing.Size(1001, 162);
            this.groupBoxtask.TabIndex = 38;
            this.groupBoxtask.TabStop = false;
            this.groupBoxtask.Text = "任务信息";
            // 
            // groupBoxevent
            // 
            this.groupBoxevent.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxevent.Controls.Add(this.paneleventlist);
            this.groupBoxevent.Controls.Add(this.panelevent);
            this.groupBoxevent.Location = new System.Drawing.Point(12, 191);
            this.groupBoxevent.Name = "groupBoxevent";
            this.groupBoxevent.Size = new System.Drawing.Size(511, 198);
            this.groupBoxevent.TabIndex = 39;
            this.groupBoxevent.TabStop = false;
            this.groupBoxevent.Text = "事件编辑";
            // 
            // groupBoxcal
            // 
            this.groupBoxcal.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxcal.Controls.Add(this.panelcal);
            this.groupBoxcal.Controls.Add(this.panelcallist);
            this.groupBoxcal.Location = new System.Drawing.Point(539, 191);
            this.groupBoxcal.Name = "groupBoxcal";
            this.groupBoxcal.Size = new System.Drawing.Size(474, 156);
            this.groupBoxcal.TabIndex = 40;
            this.groupBoxcal.TabStop = false;
            this.groupBoxcal.Text = "配置任务调用的算法";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "xml预览窗口：";
            // 
            // timerinfo
            // 
            this.timerinfo.Tick += new System.EventHandler(this.timerinfo_Tick);
            // 
            // GetTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxxml);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.groupBoxtask);
            this.Controls.Add(this.groupBoxevent);
            this.Controls.Add(this.groupBoxcal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置调度策略";
            this.paneltask.ResumeLayout(false);
            this.paneltask.PerformLayout();
            this.panelevent.ResumeLayout(false);
            this.panelevent.PerformLayout();
            this.panelcal.ResumeLayout(false);
            this.panelcal.PerformLayout();
            this.panelcallist.ResumeLayout(false);
            this.paneleventlist.ResumeLayout(false);
            this.groupBoxtask.ResumeLayout(false);
            this.groupBoxevent.ResumeLayout(false);
            this.groupBoxcal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonaddtask;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Panel paneltask;
        private System.Windows.Forms.ComboBox comboBoxtrigger;
        private System.Windows.Forms.ComboBox comboBoxtasktype;
        private System.Windows.Forms.TextBox textBoxperiod;
        private System.Windows.Forms.TextBox textBoxtaskname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddcal;
        private System.Windows.Forms.Button buttonAddevent;
        private System.Windows.Forms.Button buttonsavetask;
        private System.Windows.Forms.Panel panelevent;
        private System.Windows.Forms.TextBox textBoxxml;
        private System.Windows.Forms.ListBox listBoxcal;
        private System.Windows.Forms.ListBox listBoxevent;
        private System.Windows.Forms.Button buttondelcal;
        private System.Windows.Forms.Button buttondelevent;
        private System.Windows.Forms.ListBox listBoxtask;
        private System.Windows.Forms.Panel panelcal;
        private System.Windows.Forms.Button buttondeltask;
        private System.Windows.Forms.ComboBox comboBoxjudge;
        private System.Windows.Forms.ComboBox comboBoxeventtype;
        private System.Windows.Forms.TextBox textBoxvalue;
        private System.Windows.Forms.TextBox textBoxtag;
        private System.Windows.Forms.TextBox textBoxeventname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxuri;
        private System.Windows.Forms.TextBox textBoxcalname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonloadxml;
        private System.Windows.Forms.Panel panelcallist;
        private System.Windows.Forms.Panel paneleventlist;
        private System.Windows.Forms.Button buttonsaveevent;
        private System.Windows.Forms.Button buttonsavecal;
        private System.Windows.Forms.GroupBox groupBoxtask;
        private System.Windows.Forms.GroupBox groupBoxevent;
        private System.Windows.Forms.GroupBox groupBoxcal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelrelation;
        private System.Windows.Forms.Label labelparamtype;
        private System.Windows.Forms.TextBox textBoxrelation;
        private System.Windows.Forms.Button buttonvaluevar;
        private System.Windows.Forms.Button buttongetvar;
        private System.Windows.Forms.RichTextBox richTextBoxtaskinfo;
        private System.Windows.Forms.Timer timerinfo;
        private System.Windows.Forms.Button buttongetsftpcal;
    }
}