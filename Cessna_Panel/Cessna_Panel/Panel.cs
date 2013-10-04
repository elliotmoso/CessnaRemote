using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using MySql;
using DatabaseLibrary;

namespace Cessna_Panel
{
    public partial class Cessna_Control : Form
    {
        public MySQL Connection;
        Boolean[] State = new Boolean[6];
        Boolean restarting = false;
        Boolean paused = true;

        public Cessna_Control()
        {
            InitializeComponent();
            try
            {
                Connection = new MySQL("elliotmoso.com", "3306", "elliot_concurso", "elliot_concurso", "cessnaupc");
            }
            catch { }
        }

        //Menu Methods
        private void listOfFailuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter W = new StreamWriter(SaveTxt.FileName);
                    int i = 0;
                    while (i < fail_grid.Rows.Count-1)
                    {
                        W.WriteLine(fail_grid.Rows[i].Cells[0].Value + "#" + fail_grid.Rows[i].Cells[1].Value + "#" + fail_grid.Rows[i].Cells[2].Value);
                        i++;
                    }
                    MessageBox.Show("List of failures saved", "List of failures", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    W.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private void loadFailureListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string F_url = OpenTxt.FileName;
                    StreamReader F = new StreamReader(F_url);
                    String Line = F.ReadLine();
                    while (Line != null)
                    {
                        fail_grid.Rows.Add(Line.Split('#')[0], Line.Split('#')[1], Line.Split('#')[2]);
                        Line = F.ReadLine();
                    }
                    F.Close();
                }
                catch(Exception Err)
                {
                    MessageBox.Show(Err.Message);
                }
            }
        }

        //Connection Methods  
        private void fail_grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show(fail_grid.SelectedRows[0].Cells[2].Value + "?", "Sending an event", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new Connection(get_ip(), fail_grid.SelectedRows[0].Cells[0].Value.ToString(), "0", fail_grid.SelectedRows[0].Cells[2].Value.ToString());
            }
        } //Sending an event to FSUIPC

        //Timers
        private void flaps_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                new Connection(get_ip(), "0BDC", "0", flaps_bar.Value.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void leftleak_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int actualfuel = Convert.ToInt32(new Connection(get_ip(), "0B7C", "request", "0").answer);
                if (actualfuel >= leftleak_bar.Value / 120)
                {
                    new Connection(get_ip(), "0B7C", "0", (actualfuel - leftleak_bar.Value / 120).ToString());
                    //new Connection(ip, "0B7C", "0", leftleak_bar.Value.ToString());
                }
                else
                {
                    new Connection(get_ip(), "0B7C", "0", "0");
                    leftleak_timer.Enabled = false;
                    leftleak_box.Checked = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void rightleak_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int actualfuel = Convert.ToInt32(new Connection(get_ip(), "0B94", "request", "0").answer);
                if (actualfuel >= rightleak_bar.Value / 120)
                {
                    new Connection(get_ip(), "0B94", "0", (actualfuel - rightleak_bar.Value / 120).ToString());
                }
                else
                {

                    new Connection(get_ip(), "0B94", "0", "0");
                    rightleak_timer.Enabled = false;
                    oiltempincrease_box.Checked = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void failure_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            try
            {
                new Connection(get_ip(), ch.Tag.ToString(), "0", Convert.ToInt32(ch.CheckState).ToString());
            }
            catch(Exception err)
            {
              MessageBox.Show(err.Message);  
            }
        }
        private void freqtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string freq = (setcom_box.Text.Split('.')[0] + setcom_box.Text.Split('.')[1]).Substring(1);
                new Connection(get_ip(), "034E", "HEX", freq);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void vert_speed_timer_Tick(object sender, EventArgs e)
        {

            try
            {
                string Songround = new Connection(get_ip(), "0366", "request", "HEX").answer;
                int onground = Convert.ToInt32(Songround);
                if (onground == 0)
                {
                    int vs_touchdown = Convert.ToInt32(new Connection(get_ip(), "030C", "request", "0").answer);
                    vert_speed.Text = vs_touchdown.ToString();
                }
                else if(onground ==1)
                {
                    if (Flying.Checked && vert_speed.Text !="0")
                    {
                        vert_speed.ForeColor = Color.Red;
                        vert_speed_timer.Enabled = false;
                        vert_speed_aircheck.Enabled = true;
                        vert_speed_aircheck.Interval = 30000;
                        new Touchdown(this).ShowDialog();
                        ranking_grid.DataSource = null;
                        ranking_grid.DataSource = Connection.MySQLQuery("SELECT pilot AS 'Piloto' ,score AS 'Puntuación' FROM concursantes ORDER BY score DESC");
                        Flying.Checked = false;
                        button1.Enabled = true;
                    }
                   
                }
            }
            catch
            {
                //MessageBox.Show(err.Message);
            }
        }

        private void vert_speed_aircheck_Tick(object sender, EventArgs e)
        {
            int onground = Convert.ToInt32(new Connection(get_ip(), "0366", "request", "HEX").answer);
            vert_speed_aircheck.Interval = 500;
            if (onground == 0 && vert_speed_timer.Enabled == false)
            {
                vert_speed.ForeColor = Color.Black;
                vert_speed_aircheck.Enabled = false;
                vert_speed_timer.Enabled = true;
            }
        }

        //Leaks, flaps and things with bars   
        private void setcom_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (Convert.ToInt32(ch.CheckState) == 1)
            {
                freq_timer.Enabled = true;
            }
            else
            {
                freq_timer.Enabled = false;
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (Convert.ToInt32(ch.CheckState) == 1)
            {
                flaps_timer.Enabled = true;
            }
            else
            {
                flaps_timer.Enabled = false;
            }
        }
        private void leftleak_box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (Convert.ToInt32(ch.CheckState) == 1)
            {
                leftleak_timer.Enabled = true;
            }
            else
            {
                leftleak_timer.Enabled = false;
            }
        }
        private void rightleak_box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (Convert.ToInt32(ch.CheckState) == 1)
            {
                rightleak_timer.Enabled = true;
            }
            else
            {
                rightleak_timer.Enabled = false;
            }

        }

        private void BDUpdate_Tick(object sender, EventArgs e)
        {
            BDUpdate.Interval = 60000;
            Connection.OpenConnection();
            ranking_grid.DataSource = null;
            if (adminToolStripMenuItem.Checked)
            {
                ranking_grid.DataSource = Connection.MySQLQuery("SELECT pilot AS 'Piloto' ,score AS 'Puntuacion' ,email as 'Email' , tel as 'Tel' FROM concursantes ORDER BY score DESC");
            }
            else
            {
                ranking_grid.DataSource = Connection.MySQLQuery("SELECT pilot AS 'Piloto' ,score AS 'Puntuacion' FROM concursantes ORDER BY score DESC");
            }
                Connection.Close();
        }

        private void RestartServer_Tick(object sender, EventArgs e)
        {
            if (restarting == false)
            {
                if (freq_timer.Enabled)
                {
                    State[0] = true;
                }
                else
                {
                    State[0] = false;
                }
                if (flaps_timer.Enabled)
                {
                    State[1] = true;
                }
                else
                {
                    State[1] = false;
                }
                if (leftleak_timer.Enabled)
                {
                    State[2] = true;
                }
                else
                {
                    State[2] = false;
                }
                if (rightleak_timer.Enabled)
                {
                    State[3] = true;
                }
                else
                {
                    State[3] = false;
                }
                if (vert_speed_timer.Enabled)
                {
                    State[4] = true;
                }
                else
                {
                    State[4] = false;
                }
                if (vert_speed_aircheck.Enabled)
                {
                    State[5] = true;
                }
                else
                {
                    State[5] = false;
                }
                freq_timer.Enabled = false;
                flaps_timer.Enabled = false;
                leftleak_timer.Enabled = false;
                rightleak_timer.Enabled = false;
                vert_speed_timer.Enabled = false;
                vert_speed_aircheck.Enabled = false;
                try
                {
                    new Connection(get_ip(), "RESTART", "request", "HEX");
                }
                catch { }
                RestartServer.Stop();
                RestartServer.Start();
                restarting = true;
            }
            else
            {
                RestartServer.Interval = Convert.ToInt32(toolStripTextBox2.Text) * 1000;
                RestartServer.Stop();
                RestartServer.Start();
                freq_timer.Enabled = State[0];
                flaps_timer.Enabled = State[1];
                leftleak_timer.Enabled = State[2];
                rightleak_timer.Enabled = State[3];
                vert_speed_timer.Enabled = State[4];
                vert_speed_aircheck.Enabled = State[5];
                restarting = false;
            }
            
        }
        void pauseTimers()
        {
            
        }

        string get_ip()
        {
            return toolStripip2.Text;
        }

        private void toolStripip2_Leave(object sender, EventArgs e)
        {
            if (toolStripip2.Focused)
            {
                if (freq_timer.Enabled)
                {
                    State[0] = true;
                }
                else
                {
                    State[0] = false;
                }
                if (flaps_timer.Enabled)
                {
                    State[1] = true;
                }
                else
                {
                    State[1] = false;
                }
                if (leftleak_timer.Enabled)
                {
                    State[2] = true;
                }
                else
                {
                    State[2] = false;
                }
                if (rightleak_timer.Enabled)
                {
                    State[3] = true;
                }
                else
                {
                    State[3] = false;
                }
                if (vert_speed_timer.Enabled)
                {
                    State[4] = true;
                }
                else
                {
                    State[4] = false;
                }
                if (vert_speed_aircheck.Enabled)
                {
                    State[5] = true;
                }
                else
                {
                    State[5] = false;
                }
                freq_timer.Enabled = false;
                flaps_timer.Enabled = false;
                leftleak_timer.Enabled = false;
                rightleak_timer.Enabled = false;
                vert_speed_timer.Enabled = false;
                vert_speed_aircheck.Enabled = false;

                paused = true;
            }
            else
            {

                freq_timer.Enabled = State[0];
                flaps_timer.Enabled = State[1];
                leftleak_timer.Enabled = State[2];
                rightleak_timer.Enabled = State[3];
                vert_speed_timer.Enabled = State[4];
                vert_speed_aircheck.Enabled = State[5];
                paused = false;
            }
        }

        private void Cessna_Control_Load(object sender, EventArgs e)
        {
            toolStripip2.Focus();
            toolStripTextBox2.Text = (RestartServer.Interval / 1000).ToString();
        }

        private void startRecivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vert_speed_timer.Enabled)
            {
                Flying.Checked = false;
                button1.Enabled = true;
                startRecivingToolStripMenuItem.Text = "Start Recieving";
            }
            else
            {
                Flying.Checked = true;
                button1.Enabled = false;
                startRecivingToolStripMenuItem.Text = "Stop Recieving";
            }
            vert_speed_timer.Enabled = !vert_speed_timer.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flying.Checked = true;
            button1.Enabled = false;
            startRecivingToolStripMenuItem.Text = "Stop Recieving";
            vert_speed_timer.Enabled = true;
        }

        private void loadUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vert_speed.Text = "-99999";
            new Touchdown(this).ShowDialog();
        }

        private void debugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!debugToolStripMenuItem.Enabled)
            {
                debugModeToolStripMenuItem.Checked = true;
                debugToolStripMenuItem.Enabled = true;
            }
            else
            {
                debugModeToolStripMenuItem.Checked = false;
                debugToolStripMenuItem.Enabled = false;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminToolStripMenuItem.Checked = !adminToolStripMenuItem.Checked;
            BDUpdate_Tick(sender, e);
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RestartServer.Interval = Convert.ToInt32(toolStripTextBox2.Text) * 1000;
            }
            catch {
                toolStripTextBox2.Text = (RestartServer.Interval / 1000).ToString();
            }
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartServer.Enabled = !RestartServer.Enabled;
            autoToolStripMenuItem.Checked = !RestartServer.Enabled;

        }



    }
}
