using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FMU_Test
{
    public partial class GetEvent2 : Form
    {
        public Event eve;
        public TipTools tip = new TipTools();
        public Dictionary<string, string> tags = new Dictionary<string, string>();
        public int index = 0;
        public GetEvent2(Dictionary<string, string> tags)
        {
            InitializeComponent();
            this.tags = tags;
            AddTags();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            //添加触发条件
            if (textBoxname.Text != "" && comboBoxtype.Text != "" && comboBoxjudge.Text != "" &&
                textBoxvalue.Text != "")
            {
                eve = new Event(textBoxname.Text, comboBoxtype.Text, comboBoxtag.SelectedItem.ToString(), comboBoxjudge.Text, textBoxvalue.Text);
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
                comboBoxtag.Enabled = false;
            }
            else
            {
                comboBoxtag.Enabled = true;
            }
        }

        public void AddTags()
        {
            //填充下拉列表
            foreach(var tag in tags)
            {
                if (tag.Value == "INT" || tag.Value == "UINT")
                {
                    comboBoxtag.Items.Add(tag.Key);
                }
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
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
            tip.ToolTips(comboBoxtag, "变量名。");
        }

        private void comboBoxjudge_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxjudge, "判断条件。");
        }

        private void textBoxvalue_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxvalue, "一个数值。");
        }

        private void comboBoxtag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //显示所选变量的类型
            foreach (var tag in tags)
            {
                if (tag.Key == comboBoxtag.SelectedItem.ToString())
                {
                    textBoxtagtype.Text = tag.Value;
                }
            }
        }
    }
}
