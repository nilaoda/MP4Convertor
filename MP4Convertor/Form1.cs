using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// 2017-2-25 ver 0.1
///           - 初步实现所有功能。
/// </summary>
namespace MP4Convertor
{
    public partial class Form1 : Form
    {
        //拖动窗口
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        //不影响点击任务栏图标最大最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Init();  //  RealAction.cs
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "视频文件|*.avi;*.wmv;*.wmp;*.wm;*.asf;*.mpg;*.mpeg;*.mpe;*.m1v;*.m2v;*.mpv2;*.mp2v;*.ts;*.tp;*.tpr;*.trp;*.vob;*.ifo;*.ogm;*.ogv;*.mp4;*.m4v;*.m4p;*.m4b;*.3gp;*.3gpp;*.3g2;*.3gp2;*.mkv;*.rm;*.ram;*.rmvb;*.rpm;*.flv;*.swf;*.mov;*.qt;*.amr;*.nsv;*.dpg;*.m2ts;*.m2t;*.mts;*.dvr-ms;*.k3g;*.skm;*.evo;*.nsr;*.amv;*.divx;*.webm;*.wtv;*.f4v";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fs = fileDialog.FileNames;
                foreach (string ff in fs)
                    filelist.Items.Add(ff);
            }
        }

        private void checkBox_qtcs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_qtcs.CheckState == CheckState.Checked)
            {
                checkBox_qtcs.ForeColor = Color.FromArgb(46, 204, 113);
            }
            if (checkBox_qtcs.CheckState == CheckState.Unchecked)
            {
                checkBox_qtcs.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void checkBox_allstream_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allstream.CheckState == CheckState.Checked)
            {
                checkBox_allstream.ForeColor = Color.FromArgb(46, 204, 113);
            }
            if (checkBox_allstream.CheckState == CheckState.Unchecked)
            {
                checkBox_allstream.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (filelist.Items.Count == 0)
            {
                MessageBox.Show("没有数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //开始判断参数
                string meta = "";
                string bsf = "";
                string movflags = "";
                if (textBox_title.Text != "")
                {
                    meta += "-metadata title=" + "\"" + textBox_title.Text + "\" ";
                }
                if (textBox_copyright.Text != "")
                {
                    meta += "-metadata copyright=" + "\"" + textBox_copyright.Text + "\" ";
                }
                if (textBox_comment.Text != "")
                {
                    meta += "-metadata comment=" + "\"" + textBox_comment.Text + "\" ";
                }
                if (checkBox_qtcs.Checked == true)
                {
                    bsf += "-bsf:a aac_adtstoasc ";
                }
                if (checkBox_movflags.Checked == true)
                {
                    movflags += "-movflags +faststart ";
                }

                String TempBat = Path.GetTempPath() + "\\批处理-" + System.DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".bat";
                StreamWriter bat = new StreamWriter(TempBat, false, Encoding.Default);  //写入数据
                bat.WriteLine("@echo off");
                for (int i = 0; i < filelist.Items.Count; i++)
                {
                    OutPath.Text = filelist.Items[i].ToString().Substring(0, filelist.Items[i].ToString().LastIndexOf("\\")) + "\\MP4 Convertor";  //获取输出路径
                    OutName.Text = filelist.Items[i].ToString().Substring(filelist.Items[i].ToString().LastIndexOf("\\") + 1, (filelist.Items[i].ToString().LastIndexOf(".") - filelist.Items[i].ToString().LastIndexOf("\\") - 1));  //获取文件名;

                    if (!Directory.Exists(OutPath.Text))//若文件夹不存在则新建文件夹   
                    {
                        Directory.CreateDirectory(OutPath.Text); //新建文件夹   
                    }
                    if (File.Exists(OutPath.Text + "\\" + OutName.Text + ".mp4"))
                    {
                        if (MessageBox.Show("已存在文件，是否覆盖？", "请确认您的操作", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                        {
                            break;
                        }
                    }

                    if(checkBox_allstream.Checked == true)
                    {
                        bat.WriteLine(("\"" + Environment.CurrentDirectory + "\\ffmpeg.exe" + "\" -i \"" + filelist.Items[i].ToString()
                            + "\" -y -map 0:v -vcodec copy -map 0:a -acodec copy " + bsf + movflags + meta + "\""
                            + OutPath.Text + "\\" + OutName.Text + ".mp4\"").Replace("%", "%%"));
                    }
                    if (checkBox_allstream.Checked == false)
                    {
                        bat.WriteLine(("\"" + Environment.CurrentDirectory + "\\ffmpeg.exe" + "\" -i \"" + filelist.Items[i].ToString()
                            + "\" -y -c copy " + bsf + movflags + meta + "\""
                            + OutPath.Text + "\\" + OutName.Text + ".mp4\"").Replace("%", "%%"));
                    }
                }
                bat.Close();
                textBox1.Text = "";
                RealAction(TempBat);
                filelist.Enabled = false;
                AddFile.Enabled = false;
                Convert.Enabled = false;
            }
        }

        private void filelist_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                //获取拖拽的文件地址
                var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                var hz = filenames[0].LastIndexOf('.') + 1;
                var houzhui = filenames[0].Substring(hz);//文件后缀名
                if (houzhui == "m3u8" || houzhui == "mkv" || houzhui == "avi" || houzhui == "mp4" || houzhui == "ts" || houzhui == "flv" || houzhui == "f4v" ||
                    houzhui == "wmv" || houzhui == "wm" || houzhui == "mpeg" || houzhui == "mpg" || houzhui == "m4v" || houzhui == "3gp" || houzhui == "rm" ||
                    houzhui == "rmvb" || houzhui == "mov" || houzhui == "qt" || houzhui == "m2ts" || houzhui == "m3u" || houzhui == "mts" || houzhui == "txt") //只允许拖入部分文件
                {
                    String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (String s in files)
                    {
                        (sender as ListBox).Items.Add(s);
                    }
                }

            }
        }

        private void filelist_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void filelist_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //实例化ToolTip控件
            ToolTip tooltip1 = new ToolTip();
            //设置提示框显示时间，默认5000，最大为32767，超过此数，将以默认5000显示           
            tooltip1.AutoPopDelay = 30000;
            //是否以球状显示提示框            
            tooltip1.IsBalloon = true;
            //设置要显示提示框的控件 button1按钮
            tooltip1.SetToolTip(checkBox_qtcs, "当出错时可以考虑开启/关闭此选项后再试。");
            tooltip1.SetToolTip(checkBox_allstream, "此选项开启后将保留所有视频音轨轨道，\n否则默认保留第一视频轨和第一音频轨。");
            tooltip1.SetToolTip(checkBox_movflags, "movflags和faststart支持。");
            tooltip1.SetToolTip(checkBox_meta, "为视频写入其它信息。");

            if (File.Exists(@"ffmpeg.exe"))  //判断程序目录有无ffmpeg.exe
            {
            }
            else
            {
                MessageBox.Show("没有找到ffmpeg.exe", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Application.Exit();
            }
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("已运行程序！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);   //设置程序为无法多开
                Dispose();
                Application.Exit();
            }
        }

        private void checkBox_movflags_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_movflags.CheckState == CheckState.Checked)
            {
                checkBox_movflags.ForeColor = Color.FromArgb(46, 204, 113);
            }
            if (checkBox_movflags.CheckState == CheckState.Unchecked)
            {
                checkBox_movflags.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }

        private void checkBox_meta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_meta.CheckState == CheckState.Checked)
            {
                checkBox_meta.ForeColor = Color.FromArgb(46, 204, 113);
                textBox_title.Enabled = true; textBox_copyright.Enabled = true; textBox_comment.Enabled = true;
            }
            if (checkBox_meta.CheckState == CheckState.Unchecked)
            {
                checkBox_meta.ForeColor = Color.FromArgb(52, 152, 219);
                textBox_title.Enabled = false; textBox_copyright.Enabled = false; textBox_comment.Enabled = false;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filelist.SelectedItem != null)
            {
                filelist.Items.Remove(filelist.SelectedItem);
            }
        }

        private void 删除全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filelist.Items.Clear();
        }

        //右键选中并弹出菜单
        private void filelist_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int index = filelist.IndexFromPoint(e.Location);
                if (index >= 0)
                {
                    filelist.SelectedIndex = index;
                    this.contextMenuStrip1.Show(filelist, e.Location);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
