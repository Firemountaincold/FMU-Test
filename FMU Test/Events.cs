using System;
using System.Windows.Forms;

namespace FMU_Test
{
    public partial class Events : Form
    {
        private Event[] ee;
        private string eventname = "";
        public string events;
        public Events(Event[] ee)
        {
            InitializeComponent();
            this.ee = ee;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            events = textBoxevents.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Events_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ee.Length; i++)
            {
                eventname += ee[i].eventname;
                if (i < ee.Length - 1)
                {
                    eventname += "、";
                }
                else
                {
                    eventname += "。";
                }
            }
            textBoxeventname.Text += eventname;
        }
    }
}
