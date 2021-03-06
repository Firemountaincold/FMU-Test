using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FMU_Test
{
    public partial class GetTasks : Form
    {
        public XmlDocument xmlDocument = new XmlDocument();
        public XmlElement root;
        public XmlTransfer xt;
        public SFTPHelper sftp;
        private ArrayList param = new ArrayList();
        public TipTools tip = new TipTools();
        public int num = 0;
        public string[] tasknames = new string[0];
        public MyTask[] tasks = new MyTask[0];
        public string[] eventnames = new string[0];
        public Event[] events = new Event[0];
        public string[] calnames = new string[0];
        public Cal[] cals = new Cal[0];
        public bool loaded = false;
        public string eventss = "";
        public bool isevent = true;
        public bool isrelation = true;
        public string taskname;
        public int taskindex = 0;
        public int eventindex = 0;
        public int calindex = 0;
        public int taskselect = 0;
        public int eventselect = 0;
        public int calselect = 0;
        public bool taskchange = false;
        public bool eventchange = false;
        public bool calchange = false;
        public string xmlpath = "";
        public bool xmlflag = false;
        public bool serverxml = false;
        public bool isxmlsaveed = false;
        public string taskpath = "";


        public GetTasks(string path, SFTPHelper sftp, string taskpath)
        {
            InitializeComponent();
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", ""));
            root = xmlDocument.CreateElement("Tasks");
            root.SetAttribute("xmlns:tasks", "http://www.hollysys.com/IAS/control");
            xmlDocument.AppendChild(root);
            if (path != "" && path.EndsWith(".xml"))
            {
                xmlpath = path;
                xmlflag = true;
            }
            if (xmlflag)
            {
                ReadTaskXml(xmlpath);
                ReadEvents();
            }
            this.sftp = sftp;
            this.taskpath = taskpath;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            //??????xml??????
            if (!Directory.Exists(Application.StartupPath + "\\XML??????"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\XML??????");
            }
            if (xmlpath == "")
            {
                xmlDocument.Save(Application.StartupPath + "\\XML??????\\task.xml");
                string xmltxt = File.ReadAllText(Application.StartupPath + "\\XML??????\\task.xml");
                File.WriteAllText(Application.StartupPath + "\\XML??????\\task.xml", xmltxt.Replace("======", "&#x0020;"));
            }
            else
            {
                xmlDocument.Save(xmlpath);
                string xmltxt = File.ReadAllText(xmlpath);
                File.WriteAllText(xmlpath, xmltxt.Replace("======", "&#x0020;"));
            }
            isxmlsaveed = true;
            MessageBox.Show("XML?????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //??????
            if (isxmlsaveed)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonaddtask_Click(object sender, EventArgs e)
        {
            ClearTask();
            taskindex++;
            string na = "task" + taskindex.ToString();
            listBoxtask.Items.Add(na);
            Array.Resize(ref tasknames, taskindex);
            Array.Resize(ref tasks, taskindex);
            tasknames[taskindex - 1] = na;
            listBoxtask.SelectedItem = listBoxtask.Items[taskindex - 1];
            textBoxtaskname.Text = tasknames[taskselect];
            cals = new Cal[0];
            calindex = 0;
            eventss = "";
            taskchange = false;
        }

        public void ReadTaskXml(string path)
        {
            //???xml?????????????????????
            xmlDocument.Load(path);
            root = xmlDocument.DocumentElement;
            Array.Resize(ref tasks, root.ChildNodes.Count);
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                tasks[i] = new MyTask();
                XmlElement task = (XmlElement)root.ChildNodes.Item(i);
                tasks[i].name = task.GetAttribute("Name").ToString();
                XmlElement rule = (XmlElement)task.ChildNodes.Item(0);
                tasks[i].tasktype = rule.GetAttribute("TaskType").ToString();
                tasks[i].tasktrigger = rule.GetAttribute("TaskTrigger").ToString();
                if (rule.GetAttribute("TaskPeriod").ToString() != "")
                {
                    tasks[i].taskperiod = rule.GetAttribute("TaskPeriod".ToString());
                }
                if (rule.GetAttribute("Events").ToString() != "")
                {
                    tasks[i].events = rule.GetAttribute("Events").ToString();//??????
                    isrelation = true;
                }
                Event[] ee = new Event[rule.ChildNodes.Count];
                if (rule.ChildNodes.Count > 0)
                {
                    isevent = true;
                }
                else
                {
                    isevent = false;
                }
                for (int j = 0; j < rule.ChildNodes.Count; j++)
                {
                    ee[j] = new Event();
                    XmlElement eve = (XmlElement)rule.ChildNodes.Item(j);
                    ee[j].eventname = eve.GetAttribute("Name").ToString();
                    ee[j].eventtype = eve.GetAttribute("Type").ToString();
                    if (eve.GetAttribute("Tag").ToString() != "" && eve.GetAttribute("Tag") != null)
                    {
                        ee[j].eventtag = eve.GetAttribute("Tag".ToString());
                    }
                    ee[j].eventjudge = eve.GetAttribute("Judge").ToString();
                    ee[j].eventvalue = eve.GetAttribute("Value").ToString();
                }
                tasks[i].e = ee;
                XmlElement cals = (XmlElement)task.ChildNodes.Item(1);
                Cal[] cc = new Cal[cals.ChildNodes.Count];
                for (int j = 0; j < cals.ChildNodes.Count; j++)
                {
                    cc[j] = new Cal();
                    XmlElement cal = (XmlElement)cals.ChildNodes.Item(j);
                    cc[j].calname = cal.GetAttribute("Name").ToString();
                    cc[j].caluri = cal.GetAttribute("URI").ToString();
                }
                tasks[i].c = cc;
            }
            taskindex = tasks.Length;
            Array.Resize(ref tasknames, taskindex);
            for (int i = 0; i < tasks.Length; i++)
            {
                listBoxtask.Items.Add(tasks[i].name);
                tasknames[i] = tasks[i].name;
            }
            Showxml();
        }

        public bool CheckCopy(string[] obj, string objs)
        {
            //????????????????????????
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    if (objs == obj[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonsavetask_Click(object sender, EventArgs e)
        {
            //??????Task
            try
            {
                //??????????????????
                if (listBoxtask.Items.Count <= 0)
                {
                    MessageBox.Show("?????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxtaskname.Text != "" && comboBoxtasktype.Text != "" && comboBoxtrigger.Text != "" && (textBoxperiod.Text != "" || !textBoxperiod.Enabled) && (textBoxrelation.Text != "" || !isevent)) 
                {
                    string result = CheckRelation(events, textBoxrelation.Text);
                    if (result == "????????????????????????")
                    {
                        eventss = textBoxrelation.Text;
                        isrelation = true;
                        MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (isrelation)
                        {
                            if (events.Length != 0 || isevent == false)
                            {
                                if (cals.Length > 0 && cals[0] != null)
                                {
                                    Event[] te = GetTaskEvent(events, eventss);
                                    MyTask task = new MyTask(textBoxtaskname.Text, comboBoxtasktype.Text, comboBoxtrigger.Text, textBoxperiod.Text, eventss, te, cals);
                                    tasks[taskselect] = task;
                                    if (taskchange)
                                    {
                                        ChangeTask(xmlDocument, root, task);
                                    }
                                    else
                                    {
                                        CreateTask(xmlDocument, root, task);
                                    }
                                    Showxml();
                                    ClearTask();
                                    RefreshTask();
                                    SaveOK(1);
                                }
                                else
                                {
                                    MessageBox.Show("????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("???????????????????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(result, "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        public Event[] GetTaskEvent(Event[] e, string relation)
        {
            //????????????????????????????????????
            string temp = relation;
            Event[] returne = new Event[0];
            foreach (Event ee in e)
            {
                if (temp != temp.Replace(ee.eventname, ""))
                {
                    Array.Resize(ref returne, returne.Length + 1);
                    returne[returne.Length - 1] = ee;
                }
            }
            return returne;
        }

        public void Showxml()
        {
            //????????????xml
            string path = Path.Combine(Application.StartupPath, "temp.xml");
            xmlDocument.Save(path);
            string xmltxt = File.ReadAllText(path);
            textBoxxml.Text = xmltxt.Replace("======", "&#x0020;");
            File.Delete(path);
        }

        public void ChangeTask(XmlDocument xd, XmlElement root, MyTask t)
        {
            //??????task
            XmlElement task = AddTask(xd, t);
            XmlElement old = (XmlElement)root.ChildNodes.Item(taskselect);
            root.ReplaceChild(task, old);
        }

        public void CreateTask(XmlDocument xd, XmlElement root, MyTask t)
        {
            //??????task
            XmlElement task = AddTask(xd, t);
            root.AppendChild(task);
        }

        public void DeleteTask(XmlElement root, int index)
        {
            //??????task
            XmlElement rm = (XmlElement)root.ChildNodes.Item(index);
            root.RemoveChild(rm);
        }

        public XmlElement AddTask(XmlDocument xd, MyTask t)
        {
            //????????????
            XmlElement task = xd.CreateElement("Task");
            task.SetAttribute("Name", t.name);
            taskname = t.name;
            //????????????
            XmlElement rule = xd.CreateElement("Rule");
            rule.SetAttribute("TaskType", t.tasktype);
            rule.SetAttribute("TaskTrigger", t.tasktrigger);
            if (t.taskperiod != "")
            {
                rule.SetAttribute("TaskPeriod", t.taskperiod);
            }
            else
            {
                rule.SetAttribute("TaskPeriod", "5");//?????????????????????
            }
            if (t.events != "")
            {
                rule.SetAttribute("Events", t.events.Replace(" ", "======"));//?????????????????????????????????xml??????&???????????????????????????????????????????????????????????????????????????
            }
            else if (isevent)
            {
                rule.SetAttribute("Events", events[0].eventname);
            }
            task.AppendChild(rule);
            //??????????????????
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
            //????????????
            for (int i = 0; i < t.c.Length; i++)
            {
                XmlElement calcu = xd.CreateElement("Cal");
                calcu.SetAttribute("Name", t.c[i].calname);
                calcu.SetAttribute("URI", t.c[i].caluri);
                cals.AppendChild(calcu);
            }
            return task;
        }

        private void buttonAddevent_Click(object sender, EventArgs e)
        {
            //??????????????????
            ClearEvent();
            eventindex++;
            string na = "event" + eventindex.ToString();
            listBoxevent.Items.Add(na);
            Array.Resize(ref eventnames, eventindex);
            Array.Resize(ref events, eventindex);
            eventnames[eventindex - 1] = na;
            listBoxevent.SelectedItem = listBoxevent.Items[eventindex - 1];
            textBoxeventname.Text = eventnames[eventselect];
            eventchange = false;
        }

        private void buttonAddcal_Click(object sender, EventArgs e)
        {
            //??????????????????
            ClearCal();
            calindex++;
            string na = "cal" + calindex.ToString();
            listBoxcal.Items.Add(na);
            Array.Resize(ref calnames, calindex);
            Array.Resize(ref cals, calindex);
            calnames[calindex - 1] = na;
            listBoxcal.SelectedItem = listBoxcal.Items[calindex - 1];
            textBoxcalname.Text = calnames[calselect];
            calchange = false;
        }

        public bool CheckCopy(Event[] obj, Event objs)
        {
            //????????????????????????
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
            //?????????????????????????????????
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

        public string CheckRelation(Event[] e, string relation)
        {
            //????????????
            string temp = relation;
            //??????AND OR
            if(temp.Replace("AND", "").Replace("OR", "").Replace(" ","")!= temp.Replace(" AND ", "").Replace(" OR ", "").Replace(" ", ""))
            {
                return "??????????????????????????????";
            }
            temp = temp.Replace("AND", "").Replace("OR", "");
            //????????????
            if (IsCorrect(temp))
            {
                temp = temp.Replace("(", "").Replace(")", "");
            }
            else
            {
                return "??????????????????";
            }
            //?????????????????????
            foreach (Event ee in e)
            {
                temp = temp.Replace(ee.eventname, "");
            }
            //????????????
            if (temp.Trim() == "")
            {
                return "????????????????????????";
            }
            else
            {
                if (temp.Replace("and", "").Replace("or", "").Replace("And", "").Replace("Or", "").Trim() == "")
                {
                    return "???????????????????????????";
                }
                return "???????????????????????????????????????????????????";
            }
        }

        public static bool IsCorrect(string exp)
        {
            //????????????
            int num = 0;//??????
            List<int> numList = new List<int>();
            if (!string.IsNullOrEmpty(exp))
            {
                for (int i = 0; i < exp.Length; i++)
                {
                    num = 0;
                    switch (exp[i])
                    {
                        case '(':
                            num = 1;
                            break;
                        case ')':
                            num = -1;
                            break;
                    }
                    if (num > 0)
                        numList.Add(num);
                    if (num < 0)
                    {
                        if (numList[numList.Count - 1] + num == 0)
                            numList.Remove(numList[numList.Count - 1]);
                        else
                            return false;
                    }
                }
            }
            if (numList.Count == 0)
                return true;
            else
                return false;
        }

        private void buttonsaveevent_Click(object sender, EventArgs e)
        {
            //??????????????????
            if (listBoxevent.Items.Count <= 0)
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxeventname.Text != "" && comboBoxeventtype.Text != "" && comboBoxjudge.Text != "" &&
                textBoxvalue.Text != "")
            {
                if (!textBoxtag.Enabled)
                {
                    textBoxtag.Text = "";
                }
                events[eventselect] = new Event(textBoxeventname.Text, comboBoxeventtype.Text, textBoxtag.Text, comboBoxjudge.Text, textBoxvalue.Text);
                if (textBoxeventname.Text != listBoxevent.SelectedItem.ToString())
                {
                    listBoxevent.SelectedItem = textBoxeventname.Text;
                }
                ClearEvent();
                RefreshEvent();
                SaveOK(2);
                panelevent.Enabled = false;
            }
            else
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonsavecal_Click(object sender, EventArgs e)
        {
            //??????????????????
            if (listBoxcal.Items.Count <= 0)
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxcalname.Text != "" && textBoxuri.Text != "")
            {
                cals[calselect] = new Cal(textBoxcalname.Text, textBoxuri.Text);
                if (textBoxcalname.Text != listBoxcal.SelectedItem.ToString())
                {
                    listBoxcal.SelectedItem = textBoxcalname.Text;
                }
                ClearCal();
                RefreshCal();
                SaveOK(3);
                panelcal.Enabled = false;
            }
            else
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //???????????????????????????
            if (comboBoxtasktype.SelectedItem.ToString() == "Time")
            {
                textBoxtag.Enabled = false;
            }
            else
            {
                textBoxtag.Enabled = true;
            }
        }

        private void comboBoxtrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            //???????????????????????????????????????
            if (comboBoxtrigger.SelectedItem == null)
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = true;
                isevent = false;
                textBoxrelation.Enabled = true;
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Cycle")
            {
                textBoxperiod.Text = "";
                textBoxperiod.Enabled = false;
                buttonAddevent.Enabled = false;
                isevent = false;
                textBoxrelation.Enabled = false;
                textBoxrelation.Text = "";
                eventss = "";
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Period")
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = false;
                isevent = false;
                textBoxrelation.Enabled = false;
                textBoxrelation.Text = "";
                eventss = "";
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Event")
            {
                textBoxperiod.Text = "";
                textBoxperiod.Enabled = false;
                buttonAddevent.Enabled = true;
                isevent = true;
                if (eventss == "")
                {
                    isrelation = false;
                }
                textBoxrelation.Enabled = true;
            }
            else if (comboBoxtrigger.SelectedItem.ToString() == "Periodevent")
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = true;
                isevent = true;
                if (eventss == "")
                {
                    isrelation = false;
                }
                textBoxrelation.Enabled = true;
            }
            else
            {
                textBoxperiod.Enabled = true;
                buttonAddevent.Enabled = true;
                isevent = false;
                textBoxrelation.Enabled = true;
            }
        }

        private void listBoxtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            //????????????
            paneltask.Enabled = true;
            panelcallist.Enabled = true;
            taskselect = listBoxtask.SelectedIndex;
            if (taskselect == -1)
            {
                paneltask.Enabled = false;
                panelcallist.Enabled = false;
                ClearTask();
                timerinfo.Stop();
            }
            else if (tasks[taskselect] != null)
            {
                ClearTask();
                PrintTask(taskselect);
                calindex = tasks[taskselect].c.Length;
                timerinfo.Start();
            }
            else
            {
                taskchange = false;
                ClearTask();
                textBoxtaskname.Text = listBoxtask.SelectedItem.ToString();
                timerinfo.Start();
            }
        }

        private void listBoxevent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //??????????????????
            panelevent.Enabled = true;
            eventselect = listBoxevent.SelectedIndex;
            if (eventselect == -1)
            {
                ClearEvent();
                panelevent.Enabled = false;
            }
            else if (events[eventselect] != null)
            {
                ClearEvent();
                PrintEvent(eventselect);
            }
            else
            {
                ClearEvent();
                textBoxeventname.Text = listBoxevent.SelectedItem.ToString();
            }
        }

        private void listBoxcal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //??????????????????
            panelcal.Enabled = true;
            calselect = listBoxcal.SelectedIndex;
            if (calselect == -1)
            {
                ClearCal();
                panelcal.Enabled = false;
            }
            else if (cals[calselect] != null)
            {
                ClearCal();
                PrintCal(calselect);
            }
            else
            {
                ClearCal();
                textBoxcalname.Text = listBoxcal.SelectedItem.ToString();
            }
        }

        public void ClearTask()
        {
            //task?????????
            calindex = 0;
            textBoxtaskname.Text = "";
            comboBoxtasktype.SelectedIndex = -1;
            comboBoxtrigger.SelectedIndex = -1;
            textBoxperiod.Text = "";
            textBoxrelation.Text = "";
            listBoxcal.SelectedIndex = -1;
            listBoxcal.Items.Clear();
            panelcal.Enabled = false;
            ClearCal();
        }

        public void ClearEvent()
        {
            textBoxeventname.Text = "";
            comboBoxeventtype.SelectedIndex = -1;
            comboBoxjudge.SelectedIndex = -1;
            textBoxtag.Text = "";
            textBoxvalue.Text = "";
        }

        public void ClearCal()
        {
            textBoxcalname.Text = "";
            textBoxuri.Text = "";
        }

        public void PrintTask(int index)
        {
            //????????????
            textBoxrelation.Enabled = false;
            taskchange = true;
            textBoxtaskname.Text = tasks[index].name;
            comboBoxtasktype.SelectedItem = tasks[index].tasktype;
            textBoxperiod.Text = tasks[index].taskperiod;
            if (tasks[index].e != null)
            {
                textBoxrelation.Enabled = true;
                if (tasks[index].events != "")
                {
                    eventss = tasks[index].events;
                    textBoxrelation.Text = eventss;
                }
            }
            comboBoxtrigger.SelectedItem = tasks[index].tasktrigger;
            if (tasks[index].c != null)
            {
                cals = tasks[index].c;
                calindex = cals.Length;
                listBoxcal.Items.Clear();
                for (int i = 0; i < calindex; i++)
                {
                    listBoxcal.Items.Add(tasks[index].c[i].calname);
                }
            }
        }

        public void ReadEvents()
        {
            //??????????????????
            foreach (var task in tasks)
            {
                foreach (var e in task.e)
                {
                    bool temp = false;
                    foreach (var ee in events)
                    {
                        if (e.eventname == ee.eventname)
                        {
                            temp = true;
                        }
                    }
                    if (!temp)
                    {
                        Array.Resize(ref events, events.Length + 1);
                        events[events.Length - 1] = e;
                    }
                }
            }
            eventindex = events.Length;
            for (int i = 0; i < eventindex; i++)
            {
                listBoxevent.Items.Add(events[i].eventname);
            }
        }

        public void PrintEvent(int index)
        {
            textBoxeventname.Text = events[index].eventname;
            comboBoxeventtype.SelectedItem = events[index].eventtype;
            comboBoxjudge.SelectedItem = events[index].eventjudge;
            textBoxtag.Text = events[index].eventtag;
            textBoxvalue.Text = events[index].eventvalue;
        }

        public void PrintCal(int index)
        {
            textBoxcalname.Text = cals[index].calname;
            textBoxuri.Text = cals[index].caluri;
        }

        public void RefreshTask()
        {
            for (int i = listBoxtask.Items.Count - 1; i >= 0; i--)
            {
                if (tasks[i] != null)
                {
                    listBoxtask.Items[i] = tasks[i].name;
                    tasknames[i] = tasks[i].name;
                }
            }
        }

        public void RefreshEvent()
        {
            for (int i = listBoxevent.Items.Count - 1; i >= 0; i--)
            {
                if (events[i] != null)
                {
                    listBoxevent.Items[i] = events[i].eventname;
                }
            }
        }

        public void RefreshCal()
        {
            for (int i = listBoxcal.Items.Count - 1; i >= 0; i--)
            {
                if (cals[i] != null)
                {
                    listBoxcal.Items[i] = cals[i].calname;
                }
            }
        }

        public void SaveOK(int type)
        {
            //??????????????????
            if (type == 1)
            {
                MessageBox.Show("?????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == 2)
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == 3)
            {
                MessageBox.Show("???????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttondeltask_Click(object sender, EventArgs e)
        {
            //????????????task
            if (taskindex > 0)
            {
                if (listBoxtask.SelectedIndex > -1)
                {
                    DeleteTask(root, listBoxtask.SelectedIndex);
                    for (int i = listBoxtask.SelectedIndex; i < tasks.Length - 1; i++)
                    {
                        tasks[i] = tasks[i + 1];
                    }
                    taskindex--;
                    Array.Resize(ref tasks, taskindex);
                    listBoxtask.Items.RemoveAt(listBoxtask.SelectedIndex);
                    Showxml();
                }
            }
        }

        private void buttondelevent_Click(object sender, EventArgs e)
        {
            //????????????event
            if (eventindex > 0)
            {
                if (listBoxevent.SelectedIndex > -1)
                {
                    for (int i = listBoxevent.SelectedIndex; i < events.Length - 1; i++)
                    {
                        events[i] = events[i + 1];
                    }
                    eventindex--;
                    Array.Resize(ref events, eventindex);
                    listBoxevent.Items.RemoveAt(listBoxevent.SelectedIndex);
                }
            }
        }

        private void buttondelcal_Click(object sender, EventArgs e)
        {
            //????????????cal
            if (calindex > 0)
            {
                if (listBoxcal.SelectedIndex > -1)
                {
                    for (int i = listBoxcal.SelectedIndex; i < cals.Length - 1; i++)
                    {
                        cals[i] = cals[i + 1];
                    }
                    calindex--;
                    Array.Resize(ref cals, calindex);
                    listBoxcal.Items.RemoveAt(listBoxcal.SelectedIndex);
                }
            }
        }

        private void buttonloadxml_Click(object sender, EventArgs e)
        {
            //???????????????xml
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!Directory.Exists(Application.StartupPath + "\\????????????"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\????????????");
                }
                openFileDialog.InitialDirectory = Application.StartupPath + "\\????????????";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "XML??????(*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    xt = new XmlTransfer(openFileDialog.FileName);
                    param = xt.Read10_VarAndType();
                    serverxml = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttongetvar_Click(object sender, EventArgs e)
        {
            //????????????
            if (serverxml)
            {
                Parameter para = new Parameter(param);
                if (para.ShowDialog() == DialogResult.OK)
                {
                    Xml10 p = para.returnvar;
                    textBoxtag.Text = p.xvar;
                }
            }
            else
            {
                MessageBox.Show("??????????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonvaluevar_Click(object sender, EventArgs e)
        {
            //????????????
            if (serverxml)
            {
                Parameter para = new Parameter(param);
                if (para.ShowDialog() == DialogResult.OK)
                {
                    Xml10 p = para.returnvar;
                    textBoxvalue.Text = p.xvar;
                }
            }
            else
            {
                MessageBox.Show("??????????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "????????????????????????????????????????????????????????????");
        }

        private void comboBoxtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtasktype, "??????????????????once(???????????????)???repeat(????????????)???");
        }

        private void comboBoxtrigger_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtrigger, "??????????????????Cycle(????????????)???Period(????????????)???Event(????????????)???Periodevent(??????+????????????)???");
        }

        private void textBoxperiod_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxperiod, "???????????????????????????????????????????????????");
        }

        private void buttonAddevent_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonAddevent, "?????????????????????????????????????????????????????????1??????????????????????????????????????????");
        }

        private void buttonAddcal_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonAddcal, "???????????????????????????");
        }

        private void textBoxeventname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "?????????????????????.????????????????????????????????????");
        }

        private void comboBoxeventtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtasktype, "?????????????????????tag/time??????????????????????????????????????????/???????????????");
        }

        private void textBoxtag_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtag, "????????????");
        }

        private void comboBoxjudge_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxjudge, "???????????????");
        }

        private void textBoxvalue_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxvalue, "???????????????");
        }

        private void textBoxcalname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "??????????????????????????????????????????????????????");
        }

        private void textBoxuri_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxuri, "???????????????????????????????????????????????????????????????URL???????????????");
        }

        private void buttonadd_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonaddtask, "???????????????????????????????????????????????????????????????");
        }

        private void textBoxrelation_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxrelation, "??????????????????????????????????????????????????????????????????????????????????????????????????? AND ???OR ?????????????????????????????????????????????");
        }

        private void timerinfo_Tick(object sender, EventArgs e)
        {
            string[] taskinfo = new string[4];
            taskinfo[0] = "?????????????????????\r\n\r\n???????????????";
            bool info1 = false;
            if (textBoxtaskname.Text != "" && comboBoxtasktype.Text != "" && comboBoxtrigger.Text != "" && (textBoxperiod.Text != "" || !textBoxperiod.Enabled))
            {
                taskinfo[0] += "???????????????";
                info1 = true;
            }
            else
            {
                taskinfo[0] += "????????????????????";
            }
            taskinfo[1] = "?????????????????????";
            if (!isevent)
            {
                taskinfo[1] += "???????????????";
            }
            else if (textBoxrelation.Text != "") 
            {
                taskinfo[1] += "???????????????";
            }
            else
            {
                taskinfo[1] += "??????????????";
            }
            taskinfo[2] = "???????????????";
            if (cals.Length > 0 && cals[0] != null)
            {
                taskinfo[2] += "???????????????\r\n";
            }
            else
            {
                taskinfo[2] += "??????????????\r\n";
            }
            if (textBoxrelation.Text != "" && cals.Length > 0 && info1)
            {
                taskinfo[3] = "??????????????????????????????";
            }
            else
            {
                taskinfo[3] = "??????????????????????????";
            }
            richTextBoxtaskinfo.Lines = taskinfo;
        }

        private void buttongetsftpcal_Click(object sender, EventArgs e)
        {
            //???sftp????????????????????????
            try
            {
                if (sftp.Connected)
                {
                    SFTPExplorer se = new SFTPExplorer(sftp, false, false, taskpath);
                    if (se.ShowDialog() == DialogResult.OK)
                    {
                        string calpath = se.returnpath;
                        if (calpath.StartsWith(taskpath))
                        {
                            calpath = calpath.Replace(taskpath, "");
                            textBoxuri.Text = calpath;
                        }
                        else
                        {
                            MessageBox.Show("???????????????Task???????????????????????????????????????????????????????????????????????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SFTP?????????????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "??????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class MyTask
    {
        //????????????????????????
        public string name;
        public string tasktype;
        public string tasktrigger;
        public string taskperiod;
        public string events;
        public Event[] e;
        public Cal[] c;

        public MyTask() { }

        public MyTask(string name, string type, string trigger, string period, string events, Event[] ee, Cal[] cc)
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
        //???????????????
        public string eventname;
        public string eventtype;
        public string eventtag;
        public string eventjudge;
        public string eventvalue;

        public Event() { }

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
        //???????????????
        public string calname;
        public string caluri;

        public Cal() { }

        public Cal(string calname, string caluri)
        {
            this.calname = calname;
            this.caluri = caluri;
        }
    }
}
