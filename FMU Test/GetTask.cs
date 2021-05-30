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
        public TipTools tip = new TipTools();
        public Event[] ee = new Event[1];
        public Cal[] cc = new Cal[1];
        public string eventss = "";
        public int evecount = 0;
        public int calcount = 0;
        public bool isevent = true;
        public bool isrelation = true;
        public string name;
        public GetTask(XmlDocument xd, XmlElement root)
        {
            InitializeComponent();
            xmlDocument = xd;
            this.root = root;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //创建Task
            try
            {
                if (isrelation)
                {
                    if (evecount != 0 || isevent == false)
                    {
                        if (calcount != 0)
                        {
                            Task task = new Task(textBoxname.Text, comboBoxtype.Text, comboBoxtrigger.Text, textBoxperiod.Text, eventss, ee, cc);
                            CreateTask(xmlDocument, root, task);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("请添加计算任务。", "警告");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请添加触发条件。", "警告");
                    }
                }
                else
                {
                    MessageBox.Show("请添加触发条件的逻辑关系。", "警告");
                }
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
            name = t.name;
            root.AppendChild(task);
            //调度方法
            XmlElement rule = xd.CreateElement("Rule");
            rule.SetAttribute("TaskType", t.tasktype);
            rule.SetAttribute("TaskTrigger", t.tasktrigger);
            if (t.taskperiod != "")
            {
                rule.SetAttribute("TaskPeriod", t.taskperiod);
            }
            else
            {
                rule.SetAttribute("TaskPeriod", "5");//没有这项会报错
            }
            if(t.events != "")
            {
                rule.SetAttribute("Events", t.events.Replace(" ", "======"));//空格要变转义符号，但在xml里变&会自动再次转义，所以先用奇怪符号替换，保存后再转义
            }
            else if(isevent)
            {
                rule.SetAttribute("Events", ee[0].eventname);
            }
            task.AppendChild(rule);
            //调度触发条件
            if (isevent)
            {
                for (int i = 0; i < t.e.Length; i++)
                {
                    XmlElement eve = xd.CreateElement("Event");
                    eve.SetAttribute("Name", t.e[i].eventname);
                    eve.SetAttribute("Type", t.e[i].eventtype);
                    if (t.e[i].eventtag != "")
                    {
                        eve.SetAttribute("Tag", t.e[i].eventtag);
                    }
                    eve.SetAttribute("Judge", t.e[i].eventjudge);
                    eve.SetAttribute("Value", t.e[i].eventvalue);
                    rule.AppendChild(eve);
                }
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
        }

        private void buttonAddevent_Click(object sender, EventArgs e)
        {
            //添加触发事件
            GetEvent getEvent = new GetEvent();
            if (getEvent.ShowDialog() == DialogResult.OK)
            {
                Event eve = getEvent.eve;
                if (CheckCopy(ee, eve))
                {
                    MessageBox.Show("触发条件名重复，请重新添加！", "警告");
                }
                else
                {
                    evecount++;
                    Array.Resize(ref ee, evecount);
                    ee[ee.Length - 1] = eve;
                    textBoxevecount.Text = evecount.ToString();
                    if (evecount > 1)
                    {
                        buttonrelation.Enabled = true;
                        isrelation = false;
                    }
                }
            }
        }

        private void buttonAddcal_Click(object sender, EventArgs e)
        {
            //添加计算任务
            GetCal getCal = new GetCal();
            if (getCal.ShowDialog() == DialogResult.OK)
            {
                Cal cal = getCal.cal;
                if (CheckCopy(cc, cal))
                {
                    MessageBox.Show("计算任务名重复，请重新添加！", "警告");
                }
                else
                {
                    calcount++;
                    Array.Resize(ref cc, calcount);
                    cc[cc.Length - 1] = cal;
                    textBoxcalcount.Text = calcount.ToString();
                }
            }
        }

        public bool CheckCopy(Event[] obj, Event objs)
        {
            //检查名称是否重复
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    if (objs.eventname == obj[i].eventname)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckCopy(Cal[] obj, Cal objs)
        {
            //检查名称是否重复，重载
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    if (objs.calname == obj[i].calname)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //取消
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxname, "任务定义信息，每个任务有一个唯一的名字。");
        }

        private void comboBoxtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtype, "调度方法包括once(一次性调度)和repeat(多次调度)。");
        }

        private void comboBoxtrigger_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtrigger, "触发条件包括Cycle(循环触发)、Period(周期触发)、Event(条件触发)、Periodevent(周期+条件触发)。");
        }

        private void comboBoxtrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据选择判断应该使用的控件
            if (comboBoxtrigger.SelectedItem.ToString() == "Cycle")
            {
                textBoxperiod.Text = "";
                textBoxperiod.Enabled = false;
                buttonAddevent.Enabled = false;
                isevent = false;
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Period") 
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = false;
                isevent = false;
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Event")
            {
                textBoxperiod.Text = "";
                textBoxperiod.Enabled = false;
                buttonAddevent.Enabled = true;
                isevent = true;
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Periodevent")
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = true;
                isevent = true;
            }
            else
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = true;
                isevent = true;
            }
        }

        private void textBoxperiod_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxperiod, "调度周期，值为一个数字，单位：秒。");
        }

        private void buttonAddevent_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonAddevent, "点击添加调度触发条件。如果触发条件超过1个，需要编辑它们的逻辑关系。");
        }

        private void buttonAddcal_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonAddcal, "点击添加计算任务。");
        }

        private void buttonrelation_Click(object sender, EventArgs e)
        {
            //添加触发逻辑
            Events events = new Events(ee);
            if (events.ShowDialog() == DialogResult.OK)
            {
                eventss = events.events;
                isrelation = true;
            }
        }

        private void buttonrelation_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonrelation, "点击添加触发条件之间的逻辑关系。");
        }
    }

    public class Task
    {
        //用于构造任务的类
        public string name;
        public string tasktype;
        public string tasktrigger;
        public string taskperiod;
        public string events;
        public Event[] e;
        public Cal[] c;

        public Task(string name, string type, string trigger, string period, string events, Event[] ee, Cal[] cc)
        {
            this.name = name;
            tasktype = type;
            tasktrigger = trigger;
            taskperiod = period;
            this.events = events;
            e = ee;
            c = cc;
        }
    }

    public class Event
    {
        //触发事件类
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
        //计算任务类
        public string calname;
        public string caluri;

        public Cal(string calname, string caluri)
        {
            this.calname = calname;
            this.caluri = caluri;
        }
    }
}
