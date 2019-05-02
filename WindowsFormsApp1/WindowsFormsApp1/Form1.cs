using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formLogin login = new formLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void showMenuStrip(string jabatan)
        {
            if(jabatan == "admin")
            {
                menuStrip1.Items.Add(new ToolStripMenuItem("Reservation Center"));
                menuStrip1.Items.Add(new ToolStripMenuItem("Administration"));
                menuStrip1.Items.Add(new ToolStripMenuItem("Reservation"));
                menuStrip1.Items.Add(new ToolStripMenuItem("Log Out"));
            }
        }
        
    }
}
