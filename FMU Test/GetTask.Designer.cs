
namespace FMU_Test
{
    partial class GetTask
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAddevent = new System.Windows.Forms.Button();
            this.buttonAddcal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxevecount = new System.Windows.Forms.TextBox();
            this.textBoxcalcount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxperiod = new System.Windows.Forms.TextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.comboBoxtrigger = new System.Windows.Forms.ComboBox();
            this.buttonrelation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(44, 228);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 20);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "生成xml";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAddevent
            // 
            this.buttonAddevent.Location = new System.Drawing.Point(44, 150);
            this.buttonAddevent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddevent.Name = "buttonAddevent";
            this.buttonAddevent.Size = new System.Drawing.Size(112, 20);
            this.buttonAddevent.TabIndex = 4;
            this.buttonAddevent.Text = "添加触发条件";
            this.buttonAddevent.UseVisualStyleBackColor = true;
            this.buttonAddevent.Click += new System.EventHandler(this.buttonAddevent_Click);
            this.buttonAddevent.MouseHover += new System.EventHandler(this.buttonAddevent_MouseHover);
            // 
            // buttonAddcal
            // 
            this.buttonAddcal.Location = new System.Drawing.Point(44, 185);
            this.buttonAddcal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddcal.Name = "buttonAddcal";
            this.buttonAddcal.Size = new System.Drawing.Size(112, 20);
            this.buttonAddcal.TabIndex = 5;
            this.buttonAddcal.Text = "添加计算任务";
            this.buttonAddcal.UseVisualStyleBackColor = true;
            this.buttonAddcal.Click += new System.EventHandler(this.buttonAddcal_Click);
            this.buttonAddcal.MouseHover += new System.EventHandler(this.buttonAddcal_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "触发条件数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "计算任务数量：";
            // 
            // textBoxevecount
            // 
            this.textBoxevecount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxevecount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxevecount.Location = new System.Drawing.Point(267, 154);
            this.textBoxevecount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxevecount.Name = "textBoxevecount";
            this.textBoxevecount.ReadOnly = true;
            this.textBoxevecount.Size = new System.Drawing.Size(75, 14);
            this.textBoxevecount.TabIndex = 8;
            this.textBoxevecount.Text = "0";
            // 
            // textBoxcalcount
            // 
            this.textBoxcalcount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxcalcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcalcount.Location = new System.Drawing.Point(267, 188);
            this.textBoxcalcount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxcalcount.Name = "textBoxcalcount";
            this.textBoxcalcount.ReadOnly = true;
            this.textBoxcalcount.Size = new System.Drawing.Size(75, 14);
            this.textBoxcalcount.TabIndex = 9;
            this.textBoxcalcount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "调度周期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "调度触发条件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "调度类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "调度任务名：";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(115, 16);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(254, 21);
            this.textBoxname.TabIndex = 0;
            this.textBoxname.MouseHover += new System.EventHandler(this.textBoxname_MouseHover);
            // 
            // textBoxperiod
            // 
            this.textBoxperiod.Location = new System.Drawing.Point(115, 102);
            this.textBoxperiod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxperiod.Name = "textBoxperiod";
            this.textBoxperiod.Size = new System.Drawing.Size(254, 21);
            this.textBoxperiod.TabIndex = 3;
            this.textBoxperiod.MouseHover += new System.EventHandler(this.textBoxperiod_MouseHover);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(214, 228);
            this.buttoncancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(94, 20);
            this.buttoncancel.TabIndex = 7;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxtype.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "once",
            "repeat"});
            this.comboBoxtype.Location = new System.Drawing.Point(115, 44);
            this.comboBoxtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(254, 21);
            this.comboBoxtype.TabIndex = 11;
            this.comboBoxtype.MouseHover += new System.EventHandler(this.comboBoxtype_MouseHover);
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
            this.comboBoxtrigger.Location = new System.Drawing.Point(115, 73);
            this.comboBoxtrigger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxtrigger.Name = "comboBoxtrigger";
            this.comboBoxtrigger.Size = new System.Drawing.Size(254, 21);
            this.comboBoxtrigger.TabIndex = 12;
            this.comboBoxtrigger.SelectedIndexChanged += new System.EventHandler(this.comboBoxtrigger_SelectedIndexChanged);
            this.comboBoxtrigger.MouseHover += new System.EventHandler(this.comboBoxtrigger_MouseHover);
            // 
            // buttonrelation
            // 
            this.buttonrelation.Enabled = false;
            this.buttonrelation.Location = new System.Drawing.Point(287, 150);
            this.buttonrelation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonrelation.Name = "buttonrelation";
            this.buttonrelation.Size = new System.Drawing.Size(81, 20);
            this.buttonrelation.TabIndex = 13;
            this.buttonrelation.Text = "逻辑关系";
            this.buttonrelation.UseVisualStyleBackColor = true;
            this.buttonrelation.Click += new System.EventHandler(this.buttonrelation_Click);
            this.buttonrelation.MouseHover += new System.EventHandler(this.buttonrelation_MouseHover);
            // 
            // GetTask
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(386, 267);
            this.Controls.Add(this.buttonrelation);
            this.Controls.Add(this.comboBoxtrigger);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.textBoxperiod);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxcalcount);
            this.Controls.Add(this.textBoxevecount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddcal);
            this.Controls.Add(this.buttonAddevent);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成Task.xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAddevent;
        private System.Windows.Forms.Button buttonAddcal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxevecount;
        private System.Windows.Forms.TextBox textBoxcalcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxperiod;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.ComboBox comboBoxtrigger;
        private System.Windows.Forms.Button buttonrelation;
    }
}