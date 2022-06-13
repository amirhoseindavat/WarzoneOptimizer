using HardwareInformation;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WarzoneOptimizer
{
    public partial class Main : Form
    {
        int t = 0, t2 = 0, flag = 0;// for priority save label
        string update_status_f = "";// for update status
        public const int WM_NCLBUTTONDOWN = 0xA1; //Move Form
        public const int HT_CAPTION = 0x2;
        readonly RegistryKey RegistrySet = Registry.CurrentUser.CreateSubKey("WarzoneOptimizer");// create registry entry
        readonly RegistryKey RegistryRead = Registry.CurrentUser.OpenSubKey("WarzoneOptimizer"); //RegistryRead
        readonly RegistryKey StartupCheck = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"); //StartupCheck
        readonly RegistryKey Startup = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); //Startup
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GetSystemInformation();// Load System Information
            try /*Load Priority */
            {
                comboBox.Text = RegistryRead.GetValue("Priority").ToString();
                Traymenupriority();
            }
            catch
            {
                comboBox.Items.Insert(0, "Please Select a Priority");
                comboBox.Text = "Please Select a Priority";
                flag = 1;
            }
            if (StartupCheck.GetValue("WarzoneOptimizer") == null) /*Startup Check */
            {
                label_startup.Text = "Startup (Not Installed)";
            }
            else
            {
                label_startup.Text = "Startup (Installed)";
            }
            Updater("load");
            Updatechecker();
        }
        private void GetSystemInformation()
        {
            GPU.Text = string.Format("GPU : {0}", GetHardwareInformation.GPU.Model);

            CPU.Text = string.Format("CPU : {0}", GetHardwareInformation.CPU.Model);

            RAM.Text = string.Format("RAM : {0} GB", GetHardwareInformation.Ram.Size);

            MONITOR.Text = string.Format("Monitor : {0}", GetHardwareInformation.Monitor.Model);

            OS.Text = string.Format("OS : {0} ", GetHardwareInformation.OS.Name);

            if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
                GPUModelBGChanger("Desktop");
            }
            else
            {
                GPUModelBGChanger("Laptop");
            }
        }

        private void GPUModelBGChanger(string type)
        {
            if (type == "Desktop")
            {
                if (GPU.Text.Contains("NVIDIA"))
                {
                    if (GPU.Text.Contains("1050") || GPU.Text.Contains("1060") || GPU.Text.Contains("1070") || GPU.Text.Contains("1080"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_gtx10xx;
                    }
                    else if (GPU.Text.Contains("1650") || GPU.Text.Contains("1660"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
                    }
                    else if (GPU.Text.Contains("2060") || GPU.Text.Contains("2070") || GPU.Text.Contains("2080"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
                    }
                    else if (GPU.Text.Contains("3050") || GPU.Text.Contains("3060") || GPU.Text.Contains("3070") || GPU.Text.Contains("3060") || GPU.Text.Contains("3070"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx30xx;
                    }
                    else
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
                    }
                }
                else if (GPU.Text.Contains("AMD"))
                {
                    if (GPU.Text.Contains("450") || GPU.Text.Contains("460") || GPU.Text.Contains("470") || GPU.Text.Contains("480"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rx5xx;
                    }
                    else if (GPU.Text.Contains("5300") || GPU.Text.Contains("5500") || GPU.Text.Contains("5600") || GPU.Text.Contains("5700"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rx5xxx;
                    }
                    else if (GPU.Text.Contains("6600") || GPU.Text.Contains("6700") || GPU.Text.Contains("6800") || GPU.Text.Contains("6900"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rx6xxx;
                    }
                    else if (GPU.Text.Contains("550") || GPU.Text.Contains("560") || GPU.Text.Contains("570") || GPU.Text.Contains("580") || GPU.Text.Contains("590"))
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rx5xx;
                    }
                    else
                    {
                        this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
                    }
                }
                else
                {
                    this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
                }
            }
            else if (type == "Laptop")
            {
                this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_laptop;
            }
            else
            {
                this.BackgroundImage = WarzoneOptimizer.Properties.Resources.ui_rtx20xx;
            }
        }

        private void Exit_Click(object sender, EventArgs e)//Exit
        {
            this.Close();
        }
        private void Minimize_Click(object sender, EventArgs e) //Minimize To Tray
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_Resize(object sender, EventArgs e)//PuttoTray
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState) { }
        }
        //Tray Menu Settings
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)//Open App
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)//Exit App
        {
            this.Close();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)//Open App With double Click
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }
        private void Label_drali_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/DrAli_W");
        }
        private void Label_About_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }
        private void Main_MouseDown(object sender, MouseEventArgs e) //MoveForm
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void WarzoneProccessCHK()
        {
            Process[] WarzoneP = Process.GetProcessesByName("ModernWarfare"); //CheckIfRunning
            if (WarzoneP.Length > 0)
            {
                label_Warzone_status.Text = "Warzone Is Running";
                label_Warzone_status.ForeColor = Color.FromArgb(46, 204, 113);
            }
            else
            {
                label_Warzone_status.Text = "Warzone Isn't Running";
                label_Warzone_status.ForeColor = Color.FromArgb(231, 76, 60);
            }
            var processes = Process.GetProcessesByName("ModernWarfare"); //ChangePriority
            foreach (var p in processes)
            {
                if (comboBox.Text == "Realtime")
                {
                    p.PriorityClass = ProcessPriorityClass.RealTime;
                }
                else if (comboBox.Text == "High")
                {
                    p.PriorityClass = ProcessPriorityClass.High;
                }
                else if (comboBox.Text == "Above normal")
                {
                    p.PriorityClass = ProcessPriorityClass.AboveNormal;
                }
                else if (comboBox.Text == "Normal")
                {
                    p.PriorityClass = ProcessPriorityClass.Normal;
                }
                else if (comboBox.Text == "Below normal")
                {
                    p.PriorityClass = ProcessPriorityClass.BelowNormal;
                }
                else if (comboBox.Text == "Low")
                {
                    p.PriorityClass = ProcessPriorityClass.Idle;
                }
            }
        }
        public void StartupCHK() //SetInstall_lbl
        {
            if (StartupCheck.GetValue("WarzoneOptimizer") == null)
            {
                Install_lbl.Text = "Install";
            }
            else
            {
                Install_lbl.Text = "Uninstall";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            WarzoneProccessCHK();
            StartupCHK();
            if (t == 4) /*labelUpdater */
            {
                label_select_p.Text = "";
                t = 0;
            }
            else
            {
                t++;
            }

            if (t2 == 4)
            {
                label_sturtup.Text = "";
                t2 = 0;
            }
            else
            {
                t2++;
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_startup.Focus();
            if (comboBox.Text == "Please Select a Priority") /*RegistrySetistry*/ { }
            else
            {
                //RegistryKey RegistrySet = Registry.CurrentUser.CreateSubKey("WarzoneOptimizer");
                RegistrySet.SetValue("Priority", comboBox.SelectedItem.ToString());
                Traymenupriority();
                label_select_p.Location = new Point(177, 374); //Save Alert
                label_select_p.Text = "Saved!";
                label_select_p.ForeColor = Color.FromArgb(46, 204, 113);
                if (flag == 1)
                {
                    comboBox.Items.RemoveAt(0);
                    flag = 0;
                }
                else { }
            }
        }
        private void Label_help_Click(object sender, EventArgs e)
        {
            Process.Start("https://CodeMage.ir/WarzoneOptimizer/");
        }
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void CheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckForUpdateToolStripMenuItem.Checked == true)
            {
                Updater("true");
            }
            else
            {
                Updater("false");
            }
        }
        private void Install_lbl_Click(object sender, EventArgs e)
        {
            InstalledCHK();
        }
        private void RealtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "Realtime";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        private void HighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "High";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        private void AboveNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "Above normal";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "Normal";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        private void BelowNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "Below normal";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        private void LowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uncheckothers();
            comboBox.Text = "Low";
            realtimeToolStripMenuItem.Checked = true;
            RegistrySet.SetValue("Priority", comboBox.Text.ToString());
            Traymenupriority();
        }
        public void InstalledCHK() //SetAsStartup
        {
            if (Install_lbl.Text.Contains("Uninstall"))
            {
                Startup.DeleteValue("WarzoneOptimizer");
                label_startup.Text = "Startup (Not Installed)";
                label_sturtup.Text = "Cleared!";
                label_sturtup.ForeColor = Color.FromArgb(231, 76, 60);
            }
            else
            {
                Startup.SetValue("WarzoneOptimizer", Application.ExecutablePath);
                label_startup.Text = "Startup (Installed)";
                label_sturtup.Text = "Saved!";
                label_sturtup.ForeColor = Color.FromArgb(46, 204, 113);
            }
        }
        public void Traymenupriority()
        {
            //Load Priority to menu
            Uncheckothers();
            if (comboBox.Text == "Realtime")
            {
                realtimeToolStripMenuItem.Checked = true;
            }
            else if (comboBox.Text == "High")
            {
                highToolStripMenuItem.Checked = true;
            }
            else if (comboBox.Text == "Above normal")
            {
                aboveNormalToolStripMenuItem.Checked = true;
            }
            else if (comboBox.Text == "Normal")
            {
                normalToolStripMenuItem.Checked = true;
            }
            else if (comboBox.Text == "Below normal")
            {
                belowNormalToolStripMenuItem.Checked = true;
            }
            else if (comboBox.Text == "Low")
            {
                lowToolStripMenuItem.Checked = true;
            }
        }
        public void Uncheckothers()
        {
            //Uncheck Other in Menu
            realtimeToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = false;
            aboveNormalToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            belowNormalToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
        }

        private void Label_update_stat_VisibleChanged(object sender, EventArgs e)
        {

        }

        public void Updatechecker()
        {
            var AppVersion = new Version(Application.ProductVersion);
            string update_status = RegistryRead.GetValue("checkupdate").ToString();
            if (update_status == "true")
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    XmlDocument data2 = new XmlDocument();
                    data2.Load("https://api.codemage.ir/Projects/WarzoneOptimizer/data.xml");
                    XmlElement root2 = data2.DocumentElement;
                    XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                    foreach (XmlNode node in nodes2)
                    {
                        string app_id_xml2 = node["SHA1"].InnerText;
                        var version_xml2 = new Version(node["last_version"].InnerText);
                        var result = AppVersion.CompareTo(version_xml2);
                        
                        if (Hasher("WarzoneOptimizer") == app_id_xml2)
                        {
                            if (result < 0)
                            {
                                label_update_stat.Text = "Update Available!";
                            }
                            else
                            {
                                label_update_stat.Text = "";
                            }
                        }
                    }
                }
                catch {}
            }
        }

        static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public void Updater(string stat)
        {
            if (stat == "true")
            {
                RegistrySet.SetValue("checkupdate", "true");
                Updatechecker();
            }
            else if (stat == "false")
            {
                RegistrySet.SetValue("checkupdate", "false");
                label_update_stat.Text = "";
            }
            else if (stat == "load")
            {
                try
                {
                    update_status_f = RegistryRead.GetValue("checkupdate").ToString();
                }
                catch
                {
                    RegistrySet.SetValue("checkupdate", "true");
                    update_status_f = RegistryRead.GetValue("checkupdate").ToString();
                }
                if (update_status_f == "true")
                {
                    CheckForUpdateToolStripMenuItem.Checked = true;
                }
                else
                {
                    CheckForUpdateToolStripMenuItem.Checked = false;
                }
            }
            else { }
        }
    }
}