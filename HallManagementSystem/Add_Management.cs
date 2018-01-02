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
    public partial class Add_Management : Form
    {
        public Add_Management()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            Boolean check= con.createManagement(txtEmplyId.Text,txtDesignation.Text,txtUserName.Text,txtPassword.Text);
             if (check == true)
                    MessageBox.Show("okk");
                else
                    MessageBox.Show("Not okk");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
