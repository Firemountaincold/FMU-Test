using System.Windows.Forms;

namespace FMU_Test
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            //欢迎窗口
            InitializeComponent();
            ControlBox = false;
        }

        public void ChangeLabelSFTP(string str)
        {
            //文本编辑
            labelsftp.Text = str;
        }

        public void ChangeLabelREST(string str)
        {
            //文本编辑
            labelrest.Text = str;
        }

        public void ChangeLabel(string str)
        {
            //文本编辑
            label.Text = str;
        }
    }
}
