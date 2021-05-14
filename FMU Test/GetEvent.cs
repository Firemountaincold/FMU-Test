using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class GetEvent : Form
    {
        public Event eve;
        public TipTools tip = new TipTools();
        public GetEvent()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text != "" && comboBoxtype.Text != "" && comboBoxjudge.Text != "" &&
                textBoxvalue.Text != "")
            {
                eve = new Event(textBoxname.Text, comboBoxtype.Text, textBoxtag.Text, comboBoxjudge.Text, textBoxvalue.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入所需的信息！", "警告");
            }
        }
        private void comboBoxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //不同选择，控件不同
            if (comboBoxtype.SelectedItem.ToString() == "Time")
            {
                textBoxtag.Enabled = false;
            }
            else
            {
                textBoxtag.Enabled = true;
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxname, "触发事件的名字.在本任务内应保持唯一性。");
        }

        private void comboBoxtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtype, "触发条件类型，tag/time分别表示触发条件为系统的变量/当前时间。");
        }

        private void textBoxtag_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtag, "变量名。");
        }

        private void comboBoxjudge_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxjudge, "判断条件。");
        }

        private void textBoxvalue_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxvalue, "一个数值。");
        }
    }
}
