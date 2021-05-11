using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Renci.SshNet;

namespace FMU_Test
{
    public class InfoTools
    {
        public RichTextBox tb = new RichTextBox();

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
            }
            else if (type == 2)
            {
                tb.BeginInvoke(new Action(() => { tb.AppendText("["); }));
                AddColorInfo("警告", Color.Red);
                tb.BeginInvoke(new Action(() => { tb.AppendText("]" + DateTime.Now + " " + info + "\r\n"); }));
            }
            else if (type == 3)
            {
                tb.BeginInvoke(new Action(() => { tb.AppendText(info); }));
            }
            tb.BeginInvoke(new Action(() => { tb.ScrollToCaret(); }));
        }

        public void AddColorInfo(string info, Color color)
        {
            // 用于输出带颜色的信息
            tb.BeginInvoke(new Action(() => { tb.SelectionStart = tb.TextLength; }));
            tb.BeginInvoke(new Action(() => { tb.SelectionLength = 0; }));
            tb.BeginInvoke(new Action(() => { tb.SelectionColor = color; }));
            tb.BeginInvoke(new Action(() => { tb.AppendText(info); }));
            tb.BeginInvoke(new Action(() => { tb.SelectionColor = tb.ForeColor; }));
            tb.BeginInvoke(new Action(() => { tb.ScrollToCaret(); }));
        }
    }

    /// <summary>
    /// SFTP操作类
    /// </summary>
    public class SFTPHelper
    {
        private SftpClient sftp;
        // SFTP连接状态
        public bool Connected { get { return sftp.IsConnected; } }

        public SFTPHelper(string ip, string port, string user, string pwd)
        {
            // 构造
            sftp = new SftpClient(ip, Int32.Parse(port), user, pwd);
            
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
                    return file.Length;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件上传失败，原因：{0}", ex.Message));
            }
        }

        public void Get(string remotePath, string localPath)
        {
            // SFTP获取文件
            try
            {
                var byt = sftp.ReadAllBytes(remotePath);
                File.WriteAllBytes(localPath, byt);
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

        public ArrayList GetFileList(string remotePath, string fileSuffix)
        {
            // 获取SFTP文件列表
            try
            {
                var files = sftp.ListDirectory(remotePath);
                var objList = new ArrayList();
                foreach (var file in files)
                {
                    string name = file.Name;
                    if (name.Length > (fileSuffix.Length + 1) && fileSuffix == name.Substring(name.Length - fileSuffix.Length))
                    {
                        objList.Add(name);
                    }
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件列表获取失败，原因：{0}", ex.Message));
            }
        }

        public void Move(string oldRemotePath, string newRemotePath)
        {
            // 移动SFTP文件
            try
            {
                sftp.RenameFile(oldRemotePath, newRemotePath);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件移动失败，原因：{0}", ex.Message));
            }
        }
    }
}
