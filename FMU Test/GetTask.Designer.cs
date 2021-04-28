
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
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.textBoxtrigger = new System.Windows.Forms.TextBox();
            this.textBoxperiod = new System.Windows.Forms.TextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(59, 285);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 25);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "生成xml";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAddevent
            // 
            this.buttonAddevent.Location = new System.Drawing.Point(59, 188);
            this.buttonAddevent.Name = "buttonAddevent";
            this.buttonAddevent.Size = new System.Drawing.Size(150, 25);
            this.buttonAddevent.TabIndex = 4;
            this.buttonAddevent.Text = "添加触发条件";
            this.buttonAddevent.UseVisualStyleBackColor = true;
            this.buttonAddevent.Click += new System.EventHandler(this.buttonAddevent_Click);
            // 
            // buttonAddcal
            // 
            this.buttonAddcal.Location = new System.Drawing.Point(59, 231);
            this.buttonAddcal.Name = "buttonAddcal";
            this.buttonAddcal.Size = new System.Drawing.Size(150, 25);
            this.buttonAddcal.TabIndex = 5;
            this.buttonAddcal.Text = "添加计算任务";
            this.buttonAddcal.UseVisualStyleBackColor = true;
            this.buttonAddcal.Click += new System.EventHandler(this.buttonAddcal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "触发条件数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "计算任务数量：";
            // 
            // textBoxevecount
            // 
            this.textBoxevecount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxevecount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxevecount.Location = new System.Drawing.Point(356, 192);
            this.textBoxevecount.Name = "textBoxevecount";
            this.textBoxevecount.ReadOnly = true;
            this.textBoxevecount.Size = new System.Drawing.Size(100, 18);
            this.textBoxevecount.TabIndex = 8;
            this.textBoxevecount.Text = "0";
            // 
            // textBoxcalcount
            // 
            this.textBoxcalcount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxcalcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcalcount.Location = new System.Drawing.Point(356, 235);
            this.textBoxcalcount.Name = "textBoxcalcount";
            this.textBoxcalcount.ReadOnly = true;
            this.textBoxcalcount.Size = new System.Drawing.Size(100, 18);
            this.textBoxcalcount.TabIndex = 9;
            this.textBoxcalcount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "调度周期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "调度触发条件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "调度类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "任务名：";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(153, 20);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(338, 25);
            this.textBoxname.TabIndex = 0;
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(153, 56);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(338, 25);
            this.textBoxtype.TabIndex = 1;
            // 
            // textBoxtrigger
            // 
            this.textBoxtrigger.Location = new System.Drawing.Point(153, 92);
            this.textBoxtrigger.Name = "textBoxtrigger";
            this.textBoxtrigger.Size = new System.Drawing.Size(338, 25);
            this.textBoxtrigger.TabIndex = 2;
            // 
            // textBoxperiod
            // 
            this.textBoxperiod.Location = new System.Drawing.Point(153, 128);
            this.textBoxperiod.Name = "textBoxperiod";
            this.textBoxperiod.Size = new System.Drawing.Size(338, 25);
            this.textBoxperiod.TabIndex = 3;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(285, 285);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 7;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // GetTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(514, 334);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.textBoxperiod);
            this.Controls.Add(this.textBoxtrigger);
            this.Controls.Add(this.textBoxtype);
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
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.TextBox textBoxtrigger;
        private System.Windows.Forms.TextBox textBoxperiod;
        private System.Windows.Forms.Button buttoncancel;
    }
}