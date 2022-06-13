namespace WarzoneOptimizer
{
    partial class about
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.Exit = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_update = new System.Windows.Forms.Label();
            this.label_update_status = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_download = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(211)))));
            this.Exit.Name = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label_Version
            // 
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.BackColor = System.Drawing.Color.Transparent;
            this.label_Version.ForeColor = System.Drawing.Color.White;
            this.label_Version.Name = "label_Version";
            // 
            // label_update
            // 
            resources.ApplyResources(this.label_update, "label_update");
            this.label_update.BackColor = System.Drawing.Color.Transparent;
            this.label_update.ForeColor = System.Drawing.Color.White;
            this.label_update.Name = "label_update";
            // 
            // label_update_status
            // 
            resources.ApplyResources(this.label_update_status, "label_update_status");
            this.label_update_status.BackColor = System.Drawing.Color.Transparent;
            this.label_update_status.ForeColor = System.Drawing.Color.White;
            this.label_update_status.Name = "label_update_status";
            this.label_update_status.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_download
            // 
            resources.ApplyResources(this.label_download, "label_download");
            this.label_download.BackColor = System.Drawing.Color.Transparent;
            this.label_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_download.ForeColor = System.Drawing.Color.White;
            this.label_download.Name = "label_download";
            this.label_download.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_copyright
            // 
            resources.ApplyResources(this.label_copyright, "label_copyright");
            this.label_copyright.BackColor = System.Drawing.Color.Transparent;
            this.label_copyright.ForeColor = System.Drawing.Color.White;
            this.label_copyright.Name = "label_copyright";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // about
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarzoneOptimizer.Properties.Resources.about_ui;
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_download);
            this.Controls.Add(this.label_update_status);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "about";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.about_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_download;
        private System.Windows.Forms.Label label_copyright;
        public System.Windows.Forms.Label label_update_status;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}