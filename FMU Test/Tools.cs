using Renci.SshNet;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FMU_Test
{
    public class TipTools
    {
        public ToolTip toolTip = new ToolTip();

        public TipTools()
        {
            //初始化
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
        }
        public void ToolTips(TextBox box, string tips)
        {
            //鼠标悬停说明文字
            toolTip.SetToolTip(box, tips);
        }

        public void ToolTips(CheckBox box, string tips)
        {
            //鼠标悬停说明文字
            toolTip.SetToolTip(box, tips);
        }

        public void ToolTips(ComboBox box, string tips)
        {
            //鼠标悬停说明文字
            toolTip.SetToolTip(box, tips);
        }

        public void ToolTips(Button box, string tips)
        {
            //鼠标悬停说明文字
            toolTip.SetToolTip(box, tips);
        }

        public void Clear()
        {
            //移除实例添加的所有说明
            toolTip.RemoveAll();
        }
    }

    public class InfoTools
    {
        public RichTextBox tb = new RichTextBox();
        public bool islog = true;

        public InfoTools(RichTextBox tb)
        {
            // 生成实例
            this.tb = tb;
        }

        public void AddInfo(string info, int type)
        {
            // 创建运行日志
            if (type == 1)
            {
                tb.BeginInvoke(new Action(() => { tb.AppendText("["); }));
                AddColorInfo("测试", Color.Green);
                tb.BeginInvoke(new Action(() => { tb.AppendText("]" + DateTime.Now + " " + info + "\r\n"); }));
                if (islog)
                {
                    Savelog("[测试]" + DateTime.Now + " " + info + "\r\n");
                }
            }
            else if (type == 2)
            {
                tb.BeginInvoke(new Action(() => { tb.AppendText("["); }));
                AddColorInfo("警告", Color.Red);
                tb.BeginInvoke(new Action(() => { tb.AppendText("]" + DateTime.Now + " " + info + "\r\n"); }));
                if (islog)
                {
                    Savelog("[警告]" + DateTime.Now + " " + info + "\r\n");
                }
            }
            else if (type == 3)
            {
                tb.BeginInvoke(new Action(() => { tb.AppendText(info); }));
                if (islog)
                {
                    Savelog(info);
                }
            }
            tb.BeginInvoke(new Action(() => { tb.ScrollToCaret(); }));
        }

        public void AddColorInfo(string info, Color color)
        {
            // 用于输出带颜色的信息
            tb.BeginInvoke(new Action(() =>
            {
                tb.SelectionStart = tb.TextLength;
                tb.SelectionLength = 0;
                tb.SelectionColor = color;
                tb.AppendText(info);
                tb.SelectionColor = tb.ForeColor;
                tb.ScrollToCaret();
            }));
        }

        public void Savelog(string log)
        {
            //保存日志
            try
            {
                string path = Application.StartupPath + "\\运行日志\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                StreamWriter sw = new StreamWriter(path, true);
                sw.Flush();
                sw.Write(log);
                sw.Close();
            }
            catch(Exception e)
            {
                AddInfo(e.Message, 2);
            }
        }
    }

    public class SFTPHelper
    {
        // SFTP操作类
        private SftpClient sftp;
        // SFTP连接状态
        public bool Connected { get { return sftp.IsConnected; } }

        public SFTPHelper(string ip, string port, string user, string pwd)
        {
            // 构造
            sftp = new SftpClient(ip, Int32.Parse(port), user, pwd);
            sftp.OperationTimeout = TimeSpan.FromSeconds(1);
        }

        public bool Connect()
        {
            // 连接SFTP
            try
            {
                if (!Connected)
                {
                    sftp.Connect();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("连接SFTP失败，原因：{0}", ex.Message));
            }
        }

        public void Disconnect()
        {
            // 断开SFTP
            try
            {
                if (sftp != null && Connected)
                {
                    sftp.Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("断开SFTP失败，原因：{0}", ex.Message));
            }
        }

        public long Put(string localPath, string remotePath)
        {
            // SFTP上传文件
            try
            {
                using (var file = File.OpenRead(localPath))
                {
                    sftp.UploadFile(file, remotePath);
                    var issuccess = CheckFile(remotePath);
                    if (!issuccess)
                    {
                        throw new Exception(string.Format("未检测到上传的文件。"));
                    }
                    return file.Length;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件上传失败，原因：{0}", ex.Message));
            }
        }

        public long Get(string remotePath, string localPath)
        {
            // SFTP获取文件
            try
            {
                var byt = sftp.ReadAllBytes(remotePath);
                File.WriteAllBytes(localPath, byt);
                return byt.LongLength;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
            }

        }

        public void Delete(string remoteFile)
        {
            // 删除SFTP文件
            try
            {
                sftp.Delete(remoteFile);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件删除失败，原因：{0}", ex.Message));
            }
        }

        public ArrayList GetFileList(string remotePath)
        {
            // 获取SFTP文件列表
            try
            {
                var files = sftp.ListDirectory(remotePath);
                var objList = new ArrayList();
                foreach (var file in files)
                {
                    string name = file.Name;
                    string path = file.FullName;
                    bool isdir = file.IsDirectory;
                    if (!file.OthersCanRead)
                    {
                        file.OthersCanRead = true;
                    }
                    bool isotherread = file.OthersCanRead;
                    SFTPinfo s = new SFTPinfo(name, path, isdir, isotherread);
                    objList.Add(s);
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件列表获取失败，原因：{0}", ex.Message));
            }
        }

        public bool CheckFile(string RemotePath)
        {
            // 检查SFTP文件
            try
            {
                return sftp.Get(RemotePath) != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class SFTPinfo
    {
        //SFTP文件信息类
        public string name;
        public string path;
        public bool isdir;
        public bool isOtherRead;

        public SFTPinfo() { }

        public SFTPinfo(string name, string path, bool isdir, bool isotherread)
        {
            this.name = name;
            this.path = path;
            this.isdir = isdir;
            isOtherRead = isotherread;
        }
    }

    public class XmlTransfer
    {
        public XmlTextReader xr;
        public XmlTransfer(string xmlpath)
        {
            //初始化
            xr = new XmlTextReader(xmlpath);
        }

        public ArrayList Read10_VarAndType()
        {
            //读取_10格式的xml
            ArrayList vars = new ArrayList();
            string xnamespace = "";
            string xprogram = "";
            string var = "";
            string typename = "";
            while (xr.Read())
            {
                XmlNodeType nt = xr.NodeType;
                xr.WhitespaceHandling = WhitespaceHandling.None;
                if (nt == XmlNodeType.Element)
                {
                    if (xr.Name == "NamespaceDecl")
                    {
                        xnamespace = xr.GetAttribute("name");
                    }
                    if (xr.Name == "Program")
                    {
                        xprogram = xr.GetAttribute("name");
                    }
                    if (xr.Name == "Variable")
                    {
                        var = xr.GetAttribute("name");
                    }
                    if (xr.Name == "TypeName")
                    {
                        xr.Read();
                        typename = xr.Value;
                        Xml10 xv = new Xml10(xnamespace, xprogram, typename, var);
                        vars.Add(xv);
                    }
                }
            }
            return vars;
        }
    }

    public class Xml10
    {
        public string xnamespace;
        public string xprogram;
        public string xtype;
        public string xvar;

        public Xml10() { }

        public Xml10(string xnamespace, string xprogram, string xtype, string xvar)
        {
            this.xnamespace = xnamespace;
            this.xprogram = xprogram;
            this.xtype = xtype;
            this.xvar = xvar;
        }
    }
}