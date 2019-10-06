namespace Battery
{
    partial class WinBattery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinBattery));
            this.labelBCS = new System.Windows.Forms.Label();
            this.pictureBoxE = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.labelBLP = new System.Windows.Forms.Label();
            this.labelBLR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.linkLabeHelp = new System.Windows.Forms.LinkLabel();
            this.linkLabelMax = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new Battery.ProgressBarEx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBCS
            // 
            this.labelBCS.BackColor = System.Drawing.Color.Transparent;
            this.labelBCS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBCS.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.labelBCS.ForeColor = System.Drawing.Color.White;
            this.labelBCS.Location = new System.Drawing.Point(0, 72);
            this.labelBCS.Name = "labelBCS";
            this.labelBCS.Size = new System.Drawing.Size(308, 34);
            this.labelBCS.TabIndex = 2;
            this.labelBCS.Text = "    Battery Charge Status";
            this.labelBCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBCS.UseCompatibleTextRendering = true;
            // 
            // pictureBoxE
            // 
            this.pictureBoxE.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxE.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxE.Image = global::Battery.Properties.Resources.pC1;
            this.pictureBoxE.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxE.Name = "pictureBoxE";
            this.pictureBoxE.Size = new System.Drawing.Size(15, 72);
            this.pictureBoxE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxE.TabIndex = 3;
            this.pictureBoxE.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxB.Image")));
            this.pictureBoxB.Location = new System.Drawing.Point(15, 0);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(69, 72);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxB.TabIndex = 6;
            this.pictureBoxB.TabStop = false;
            // 
            // labelBLP
            // 
            this.labelBLP.BackColor = System.Drawing.Color.Transparent;
            this.labelBLP.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBLP.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBLP.ForeColor = System.Drawing.Color.White;
            this.labelBLP.Location = new System.Drawing.Point(84, 0);
            this.labelBLP.Name = "labelBLP";
            this.labelBLP.Size = new System.Drawing.Size(63, 72);
            this.labelBLP.TabIndex = 7;
            this.labelBLP.Text = "100%";
            this.labelBLP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBLR
            // 
            this.labelBLR.BackColor = System.Drawing.Color.Transparent;
            this.labelBLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBLR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.labelBLR.Location = new System.Drawing.Point(147, 0);
            this.labelBLR.Name = "labelBLR";
            this.labelBLR.Size = new System.Drawing.Size(161, 72);
            this.labelBLR.TabIndex = 8;
            this.labelBLR.Text = "5 h 30 min";
            this.labelBLR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // linkLabeHelp
            // 
            this.linkLabeHelp.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabeHelp.AutoSize = true;
            this.linkLabeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabeHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabeHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabeHelp.LinkColor = System.Drawing.Color.White;
            this.linkLabeHelp.Location = new System.Drawing.Point(269, 3);
            this.linkLabeHelp.Name = "linkLabeHelp";
            this.linkLabeHelp.Size = new System.Drawing.Size(16, 17);
            this.linkLabeHelp.TabIndex = 13;
            this.linkLabeHelp.TabStop = true;
            this.linkLabeHelp.Text = "?";
            this.linkLabeHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabeHelp.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabeHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeHelp_LinkClicked);
            // 
            // linkLabelMax
            // 
            this.linkLabelMax.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabelMax.AutoSize = true;
            this.linkLabelMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linkLabelMax.LinkColor = System.Drawing.Color.White;
            this.linkLabelMax.Location = new System.Drawing.Point(289, 0);
            this.linkLabelMax.Name = "linkLabelMax";
            this.linkLabelMax.Size = new System.Drawing.Size(16, 18);
            this.linkLabelMax.TabIndex = 14;
            this.linkLabelMax.TabStop = true;
            this.linkLabelMax.Text = "_";
            this.linkLabelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelMax.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabelMax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMax_LinkClicked_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 15;
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabelClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelClose.LinkColor = System.Drawing.Color.White;
            this.linkLabelClose.Location = new System.Drawing.Point(3, -2);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(14, 17);
            this.linkLabelClose.TabIndex = 14;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "x";
            this.linkLabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelClose.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Déveloper par ZAKARAIA NAJIM \r\nDate de création le 10/06/2019\r\nEmail :Zakaria.naj" +
    "im.1996@gmail.com\r\n";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBar1.Location = new System.Drawing.Point(25, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(44, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 100;
            // 
            // WinBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(308, 106);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelMax);
            this.Controls.Add(this.linkLabeHelp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelBLR);
            this.Controls.Add(this.labelBLP);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxE);
            this.Controls.Add(this.labelBCS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(308, 106);
            this.MinimumSize = new System.Drawing.Size(308, 106);
            this.Name = "WinBattery";
            this.Opacity = 0.85D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinBattery";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Resize += new System.EventHandler(this.Winbattery_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBCS;
        private System.Windows.Forms.PictureBox pictureBoxE;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.Label labelBLP;
        private System.Windows.Forms.Label labelBLR;
        private System.Windows.Forms.Timer timer1;
        private ProgressBarEx progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.LinkLabel linkLabeHelp;
        private System.Windows.Forms.LinkLabel linkLabelMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelClose;
    }
}

