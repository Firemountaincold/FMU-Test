
namespace FMU_Test
{
    partial class Events
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
            this.textBoxevents = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxeventname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxevents
            // 
            this.textBoxevents.Location = new System.Drawing.Point(12, 30);
            this.textBoxevents.Name = "textBoxevents";
            this.textBoxevents.Size = new System.Drawing.Size(381, 25);
            this.textBoxevents.TabIndex = 0;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(56, 250);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(125, 25);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "保存关系";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(224, 250);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(125, 25);
            this.buttoncancel.TabIndex = 2;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(381, 39);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "多个触发条件的逻辑组合关系，它的值是一个由触发条件名字和 AND 、OR 、括号、空格组成的字串表达式。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "示例：(MyEvent1 AND MyEvent2) OR MyEvent3 ";
            // 
            // textBoxeventname
            // 
            this.textBoxeventname.Location = new System.Drawing.Point(13, 164);
            this.textBoxeventname.Multiline = true;
            this.textBoxeventname.Name = "textBoxeventname";
            this.textBoxeventname.ReadOnly = true;
            this.textBoxeventname.Size = new System.Drawing.Size(380, 68);
            this.textBoxeventname.TabIndex = 5;
            this.textBoxeventname.Text = "已保存的触发条件名字：";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 291);
            this.Controls.Add(this.textBoxeventname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.textBoxevents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxevents;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxeventname;
    }
}