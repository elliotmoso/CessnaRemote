using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        client client = new client();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new client();
            textBox1.Text = client.Connect("127.0.0.1",7700);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text+="\n"+client.Send("0B62 1 1");
        }
    }
}
