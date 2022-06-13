using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace WarzoneOptimizer
{
    public partial class about : Form
    {
        string url;
        readonly RegistryKey RegistryRead = Registry.CurrentUser.OpenSubKey("WarzoneOptimizer");
        public about()
        {
            InitializeComponent();
        }
        private void about_Load(object sender, EventArgs e)
        {
            label_Version.Text = String.Format("Current Version : {0}", Application.ProductVersion);
            label_update_status.Text = "Connecting To Server...";
        }
        public void UpdateChecker()
        {
            var AppVersion = new Version(Application.ProductVersion);
            string update_status = RegistryRead.GetValue("checkupdate").ToString();
            if (update_status == "true")
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    XmlDocument data = new XmlDocument();
                    data.Load("https://api.codemage.ir/Projects/WarzoneOptimizer/data.xml");
                    XmlElement root = data.DocumentElement;
                    XmlNodeList nodes = root.SelectNodes("/Data/Application");
                    foreach (XmlNode node in nodes)
                    {
                        string app_id_xml = node["SHA1"].InnerText;
                        var version_xml = new Version(node["last_version"].InnerText);
                        string update_date_xml = node["update_date"].InnerText;
                        string update_url_xml = node["update_url"].InnerText;
                        string update_type = node["update_type"].InnerText;
                        var result = AppVersion.CompareTo(version_xml);
                        url = "https://" + update_url_xml;
                        if (Hasher("WarzoneOptimizer") == app_id_xml)
                        {
                            if (result < 0)
                            {
                                //MessageBox.Show("Update Available", "Update Available");
                                label_update_status.Text = string.Format("{0} {1} Available.", update_type, version_xml);
                                label_download.Visible = true;
                            }
                            else
                            {
                                label_update_status.Text = "Latest Version Installed.";
                            }
                        }
                        else { }
                    }
                }
                catch
                {
                    label_update_status.Text = "Can't Get Data From Server. Click To Retry";
                    label_update_status.Cursor = Cursors.Hand;
                    label_download.Visible = false;
                }
            }
            else
            {
                label_update_status.Text = "Update Disabled By User. \n Enable From System Tray To Access Updates";
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
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            i++;
            if (i == 1)
            {
                try
                {
                    UpdateChecker();
                }
                catch
                {
                    label_update_status.Text = "Checking Update Failed. Click To Retry";
                    label_update_status.Cursor = Cursors.Hand;
                    label_download.Visible = false;
                }
                timer.Enabled = false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start(url);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdateChecker();
        }
    }
}
