
namespace FMU_Test
{
    partial class GetEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxtag = new System.Windows.Forms.TextBox();
            this.textBoxvalue = new System.Windows.Forms.TextBox();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.comboBoxjudge = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "事件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "触发条件类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "变量名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "判断条件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数值：";
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadd.Location = new System.Drawing.Point(30, 153);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 20);
            this.buttonadd.TabIndex = 5;
            this.buttonadd.Text = "添加";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancel.Location = new System.Drawing.Point(172, 153);
            this.buttoncancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(94, 20);
            this.buttoncancel.TabIndex = 6;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(105, 14);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(176, 21);
            this.textBoxname.TabIndex = 0;
            this.textBoxname.MouseHover += new System.EventHandler(this.textBoxname_MouseHover);
            // 
            // textBoxtag
            // 
            this.textBoxtag.Location = new System.Drawing.Point(105, 62);
            this.textBoxtag.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtag.Name = "textBoxtag";
            this.textBoxtag.Size = new System.Drawing.Size(176, 21);
            this.textBoxtag.TabIndex = 2;
            this.textBoxtag.MouseHover += new System.EventHandler(this.textBoxtag_MouseHover);
            // 
            // textBoxvalue
            // 
            this.textBoxvalue.Location = new System.Drawing.Point(105, 110);
            this.textBoxvalue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxvalue.Name = "textBoxvalue";
            this.textBoxvalue.Size = new System.Drawing.Size(176, 21);
            this.textBoxvalue.TabIndex = 4;
            this.textBoxvalue.MouseHover += new System.EventHandler(this.textBoxvalue_MouseHover);
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxtype.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "Tag",
            "Time"});
            this.comboBoxtype.Location = new System.Drawing.Point(105, 38);
            this.comboBoxtype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(176, 21);
            this.comboBoxtype.TabIndex = 7;
            this.comboBoxtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxtype_SelectedIndexChanged);
            this.comboBoxtype.MouseHover += new System.EventHandler(this.comboBoxtype_MouseHover);
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
            this.comboBoxjudge.Location = new System.Drawing.Point(105, 86);
            this.comboBoxjudge.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxjudge.Name = "comboBoxjudge";
            this.comboBoxjudge.Size = new System.Drawing.Size(176, 21);
            this.comboBoxjudge.TabIndex = 8;
            this.comboBoxjudge.MouseHover += new System.EventHandler(this.comboBoxjudge_MouseHover);
            // 
            // GetEvent
            // 
            this.AcceptButton = this.buttonadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(290, 191);
            this.Controls.Add(this.comboBoxjudge);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.textBoxvalue);
            this.Controls.Add(this.textBoxtag);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加触发条件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxtag;
        private System.Windows.Forms.TextBox textBoxvalue;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.ComboBox comboBoxjudge;
    }
}