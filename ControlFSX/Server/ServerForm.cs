using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Reflection;
using FSUIPC;

namespace Server
{
    public partial class ServerForm : Form
    {
        
        CessnaServer server;
        public ServerForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            server = new CessnaServer(this);
            server.ServerEvent += new CessnaServerEventHandler(server_ServerEvent);
        }

        public void server_ServerEvent(object sender, CessnaServerEventArgs e)
        {
            //throw new NotImplementedException();
            Log.Text += "RESTARTING SERVER\r\n";
            backgroundWorker1.CancelAsync();
            backgroundWorker1.Dispose();
            backgroundWorker1.RunWorkerAsync();
            server = new CessnaServer(this);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Log.Text += "SERVER STOPPED\r\n";
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {
            Log.SelectionStart = Log.Text.Length;
            Log.ScrollToCaret();
            if (Log.Text.Length > 200)
            {
                notifyIcon1.BalloonTipText = Log.Text.Substring(Log.Text.Length - 200);
            }
            else
            {
                notifyIcon1.BalloonTipText = Log.Text;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }

        private void ServerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }


        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyIcon1.ShowBalloonTip(2000);
            }
        }


    }
}
