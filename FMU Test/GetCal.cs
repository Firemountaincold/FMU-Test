using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class GetCal : Form
    {
        public Cal cal;
        public GetCal()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
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
            DialogResult = DialogResult.Cancel;
        }
    }
}
