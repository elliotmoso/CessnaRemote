using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql;
using DatabaseLibrary;

namespace Cessna_Panel
{
    public partial class Touchdown : Form
    {
        Cessna_Control main;
        public Touchdown(Cessna_Control _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Connection.OpenConnection();
            string con = "INSERT INTO concursantes (pilot,score,email,tel) values ('" + name.Text + "','" + vspeed.Text + "','" + email.Text + "','" + tel.Text + "')";
            main.Connection.MySQLQuery(con);
            main.ranking_grid.DataSource = null;
            if (main.adminToolStripMenuItem.Checked)
            {
                main.ranking_grid.DataSource = main.Connection.MySQLQuery("SELECT pilot AS 'Piloto' ,score AS 'Puntuacion' ,email as 'Email' , tel as 'Tel'FROM concursantes ORDER BY score DESC");
            }
            else
            {
                main.ranking_grid.DataSource = main.Connection.MySQLQuery("SELECT pilot AS 'Piloto' ,score AS 'Puntuación' FROM concursantes ORDER BY score DESC");
            }
            main.Connection.Close();
            this.Close();
        }

        private void Touchdown_Load(object sender, EventArgs e)
        {
            vspeed.Text = main.vert_speed.Text;
        }
    }
}
