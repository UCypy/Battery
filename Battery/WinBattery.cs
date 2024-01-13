using Battery.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms

namespace Battery
{
    public partial class WinBattery : Form
    {
        PowerStatus power = SystemInformation.PowerStatus;
        int powerPercent, timeRemaining;

        public WinBattery()
        {
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Battery", Application.ExecutablePath);
            powerPercent = (int)(power.BatteryLifePercent * 100);
        }
        
        void GetBatteryInfo()
        {
            try
            {
                labelBLP.Text = string.Format("{0}%", (power.BatteryLifePercent * 100));
                ///////////////////////////////////////////////////////////////////////////////////////////////
                powerPercent = (int)(power.BatteryLifePercent * 100);

                if (powerPercent <= 100)
                {
                    progressBar1.Value = powerPercent;
                }
                else
                {
                    progressBar1.Value = 0;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////
                switch (power.PowerLineStatus)
                {
                    case PowerLineStatus.Online:
                        labelBCS.Text = "  Power mode (plugged in): " + power.BatteryChargeStatus.ToString();
                        pictureBoxE.Image = Resources.pC1;
                        break;

                    case PowerLineStatus.Offline:
                        labelBCS.Text = "  Power mode (on battery): " + power.BatteryChargeStatus.ToString();
                        pictureBoxE.Image = null;
                        break;

                    case PowerLineStatus.Unknown:
                        labelBCS.Text = "  Unknown ! : " + power.BatteryChargeStatus.ToString();
                        break;
                }
                /////////////////////////////////////////////////////////////////////////////////////////////
                if (powerPercent <= 20)
                {
                    progressBar1.BackColor = Color.Red;
                    progressBar1.ForeColor = Color.FromArgb(192, 0, 0);
                }
                else
                {
                    progressBar1.BackColor = Color.FromArgb(0, 192, 0);
                    progressBar1.ForeColor = Color.DarkGreen;
                }
                /////////////////////////////////////////////////////////////////////////////////////////////
                timeRemaining = power.BatteryLifeRemaining;

                if (timeRemaining >0)
                {
                    labelBLR.Text = string.Format("{0} remaining", TimeAsString(timeRemaining));
                }
                else
                    labelBLR.Text = "until fully charged...";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private string TimeAsString(int seconds)
        {
            const int SECONDS_PER_MINUTE = 60;
            const int SECONDS_PER_HOUR = 60 * 60;

            if (seconds < 0)
            {
                return "unknown";
            }
            else
            {
                int hours = seconds / SECONDS_PER_HOUR;
                seconds -= hours * SECONDS_PER_HOUR;
                int minutes = seconds / SECONDS_PER_MINUTE;
                seconds -= minutes * SECONDS_PER_HOUR;

                if (hours == 0)
                {
                    return string.Format("{0} minutes", minutes);
                }
                else
                {
                    return string.Format("{0} hours {1} minutes", hours, minutes);
                }
            }
        }
        private void CheckPowerPercentLow()
        {
            try
            {
              if (powerPercent <= 20 && power.PowerLineStatus==PowerLineStatus.Offline)
                {
                    ShowForm();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.low);
                    player.Play();
                    timer2.Stop();
                    timer3.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void CheckPowerPercentFull()
        {
            try
            {
                if (powerPercent >= 95 && power.PowerLineStatus == PowerLineStatus.Online)
                {
                    ShowForm();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.full);
                    player.Play();
                    timer3.Stop();
                    timer2.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void Winbattery_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }
        private void linkLabeHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Show();
            panel1.Location = new Point(0, 22);
            panel1.Size = new Size(308, 82);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Hide();
        }
        private void linkLabelMax_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetBatteryInfo();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            CheckPowerPercentFull();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckPowerPercentLow();
        }
    }
}

               
