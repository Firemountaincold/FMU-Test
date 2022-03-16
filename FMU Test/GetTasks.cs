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
            //保存xml文件
            if (!Directory.Exists(Application.StartupPath + "\\XML文件"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\XML文件");
            }
            if (xmlpath == "")
            {
                xmlDocument.Save(Application.StartupPath + "\\XML文件\\task.xml");
                string xmltxt = File.ReadAllText(Application.StartupPath + "\\XML文件\\task.xml");
                File.WriteAllText(Application.StartupPath + "\\XML文件\\task.xml", xmltxt.Replace("======", "&#x0020;"));
            }
            else
            {
                xmlDocument.Save(xmlpath);
                string xmltxt = File.ReadAllText(xmlpath);
                File.WriteAllText(xmlpath, xmltxt.Replace("======", "&#x0020;"));
            }
            isxmlsaveed = true;
            MessageBox.Show("XML文件保存成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //退出
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
            //将xml文件读取到界面
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
                    tasks[i].events = rule.GetAttribute("Events").ToString();//转义
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
            //检查名称是否重复
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
            //创建Task
            try
            {
                //保存触发逻辑
                if (listBoxtask.Items.Count <= 0)
                {
                    MessageBox.Show("请先添加任务！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxtaskname.Text != "" && comboBoxtasktype.Text != "" && comboBoxtrigger.Text != "" && (textBoxperiod.Text != "" || !textBoxperiod.Enabled) && (textBoxrelation.Text != "" || !isevent)) 
                {
                    string result = CheckRelation(events, textBoxrelation.Text);
                    if (result == "已通过语法检查。")
                    {
                        eventss = textBoxrelation.Text;
                        isrelation = true;
                        MessageBox.Show("逻辑关系保存成功。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    MessageBox.Show("请添加计算任务。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("请添加触发条件。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("请添加触发条件的逻辑关系。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(result, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("请添加必要的信息。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        public Event[] GetTaskEvent(Event[] e, string relation)
        {
            //从逻辑关系中获取触发条件
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
            //查看临时xml
            string path = Path.Combine(Application.StartupPath, "temp.xml");
            xmlDocument.Save(path);
            string xmltxt = File.ReadAllText(path);
            textBoxxml.Text = xmltxt.Replace("======", "&#x0020;");
            File.Delete(path);
        }

        public void ChangeTask(XmlDocument xd, XmlElement root, MyTask t)
        {
            //替换task
            XmlElement task = AddTask(xd, t);
            XmlElement old = (XmlElement)root.ChildNodes.Item(taskselect);
            root.ReplaceChild(task, old);
        }

        public void CreateTask(XmlDocument xd, XmlElement root, MyTask t)
        {
            //添加task
            XmlElement task = AddTask(xd, t);
            root.AppendChild(task);
        }

        public void DeleteTask(XmlElement root, int index)
        {
            //删除task
            XmlElement rm = (XmlElement)root.ChildNodes.Item(index);
            root.RemoveChild(rm);
        }

        public XmlElement AddTask(XmlDocument xd, MyTask t)
        {
            //创建结点
            XmlElement task = xd.CreateElement("Task");
            task.SetAttribute("Name", t.name);
            taskname = t.name;
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
            if (t.events != "")
            {
                rule.SetAttribute("Events", t.events.Replace(" ", "======"));//空格要变转义符号，但在xml里变&会自动再次转义，所以先用奇怪符号替换，保存后再转义
            }
            else if (isevent)
            {
                rule.SetAttribute("Events", events[0].eventname);
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
            return task;
        }

        private void buttonAddevent_Click(object sender, EventArgs e)
        {
            //添加触发事件
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
            //添加计算任务
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

        public string CheckRelation(Event[] e, string relation)
        {
            //语法检测
            string temp = relation;
            //检测AND OR
            if(temp.Replace("AND", "").Replace("OR", "").Replace(" ","")!= temp.Replace(" AND ", "").Replace(" OR ", "").Replace(" ", ""))
            {
                return "请用空格隔开关键字！";
            }
            temp = temp.Replace("AND", "").Replace("OR", "");
            //检测括号
            if (IsCorrect(temp))
            {
                temp = temp.Replace("(", "").Replace(")", "");
            }
            else
            {
                return "括号不匹配！";
            }
            //检测触发条件名
            foreach (Event ee in e)
            {
                temp = temp.Replace(ee.eventname, "");
            }
            //检测剩余
            if (temp.Trim() == "")
            {
                return "已通过语法检查。";
            }
            else
            {
                if (temp.Replace("and", "").Replace("or", "").Replace("And", "").Replace("Or", "").Trim() == "")
                {
                    return "关键字大小写错误。";
                }
                return "未通过语法检查，请检查字符串拼写。";
            }
        }

        public static bool IsCorrect(string exp)
        {
            //括号匹配
            int num = 0;//标记
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
            //添加触发条件
            if (listBoxevent.Items.Count <= 0)
            {
                MessageBox.Show("请先添加触发条件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("请输入所需的信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonsavecal_Click(object sender, EventArgs e)
        {
            //添加计算任务
            if (listBoxcal.Items.Count <= 0)
            {
                MessageBox.Show("请先添加计算任务！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("请输入所需的信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //不同选择，控件不同
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
            //根据选择判断应该使用的控件
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
            //选择任务
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
            //选择触发条件
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
            //选择计算任务
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
            //task级清除
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
            //读取任务
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
            //读取触发条件
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
            //保存成功提示
            if (type == 1)
            {
                MessageBox.Show("任务保存成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == 2)
            {
                MessageBox.Show("触发事件保存成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == 3)
            {
                MessageBox.Show("控制算法保存成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttondeltask_Click(object sender, EventArgs e)
        {
            //删除一个task
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
            //删除一个event
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
            //删除一个cal
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
            //载入服务器xml
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (!Directory.Exists(Application.StartupPath + "\\配置文件"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\配置文件");
                }
                openFileDialog.InitialDirectory = Application.StartupPath + "\\配置文件";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "XML文件(*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    xt = new XmlTransfer(openFileDialog.FileName);
                    param = xt.Read10_VarAndType();
                    serverxml = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttongetvar_Click(object sender, EventArgs e)
        {
            //选择变量
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
                MessageBox.Show("请先载入服务器配置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonvaluevar_Click(object sender, EventArgs e)
        {
            //选择变量
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
                MessageBox.Show("请先载入服务器配置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "任务定义信息，每个任务有一个唯一的名字。");
        }

        private void comboBoxtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtasktype, "调度方法包括once(一次性调度)和repeat(多次调度)。");
        }

        private void comboBoxtrigger_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtrigger, "触发条件包括Cycle(循环触发)、Period(周期触发)、Event(条件触发)、Periodevent(周期+条件触发)。");
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

        private void textBoxeventname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "触发事件的名字.在本任务内应保持唯一性。");
        }

        private void comboBoxeventtype_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(comboBoxtasktype, "触发条件类型，tag/time分别表示触发条件为系统的变量/当前时间。");
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

        private void textBoxcalname_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxtaskname, "计算任务的名字，要求名字保持唯一性。");
        }

        private void textBoxuri_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxuri, "计算任务的位置，它是相对于资源根目录的一个URL资源位置。");
        }

        private void buttonadd_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(buttonaddtask, "添加任务定义信息，每个任务有一个唯一的名字");
        }

        private void textBoxrelation_MouseHover(object sender, EventArgs e)
        {
            tip.ToolTips(textBoxrelation, "逻辑关系是多个触发条件的逻辑组合关系，它的值是一个由触发条件名字和 AND 、OR 、括号、空格组成的字串表达式。");
        }

        private void timerinfo_Tick(object sender, EventArgs e)
        {
            string[] taskinfo = new string[4];
            taskinfo[0] = "当前任务信息：\r\n\r\n任务信息：";
            bool info1 = false;
            if (textBoxtaskname.Text != "" && comboBoxtasktype.Text != "" && comboBoxtrigger.Text != "" && (textBoxperiod.Text != "" || !textBoxperiod.Enabled))
            {
                taskinfo[0] += "已填写。√";
                info1 = true;
            }
            else
            {
                taskinfo[0] += "未完全填写。×";
            }
            taskinfo[1] = "触发条件逻辑：";
            if (!isevent)
            {
                taskinfo[1] += "未启用。√";
            }
            else if (textBoxrelation.Text != "") 
            {
                taskinfo[1] += "已填写。√";
            }
            else
            {
                taskinfo[1] += "未填写。×";
            }
            taskinfo[2] = "控制算法：";
            if (cals.Length > 0 && cals[0] != null)
            {
                taskinfo[2] += "已保存。√\r\n";
            }
            else
            {
                taskinfo[2] += "未保存。×\r\n";
            }
            if (textBoxrelation.Text != "" && cals.Length > 0 && info1)
            {
                taskinfo[3] = "任务现在可以保存。√";
            }
            else
            {
                taskinfo[3] = "任务填写不完整。×";
            }
            richTextBoxtaskinfo.Lines = taskinfo;
        }

        private void buttongetsftpcal_Click(object sender, EventArgs e)
        {
            //用sftp连接选择控制算法
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
                            MessageBox.Show("所选目录与Task默认路径不符，请重新选取或更改默认路径，也可使用手动输入。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SFTP服务器未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class MyTask
    {
        //用于构造任务的类
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
        //触发事件类
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
        //计算任务类
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
