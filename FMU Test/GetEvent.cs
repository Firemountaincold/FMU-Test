using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class GetEvent : Form
    {
        public Event eve;
        public GetEvent()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text != "" && textBoxtype.Text != "" && textBoxjudge.Text != "" && textBoxtag.Text != "" &&
                textBoxvalue.Text != "")
            {
                eve = new Event(textBoxname.Text, textBoxtype.Text, textBoxtag.Text, textBoxjudge.Text, textBoxvalue.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入所需的信息！", "警告");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
