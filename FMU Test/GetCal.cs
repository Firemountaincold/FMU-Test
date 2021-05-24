using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class GetCal : Form
    {
        public Cal cal;
        public TipTools tip = new TipTools();
        public GetCal()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            //添加计算任务
            if (textBoxname.Text != "" && textBoxuri.Text != "")
            {
                cal = new Cal(textBoxname.Text, textBoxuri.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入所需的信息！", "警告");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxname, "计算任务的名字，要求名字保持唯一性。");
        }

        private void textBoxuri_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxuri, "计算任务的位置，它是相对于资源根目录的一个URL资源位置。");
        }
    }
}
