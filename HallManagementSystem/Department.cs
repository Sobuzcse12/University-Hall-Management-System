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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void deptViewBtn_Click(object sender, EventArgs e)
        {
            if (comDeptName.Text != "")
            {
                ConnectionToRoom conroom = new ConnectionToRoom();
                DataTable dt = conroom.deptWiseView(comDeptName.Text);
                deptViewDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show(" You have to select department name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comDeptName.Text = "";
        }

        private void Department_Load(object sender, EventArgs e)
        {
            ConnectionToRoom con = new ConnectionToRoom();
            String[] dt=new String[con.countDept];
            dt = con.lodeDepartment();
           
            //txtdStuId.Items.Add(dt);
            for (int i = 0; i < con.countDept; i++)
            {
                comDeptName.Items.Add(dt[i]);
                comBatchDeptName.Items.Add(dt[i]);
            }
        }

        private void batchViewBtn_Click(object sender, EventArgs e)
        {
            if (comBatchName.Text != "")
            {
                ConnectionToRoom con = new ConnectionToRoom();
                if (comBatchDeptName.Text == "")
                {
                    DataTable dt = con.viewBatch(comBatchName.Text);
                    batchViewDataGridView.DataSource = dt;
                }
                else
                {

                    DataTable dt = con.viewDepartmentAndBatch(comBatchDeptName.Text, comBatchName.Text);
                    batchViewDataGridView.DataSource = dt;
                }
            }else
            {
                MessageBox.Show(" You have to select batch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comBatchName.Text = "";
            comBatchDeptName.Text = "";
    }
    }
}
