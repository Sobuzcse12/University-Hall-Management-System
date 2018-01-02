using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallManagementSystem
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Connection con =new Connection();
            Boolean check=con.checkUserPass(txtName.Text,txtPass.Text);
            if (check==true)
            {
                Home home = new Home();
                home.Show();
           }
            else
           {
                MessageBox.Show(" Worng User Name OR Password");
           }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Management am = new Add_Management();
            am.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn.PerformClick();
            }
        }

       

       
    }
}
