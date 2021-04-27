using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FMU_Test
{
    public partial class GetTask : Form
    {
        public XmlDocument xmlDocument = new XmlDocument();
        public XmlElement root;
        public Event[] ee = new Event[1];
        public Cal[] cc = new Cal[1];
        public int evecount = 0;
        public int calcount = 0;
        public GetTask()
        {
            InitializeComponent();
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", ""));
            root = xmlDocument.CreateElement("Tasks");
            root.SetAttribute("xmlns:tasks", "http://www.hollysys.com/IAS/control");
            xmlDocument.AppendChild(root);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(textBoxname.Text, textBoxtype.Text, textBoxtrigger.Text, textBoxperiod.Text, ee, cc);
                CreateTask(xmlDocument, root, task);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        public void CreateTask(XmlDocument xd, XmlElement root, Task t)
        {
            //创建结点
            XmlElement task = xd.CreateElement("Task");
            task.SetAttribute("Name", t.name);
            root.AppendChild(task);
            //调度方法
            XmlElement rule = xd.CreateElement("Rule");
            rule.SetAttribute("TaskType", t.tasktype);
            rule.SetAttribute("TaskTrigger", t.tasktrigger);
            rule.SetAttribute("TaskPeriod", t.taskperiod);
            task.AppendChild(rule);
            //调度触发条件
            for (int i = 0; i < t.e.Length; i++)
            {
                XmlElement eve = xd.CreateElement("Event");
                eve.SetAttribute("Name", t.e[i].eventname);
                eve.SetAttribute("Type", t.e[i].eventtype);
                eve.SetAttribute("Tag", t.e[i].eventtag);
                eve.SetAttribute("Judge", t.e[i].eventjudge);
                eve.SetAttribute("Value", t.e[i].eventvalue);
                rule.AppendChild(eve);
            }
            XmlElement cals = xd.CreateElement("Cals");
            task.AppendChild(cals);
            //计算任务
            for (int i = 0; i < t.c.Length; i++)
            {
                XmlElement calcu = xd.CreateElement("Cal");
                calcu.SetAttribute("Name", t.c[i].calname);
                calcu.SetAttribute("URI", t.c[i].caluri);
                cals.AppendChild(calcu);
            }
            if (!Directory.Exists(Application.StartupPath + "\\XML文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\XML文件");
            }
            xmlDocument.Save(Application.StartupPath + "\\XML文件\\Task.xml");
        }

        private void buttonAddevent_Click(object sender, EventArgs e)
        {
            GetEvent getEvent = new GetEvent();
            if (getEvent.ShowDialog() == DialogResult.OK)
            {
                Event eve = getEvent.eve;
                evecount++;
                Array.Resize(ref ee, evecount);
                ee[ee.Length - 1] = eve;
                textBoxevecount.Text = evecount.ToString();
            }
        }

        private void buttonAddcal_Click(object sender, EventArgs e)
        {
            GetCal getCal = new GetCal();
            if (getCal.ShowDialog() == DialogResult.OK)
            {
                Cal cal = getCal.cal;
                calcount++;
                Array.Resize(ref cc, calcount);
                cc[cc.Length - 1] = cal;
                textBoxcalcount.Text = calcount.ToString();
            }
        }
    }

    public class Task
    {
        public string name;
        public string tasktype;
        public string tasktrigger;
        public string taskperiod;
        public Event[] e;
        public Cal[] c;

        public Task(string name, string type, string trigger, string period, Event[] ee, Cal[] cc)
        {
            this.name = name;
            tasktype = type;
            tasktrigger = trigger;
            taskperiod = period;
            e = ee;
            c = cc;
        }
    }

    public class Event
    {
        public string eventname;
        public string eventtype;
        public string eventtag;
        public string eventjudge;
        public string eventvalue;

        public Event(string eventname, string eventtype, string eventtag, string eventjudge, string eventvalue)
        {
            this.eventname = eventname;
            this.eventtype = eventtype;
            this.eventtag = eventtag;
            this.eventjudge = eventjudge;
            this.eventvalue = eventvalue;
        }
    }

    public class Cal
    {
        public string calname;
        public string caluri;

        public Cal(string calname, string caluri)
        {
            this.calname = calname;
            this.caluri = caluri;
        }
    }
}
