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
    public partial class formLogin : Form
    {
        Form1 parent;
        public formLogin()
        {
            InitializeComponent();
            

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            parent = (Form1)this.MdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.showMenuStrip("admin");
            this.Close();

            string username = textBox1.Text;
            string password = textBox2.Text;
        }
    }
}
