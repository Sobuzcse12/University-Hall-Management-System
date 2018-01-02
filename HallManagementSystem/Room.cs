using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HallManagementSystem
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (txtRoomStuId.Text.Length == 6 && txtRoomStuId.Text != "" && txtRoomStuRoom.Text != "" && txtRoomDateOfAllot.Text != "")
            {
                    Connection con = new Connection();
                    String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
                    String stuId = txtRoomStuId.Text;
           // Roll Load
                    for (int i = 0; i < con.countRoll; i++)
                    {
                        if (stuId == roll[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                       // String stuId = txtRoomStuId.Text;
                        String stuRoom = txtRoomStuRoom.Text;
                        String date1 = txtRoomDateOfAllot.Text.ToString();
                        ConnectionToRoom conRoom = new ConnectionToRoom();
                        Boolean check = conRoom.allotmentOfResidentialStudent(stuId, stuRoom, date1);
                        /*ConnectionToRoom conRoom = new ConnectionToRoom();
                        Boolean check = conRoom.deleteStudent(stuId);*/

                        if (check == true)
                            MessageBox.Show("okk");
                        else
                            MessageBox.Show("Not okk");
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else if (txtRoomStuId.Text=="" || txtRoomStuRoom.Text=="" || txtRoomDateOfAllot.Text=="")
            {
                MessageBox.Show("You have not fullfiled all information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//== DialogResult.Yes)

            }
            else if (txtRoomStuId.Text.Length != 6)
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtRoomStuId.Text = "" ;
            txtRoomStuRoom.Text = "";
            txtRoomDateOfAllot.Text = "";
        }

        private void roomSearchBtn_Click(object sender, System.EventArgs e)
        {
            if (txtSearchRoom.Text != "")
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                dt.Columns.Add("Student_ID");
                dt.Columns.Add("Student_Name");
                dt.Columns.Add("Dept_Name");
                dt.Columns.Add("Residential_Report");
                dt.Columns.Add("Home_Town");
                dt.Columns.Add("Blood_Group");
                dt.Columns.Add("Batch");

                String roomNo = txtSearchRoom.Text;
                ConnectionToRoom cnroom = new ConnectionToRoom();
                Boolean check = cnroom.searchStudentRoom(roomNo);
                int step = cnroom.count;
                String[] strStuId = new String[step];
                strStuId = cnroom.str;
                for (int i = 0; i < step; i++)
                {
                    dt1 = cnroom.searchStudentId(strStuId[i]);
                    // MessageBox.Show("" + dt1.Rows[i].Field<String>(0));
                    DataRow dr = dt.NewRow();
                    try
                    {
                        dr["Student_ID"] = dt1.Rows[0].Field<string>(0);
                        dr["Student_Name"] = dt1.Rows[0].Field<string>(1);
                        dr["Dept_Name"] = dt1.Rows[0].Field<string>(2);
                        dr["Residential_Report"] = dt1.Rows[0].Field<string>(3);
                        dr["Home_Town"] = dt1.Rows[0].Field<string>(4);
                        dr["Blood_Group"] = dt1.Rows[0].Field<string>(5);
                        dr["Batch"] = dt1.Rows[0].Field<string>(6);
                        //txtRoomStuRoom.Items.Add(dt1.Rows[0].Field<string>(0));
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("" + exp.ToString());
                    }
                    dt.Rows.Add(dr);
                }
                roomDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show(" You have to select one room no !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtSearchRoom.Text = "";
        }

        private void txtRoomStuRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            ConnectionToRoom con = new ConnectionToRoom();
            String[] dt = new String[con.countRoom];
               dt = con.lodeRoom();
               for (int i = 0; i < con.countRoom; i++)
               {
                   txtRoomStuRoom.Items.Add(dt[i]);
                   txtSearchRoom.Items.Add(dt[i]);
                   comruOldRoom.Items.Add(dt[i]);
                   comruNewRoom.Items.Add(dt[i]);
               }
               Connection cn = new Connection();
               String[] rool = new String[cn.countRoll];
               rool = cn.lodeStudentRoll();
               for (int i = 0; i < cn.countRoll; i++)
               {
                   txtRoomStuId.Items.Add(rool[i]);
                   comsrRoomSearch.Items.Add(rool[i]);
                   comruStudentId.Items.Add(rool[i]);
               }
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            if (txtaRoomNo.Text != "" && txtaFloor.Text != "" && txtaBlock.Text != "")
            {
                ConnectionToRoom conRoom = new ConnectionToRoom();
                Boolean check = false;
                check = conRoom.addRoom(txtaRoomNo.Text, txtaFloor.Text, txtaBlock.Text);
                if (check == true)
                    MessageBox.Show("okk");
                else
                    MessageBox.Show("Not okk");
            }
            else
            {
                MessageBox.Show("You have not fullfiled all information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//== DialogResult.Yes)

            }
            txtaRoomNo.Text = "";
            txtaFloor.Text = "";
            txtaBlock.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (comsrRoomSearch.Text != "" && comsrRoomSearch.Text.Length == 6)
            {
                 Connection con = new Connection();
                    String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
                    String stuId = comsrRoomSearch.Text;
           // Roll Load
                    for (int i = 0; i < con.countRoll; i++)
                    {
                        if (stuId == roll[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        DataTable dt1 = con.getFloorAndRoom(comsrRoomSearch.Text);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Student_ID");
                        dt.Columns.Add("Room_No");
                        dt.Columns.Add("Floor");
                        dt.Columns.Add("Block");
                        dt.Columns.Add("Date_Of_Allottment");

                        DataRow dr = dt.NewRow();
                        try
                        {
                            dr["Student_ID"] = dt1.Rows[0].Field<string>(0);
                            dr["Room_No"] = dt1.Rows[0].Field<string>(1);
                            dr["Floor"] = dt1.Rows[0].Field<string>(4);
                            dr["Block"] = dt1.Rows[0].Field<string>(5);
                            dr["Date_Of_Allottment"] = dt1.Rows[0].Field<string>(2);
                        }
                        catch (Exception exp)
                        {
                        }
                        dt.Rows.Add(dr);
                        searchRoomStuDataGridView.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comsrRoomSearch.Text = "";
        }

        private void updateRoom_Click(object sender, EventArgs e)
        {
            if (comruStudentId.Text.Length == 6 && comruStudentId.Text != "" && comruOldRoom.Text != "" && comruNewRoom.Text != "")
            {
                 Connection con = new Connection();
                    String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
                    String stuId = comruStudentId.Text;
           // Roll Load
                    for (int i = 0; i < con.countRoll; i++)
                    {
                        if (stuId == roll[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        ConnectionToRoom conroom = new ConnectionToRoom();
                        Boolean check = conroom.updateRoom(comruStudentId.Text, comruNewRoom.Text);
                        if (check == true)
                            MessageBox.Show("okk");
                        else
                            MessageBox.Show("Not okk");
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else if (comruStudentId.Text == "" || comruOldRoom.Text == "" || comruNewRoom.Text == "")
            {
                MessageBox.Show("You have not fullfiled all information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//== DialogResult.Yes)

            }
            else if (comruStudentId.Text.Length != 6)
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comruStudentId.Text = "" ;
            comruOldRoom.Text = "" ;
            comruNewRoom.Text = "";
        }

        
    }
}
