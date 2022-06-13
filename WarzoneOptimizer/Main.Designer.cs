namespace WarzoneOptimizer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboveNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belowNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.Label();
            this.MONITOR = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.GPU = new System.Windows.Forms.Label();
            this.label_about = new System.Windows.Forms.Label();
            this.Install_lbl = new System.Windows.Forms.Label();
            this.label_startup = new System.Windows.Forms.Label();
            this.label_priority = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_Warzone_status = new System.Windows.Forms.Label();
            this.label_select_p = new System.Windows.Forms.Label();
            this.label_sturtup = new System.Windows.Forms.Label();
            this.label_help = new System.Windows.Forms.Label();
            this.label_priority_status = new System.Windows.Forms.Label();
            this.label_update_stat = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "app is running in background so it can change warzone\'s priority untill app is ru" +
    "nning.";
            this.notifyIcon.BalloonTipTitle = "Warzone Optimizer Still Running";
            this.notifyIcon.ContextMenuStrip = this.menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Warzone Optimizer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.priorityToolStripMenuItem,
            this.CheckForUpdateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(169, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "Open App";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realtimeToolStripMenuItem,
            this.highToolStripMenuItem,
            this.aboveNormalToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.belowNormalToolStripMenuItem,
            this.lowToolStripMenuItem});
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.priorityToolStripMenuItem.Text = "Priority";
            // 
            // realtimeToolStripMenuItem
            // 
            this.realtimeToolStripMenuItem.CheckOnClick = true;
            this.realtimeToolStripMenuItem.Name = "realtimeToolStripMenuItem";
            this.realtimeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.realtimeToolStripMenuItem.Text = "Realtime";
            this.realtimeToolStripMenuItem.Click += new System.EventHandler(this.RealtimeToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.CheckOnClick = true;
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.HighToolStripMenuItem_Click);
            // 
            // aboveNormalToolStripMenuItem
            // 
            this.aboveNormalToolStripMenuItem.CheckOnClick = true;
            this.aboveNormalToolStripMenuItem.Name = "aboveNormalToolStripMenuItem";
            this.aboveNormalToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboveNormalToolStripMenuItem.Text = "Above normal";
            this.aboveNormalToolStripMenuItem.Click += new System.EventHandler(this.AboveNormalToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.CheckOnClick = true;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.NormalToolStripMenuItem_Click);
            // 
            // belowNormalToolStripMenuItem
            // 
            this.belowNormalToolStripMenuItem.CheckOnClick = true;
            this.belowNormalToolStripMenuItem.Name = "belowNormalToolStripMenuItem";
            this.belowNormalToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.belowNormalToolStripMenuItem.Text = "Below normal";
            this.belowNormalToolStripMenuItem.Click += new System.EventHandler(this.BelowNormalToolStripMenuItem_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.CheckOnClick = true;
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.LowToolStripMenuItem_Click);
            // 
            // CheckForUpdateToolStripMenuItem
            // 
            this.CheckForUpdateToolStripMenuItem.Checked = true;
            this.CheckForUpdateToolStripMenuItem.CheckOnClick = true;
            this.CheckForUpdateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem";
            this.CheckForUpdateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CheckForUpdateToolStripMenuItem.Text = "Check For Update";
            this.CheckForUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(211)))));
            this.minimize.Location = new System.Drawing.Point(753, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 23);
            this.minimize.TabIndex = 23;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MONITOR
            // 
            this.MONITOR.AutoSize = true;
            this.MONITOR.BackColor = System.Drawing.Color.Transparent;
            this.MONITOR.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.MONITOR.ForeColor = System.Drawing.Color.White;
            this.MONITOR.Location = new System.Drawing.Point(177, 135);
            this.MONITOR.Name = "MONITOR";
            this.MONITOR.Size = new System.Drawing.Size(69, 23);
            this.MONITOR.TabIndex = 22;
            this.MONITOR.Text = "Monitor :";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.BackColor = System.Drawing.Color.Transparent;
            this.OS.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.OS.ForeColor = System.Drawing.Color.White;
            this.OS.Location = new System.Drawing.Point(177, 75);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(35, 23);
            this.OS.TabIndex = 21;
            this.OS.Text = "OS :";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.BackColor = System.Drawing.Color.Transparent;
            this.RAM.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.RAM.ForeColor = System.Drawing.Color.White;
            this.RAM.Location = new System.Drawing.Point(177, 165);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(47, 23);
            this.RAM.TabIndex = 20;
            this.RAM.Text = "RAM :";
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.BackColor = System.Drawing.Color.Transparent;
            this.CPU.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.CPU.ForeColor = System.Drawing.Color.White;
            this.CPU.Location = new System.Drawing.Point(177, 45);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(44, 23);
            this.CPU.TabIndex = 19;
            this.CPU.Text = "CPU :";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(211)))));
            this.Exit.Location = new System.Drawing.Point(788, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(19, 23);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GPU
            // 
            this.GPU.AutoSize = true;
            this.GPU.BackColor = System.Drawing.Color.Transparent;
            this.GPU.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.GPU.ForeColor = System.Drawing.Color.White;
            this.GPU.Location = new System.Drawing.Point(177, 105);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(44, 23);
            this.GPU.TabIndex = 17;
            this.GPU.Text = "GPU :";
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.BackColor = System.Drawing.Color.Transparent;
            this.label_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_about.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_about.ForeColor = System.Drawing.Color.White;
            this.label_about.Location = new System.Drawing.Point(375, 441);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(51, 23);
            this.label_about.TabIndex = 37;
            this.label_about.Text = "About";
            this.label_about.Click += new System.EventHandler(this.Label_About_Click);
            // 
            // Install_lbl
            // 
            this.Install_lbl.AutoSize = true;
            this.Install_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Install_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Install_lbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Install_lbl.ForeColor = System.Drawing.Color.White;
            this.Install_lbl.Location = new System.Drawing.Point(559, 259);
            this.Install_lbl.Name = "Install_lbl";
            this.Install_lbl.Size = new System.Drawing.Size(52, 23);
            this.Install_lbl.TabIndex = 38;
            this.Install_lbl.Text = "Install";
            this.Install_lbl.Click += new System.EventHandler(this.Install_lbl_Click);
            // 
            // label_startup
            // 
            this.label_startup.AutoSize = true;
            this.label_startup.BackColor = System.Drawing.Color.Transparent;
            this.label_startup.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_startup.ForeColor = System.Drawing.Color.White;
            this.label_startup.Location = new System.Drawing.Point(177, 259);
            this.label_startup.Name = "label_startup";
            this.label_startup.Size = new System.Drawing.Size(61, 23);
            this.label_startup.TabIndex = 39;
            this.label_startup.Text = "Startup";
            // 
            // label_priority
            // 
            this.label_priority.AutoSize = true;
            this.label_priority.BackColor = System.Drawing.Color.Transparent;
            this.label_priority.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_priority.ForeColor = System.Drawing.Color.White;
            this.label_priority.Location = new System.Drawing.Point(177, 351);
            this.label_priority.Name = "label_priority";
            this.label_priority.Size = new System.Drawing.Size(66, 23);
            this.label_priority.TabIndex = 42;
            this.label_priority.Text = "Priority :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(400, 351);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(60, 23);
            this.label_status.TabIndex = 43;
            this.label_status.Text = "Status :";
            // 
            // label_Warzone_status
            // 
            this.label_Warzone_status.AutoSize = true;
            this.label_Warzone_status.BackColor = System.Drawing.Color.Transparent;
            this.label_Warzone_status.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Warzone_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label_Warzone_status.Location = new System.Drawing.Point(465, 351);
            this.label_Warzone_status.Name = "label_Warzone_status";
            this.label_Warzone_status.Size = new System.Drawing.Size(97, 23);
            this.label_Warzone_status.TabIndex = 45;
            this.label_Warzone_status.Text = "Game Status";
            // 
            // label_select_p
            // 
            this.label_select_p.AutoSize = true;
            this.label_select_p.BackColor = System.Drawing.Color.Transparent;
            this.label_select_p.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_select_p.ForeColor = System.Drawing.Color.White;
            this.label_select_p.Location = new System.Drawing.Point(233, 321);
            this.label_select_p.Name = "label_select_p";
            this.label_select_p.Size = new System.Drawing.Size(0, 23);
            this.label_select_p.TabIndex = 46;
            // 
            // label_sturtup
            // 
            this.label_sturtup.AutoSize = true;
            this.label_sturtup.BackColor = System.Drawing.Color.Transparent;
            this.label_sturtup.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_sturtup.ForeColor = System.Drawing.Color.White;
            this.label_sturtup.Location = new System.Drawing.Point(559, 282);
            this.label_sturtup.Name = "label_sturtup";
            this.label_sturtup.Size = new System.Drawing.Size(0, 23);
            this.label_sturtup.TabIndex = 47;
            // 
            // label_help
            // 
            this.label_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_help.AutoSize = true;
            this.label_help.BackColor = System.Drawing.Color.Transparent;
            this.label_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_help.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(211)))));
            this.label_help.Location = new System.Drawing.Point(719, 9);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(17, 23);
            this.label_help.TabIndex = 48;
            this.label_help.Text = "?";
            this.label_help.Click += new System.EventHandler(this.Label_help_Click);
            // 
            // label_priority_status
            // 
            this.label_priority_status.AutoSize = true;
            this.label_priority_status.BackColor = System.Drawing.Color.Transparent;
            this.label_priority_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_priority_status.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_priority_status.ForeColor = System.Drawing.Color.White;
            this.label_priority_status.Location = new System.Drawing.Point(233, 400);
            this.label_priority_status.Name = "label_priority_status";
            this.label_priority_status.Size = new System.Drawing.Size(0, 23);
            this.label_priority_status.TabIndex = 49;
            // 
            // label_update_stat
            // 
            this.label_update_stat.AutoSize = true;
            this.label_update_stat.BackColor = System.Drawing.Color.Transparent;
            this.label_update_stat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_update_stat.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Bold);
            this.label_update_stat.ForeColor = System.Drawing.Color.White;
            this.label_update_stat.Location = new System.Drawing.Point(353, 464);
            this.label_update_stat.Name = "label_update_stat";
            this.label_update_stat.Size = new System.Drawing.Size(0, 17);
            this.label_update_stat.TabIndex = 50;
            this.label_update_stat.VisibleChanged += new System.EventHandler(this.Label_update_stat_VisibleChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "Above normal",
            "Normal",
            "Below normal",
            "Low"});
            this.comboBox.Location = new System.Drawing.Point(249, 346);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(130, 31);
            this.comboBox.TabIndex = 51;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarzoneOptimizer.Properties.Resources.ui;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label_update_stat);
            this.Controls.Add(this.label_priority_status);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.label_sturtup);
            this.Controls.Add(this.label_select_p);
            this.Controls.Add(this.label_Warzone_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_priority);
            this.Controls.Add(this.label_startup);
            this.Controls.Add(this.Install_lbl);
            this.Controls.Add(this.label_about);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.MONITOR);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warzone Optimizer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label MONITOR;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label GPU;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.Label Install_lbl;
        private System.Windows.Forms.Label label_startup;
        private System.Windows.Forms.Label label_priority;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_Warzone_status;
        private System.Windows.Forms.Label label_select_p;
        private System.Windows.Forms.Label label_sturtup;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem realtimeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem aboveNormalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem belowNormalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.Label label_priority_status;
        private System.Windows.Forms.Label label_update_stat;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

