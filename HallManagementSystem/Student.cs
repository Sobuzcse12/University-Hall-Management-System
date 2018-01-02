using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
//using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace HallManagementSystem
{
    public partial class Student : Form
    {
        public String Printstr;
        Byte[] buffer = new Byte[1000];

        public Student()
        {
            InitializeComponent();
        }


        private void insert_Click(object sender, EventArgs e)
        {
           // Boolean check = false;
            if (txtstudentId.Text.Length == 6 && txtstudentId.Text != "" && txtstudentName.Text != "" && txtdeptName.Text != "" && txtresidenRpt.Text != "" && txthomeTown.Text != "" && txtblood.Text != "" && txtbatch.Text != "" && txtContactNum.Text != "" && StudentPic.Image != null)
            {
                String stuId, stuName, dept, resiRpt, home, blood, batch,contactNum;
                stuId = txtstudentId.Text;
                stuName = txtstudentName.Text;
                dept = txtdeptName.Text;
                resiRpt = txtresidenRpt.Text;
                home = txthomeTown.Text;
                blood = txtblood.Text;
                batch = txtbatch.Text;
                contactNum = txtContactNum.Text;
                Byte[] image = buffer;
                Boolean check = false;
                //  MessageBox.Show(""+stuId+""+stuName+""+dept+""+resiRpt+""+home+""+blood);
                Connection con = new Connection();
                check = con.createStudent(stuId, stuName, dept, resiRpt, home, blood, batch, contactNum, image);
                // check = con.createStudent("120216", "Abbir", "CSE", "Residential", "Khulna", "O+");
                if (check == true)
                    MessageBox.Show("okk");
                else
                    MessageBox.Show("Not okk");
            }
            else if (txtstudentId.Text == "" || txtstudentName.Text == "" || txtdeptName.Text == "" || txtresidenRpt.Text == "" || txthomeTown.Text == "" || txtblood.Text == "" || txtbatch.Text == "" || StudentPic.Image == null)
            {
                MessageBox.Show("You have not fullfiled all information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;//== DialogResult.Yes)
               
            }
            else if (txtstudentId.Text.Length != 6)
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                txtstudentId.Text = "";
                txtstudentName.Text = "";
                txtresidenRpt.Text = "";
                txtdeptName.Text = "";
                txthomeTown.Text = "";
                txtblood.Text = "";
                txtbatch.Text = "";
                txtContactNum.Text = "";
                StudentPic.Image = null;
        }

        private void insertPic_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult userClik = openFileDialog1.ShowDialog();

            if (userClik == DialogResult.OK)
            {
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    try
                    {
                        Image i = Image.FromFile(openFileDialog1.FileName);
                        PictureBox p = StudentPic;

                        if (i.Height > p.Height)
                        {
                            Int32 diff = i.Height - p.Height;
                            Bitmap Resized = new Bitmap(i, new Size(i.Width, i.Height - diff));
                            i = Resized;
                        }
                        if (i.Width > p.Width)
                        {
                            Int32 diff = i.Width - p.Width;
                            Bitmap Resized = new Bitmap(i, new Size(i.Width - diff, i.Height));
                            i = Resized;
                        }

                        StudentPic.Image = i;

                       // MessageBox.Show(reader.ReadLine());
                        Path_label.Text = openFileDialog1.FileName;
                        BinaryReader br = new BinaryReader(fileStream);
                        buffer = br.ReadBytes((Int32)fileStream.Length);
                        br.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This File is not an image type , plz choose an image !!!");
                    }
                }
               
                fileStream.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtdStuId.Text != "" && txtdStuId.Text.Length == 6)
            {
                Boolean check = false;
                String stuId = txtdStuId.Text;
                Connection con = new Connection();
                String[] roll = con.lodeStudentRoll();
                Boolean flag = false;
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
                    /*check = con.deleteStudent(stuId);
                    String[] about = new String[6];
                    about = con.str;
                    txtdstuName.Text = about[0];
                    txtddept.Text = about[1];
                    txtdresiRpt.Text = about[2];
                    txtdhome.Text = about[3];
                    txtdblood.Text = about[4];
                    txtdbatch.Text = about[5];
                    String[] stuContact = new String[con.countContact];
                    stuContact = con.strContact;
                    for (int i = 0; i < con.countContact; i++)
                    {
                        txtdStudentContact.Items.Add(stuContact[i]);
                    }
                    MessageBox.Show("Deleted");*/
                     try
                    {  
                         Connection sp=new Connection();
                         DataTable dt = sp.getInformationOfAStudent(txtdStuId.Text);
                         txtdstuName.Text = dt.Rows[0].Field<string>(1);
                         txtddept.Text = dt.Rows[0].Field<string>(2);
                         txtdresiRpt.Text = dt.Rows[0].Field<string>(3);
                         txtdhome.Text = dt.Rows[0].Field<string>(4);
                         txtdblood.Text = dt.Rows[0].Field<string>(5);
                         txtdbatch.Text = dt.Rows[0].Field<string>(6);
                     /*    if (studentPicBox.Image != null)

                         {
 
                               studentPicBox.Image.Dispose();

                         }
                 FileStream FS1 = new FileStream("image.jpg", FileMode.Create);
                 Byte[] blob = (Byte[])dt.Rows[0].Field<Byte[]>(7);
                 FS1.Write(blob, 0, blob.Length);
                 FS1.Close();
                 FS1 = null;
                 studentPicBox.Image = Image.FromFile("image.jpg");
                 studentPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                 studentPicBox.Refresh();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                }
                else
                {
                    MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    check = con.deleteStudent(stuId);
                    if(check==true)
                        MessageBox.Show("Delete !!!");
                    else
                        MessageBox.Show("Not Delete !!!");

                }
                else
                {
                    // user clicked no
                    MessageBox.Show("Not Delete !!!");
                }
            }
            else
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtdstuName.Text = "";
            txtddept.Text = "";
            txtdresiRpt.Text = "";
            txtdhome.Text = "";
            txtdblood.Text = "";
            txtdbatch.Text = "";
            studentPicBox.Image = null;
        }

       

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (txtustuId.Text != "" && txtustuId.Text.Length==6)
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String stuId, stuName, dept, resiRpt, home, blood, batch;
                    Boolean check = false;
                    stuId = txtustuId.Text;
                    Connection con = new Connection();
                    String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
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
                        stuName = txtustuName.Text;
                        dept = txtudept.Text;
                        resiRpt = txturesiRpt.Text;
                        home = txtuhome.Text;
                        blood = txtublood.Text;
                        batch = txtubatch.Text;

                        check = con.updateStudent(stuId, stuName, dept, resiRpt, home, blood, batch);
                        //if (check == true)
                        MessageBox.Show("Update");
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Not Update !!!");
                }
            }
            else
            {
                MessageBox.Show("Student_ID not selected!!!!!!");
            }
             txtustuId.Text = "";
             txtustuName.Text="";
             txtudept.Text="";
             txturesiRpt.Text="";
             txtuhome.Text="";
             txtublood.Text="";
             txtubatch.Text="";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchItem.Text != "")
            {
                Connection con = new Connection();
                DataTable dt1;
                if (searchItem.Text == "Student ID")
                {
                     String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
                    String stuId=txtsearch.Text;
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
                        //String str = con.searchStudent(txtsearch.Text);
                        //MessageBox.Show(""+str);
                        dt1 = con.searchStudent(txtsearch.Text);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Student_ID");
                        dt.Columns.Add("Student_Name");
                        dt.Columns.Add("Dept_Name");
                        dt.Columns.Add("Residential_Report");
                        dt.Columns.Add("Home_Town");
                        dt.Columns.Add("Blood_Group");
                        dt.Columns.Add("Batch");
                        dt.Columns.Add("Contact_Number");
                        
                        for (int i = 0; i < con.countContact; i++)
                        {
                            DataRow dr = dt.NewRow();
                            
                            
                                dr["Student_ID"] = dt1.Rows[0].Field<string>(0);
                                dr["Student_Name"] = dt1.Rows[0].Field<string>(1);
                                dr["Dept_Name"] = dt1.Rows[0].Field<string>(2);
                                dr["Residential_Report"] = dt1.Rows[0].Field<string>(3);
                                dr["Home_Town"] = dt1.Rows[0].Field<string>(4);
                                dr["Blood_Group"] = dt1.Rows[0].Field<string>(5);
                                dr["Batch"] = dt1.Rows[0].Field<string>(6);
                                dr["Contact_Number"] = dt1.Rows[0].Field<string>(9);
                                dt.Rows.Add(dr);
                        }
                        dataGridViewSearchRes.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (searchItem.Text == "Student Name")
                {
                    String str = txtsearch.Text;
                    
                       dt1 = con.searchStudentName(txtsearch.Text);
                       dataGridViewSearchRes.DataSource = dt1;
                   
                }
                else if (searchItem.Text == "Home Town")
                {
                   /* Boolean flag = false;
                    String str = txtsearch.Text;
                    String[] homeTown = new String[con.countHomeTown];
                    homeTown = con.lodeStudentHomeTown();
                    // home town
                    for (int i = 0; i < con.countHomeTown; i++)
                    {
                        if (str == homeTown[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {*/
                    dt1 = con.searchStudentHomeTown(txtsearch.Text);
                    dataGridViewSearchRes.DataSource = dt1;
                   /* }
                    else
                    {
                        MessageBox.Show(" There is no student at this town's!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                }
                else if (searchItem.Text == "Blood Group")
                {
                    if (txtsearch.Text == "A+" || txtsearch.Text == "A-" || txtsearch.Text == "B+" || txtsearch.Text == "B-" || txtsearch.Text == "AB+" || txtsearch.Text == "AB-" || txtsearch.Text == "O+" || txtsearch.Text == "O-" || txtsearch.Text == "a+" || txtsearch.Text == "a-" || txtsearch.Text == "b+" || txtsearch.Text == "b-" || txtsearch.Text == "ab+" || txtsearch.Text == "ab-" || txtsearch.Text == "aB+" || txtsearch.Text == "aB-" || txtsearch.Text == "Ab+" || txtsearch.Text == "Ab-" || txtsearch.Text == "o+" || txtsearch.Text == "o-")
                    {
                        dt1 = con.searchStudentBloodGroup(txtsearch.Text);
                        dataGridViewSearchRes.DataSource = dt1;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Blood Group !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                 MessageBox.Show(" First you have to fullfiled upper combobox !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           /* String stuID=txtsstuId.Text;
            Connection con = new Connection();
            con.searchStudent(stuID);
            String[] about= new String[6];
            about=con.str;
            txtsstuName.Text = about[0];
            txtsdept.Text = about[1];
            txtsresiRpt.Text = about[2];
            txtshome.Text = about[3];
            txtsblood.Text = about[4];
            txtsbatch.Text = about[5];*/
          /*  try
            {   Connection sp=new Connection();
                DataTable dt = sp.getInformationOfAStudent(txtsstuId.Text);
                txtsstuName.Text = dt.Rows[0].Field<string>(1);
                txtsdept.Text=dt.Rows[0].Field<string>(2);
                txtsresiRpt.Text=dt.Rows[0].Field<string>(3);
                txtshome.Text = dt.Rows[0].Field<string>(4);
                txtsblood.Text = dt.Rows[0].Field<string>(5);
                txtsbatch.Text = dt.Rows[0].Field<string>(6);
                if (studentPicBox.Image != null)

                {
 
                  studentPicBox.Image.Dispose();

                }
                FileStream FS1 = new FileStream("image.jpg", FileMode.Create);



                Byte[] blob = (Byte[])dt.Rows[0].Field<Byte[]>(7);



                FS1.Write(blob, 0, blob.Length);



                FS1.Close();



                FS1 = null;



                studentPicBox.Image = Image.FromFile("image.jpg");



                studentPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                studentPicBox.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/


        }

        private void show_Click(object sender, EventArgs e)
        {
           /* Boolean check = false;
            Connection con = new Connection();
            check= con.showStudent();
            String[,] print = new String[100,7];
            print = con.show;
            if (check == true)
                MessageBox.Show(""+print[0,1]+""+print[1,1]);
            else
                MessageBox.Show("Not Delete !!!");*/
        }

        private void Student_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            String[] roll=new String[con.countRoll];
            roll = con.lodeStudentRoll();
           // Roll Load
            for (int i = 0; i < con.countRoll; i++)
            {
                txtdStuId.Items.Add(roll[i]);
                comafStudentId.Items.Add(roll[i]);
                comafSearchStuId.Items.Add(roll[i]);
                txtustuId.Items.Add(roll[i]);
            }
            String[] batch = new String[con.countBatch];
            batch = con.lodeStudentBatch();
            // Batch load
            for (int i = 0; i < con.countBatch; i++)
            {
                txtbatch.Items.Add(batch[i]);
                txtubatch.Items.Add(batch[i]);
            }
            String[] homeTown = new String[con.countHomeTown];
            homeTown = con.lodeStudentHomeTown();
            // home town
            for (int i = 0; i < con.countHomeTown; i++)
            {
                txthomeTown.Items.Add(homeTown[i]);
                txtuhome.Items.Add(homeTown[i]);
            }
            ConnectionToRoom conroom = new ConnectionToRoom();
            String[] dept = new String[conroom.countDept];
            dept = conroom.lodeDepartment();
            // department load
            for (int i = 0; i < conroom.countDept; i++)
            {
                txtdeptName.Items.Add(dept[i]);
                txtudept.Items.Add(dept[i]);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt = con.showAllStudent();
            showAllDataGridView.DataSource = dt;
            txtStudentAmount.Text = con.countAllStu.ToString();
        }

        private void showNonResiStuBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt = con.showNonResidentialStudent();
            showAllDataGridView.DataSource = dt;
            txtStudentAmount.Text = con.countNonResiStu.ToString();

        }

        private void showResiStuBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt = con.showResidentialStudent();
            showAllDataGridView.DataSource = dt;
            txtStudentAmount.Text = con.countResiStu.ToString();
        }

        private void addFinanRptBtn_Click(object sender, EventArgs e)
        {
            if (comafStudentId.Text.Length == 6 && comafStudentId.Text != "" && comafSession.Text != "" && comafPaidRpt.Text != "" && comafPaidAmount.Text != "")
            {
                    Connection con = new Connection();
                    String[]roll = con.lodeStudentRoll();
                    Boolean flag = false;
                    String stuId=txtsearch.Text;
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
                        Boolean check = conroom.addFinancialReport(comafStudentId.Text, comafSession.Text, comafPaidRpt.Text, comafPaidAmount.Text);
                        if (check == true)
                            MessageBox.Show("Added");
                        else
                            MessageBox.Show("Not Added !!!");
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Student_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else if (comafStudentId.Text == "" || comafSession.Text == "" || comafPaidRpt.Text == "" || comafPaidAmount.Text == "")
            {
                MessageBox.Show("You have not fullfiled all information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//== DialogResult.Yes)

            }
            else if (comafStudentId.Text.Length != 6)
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comafStudentId.Text = "" ;
            comafSession.Text = "";
            comafPaidRpt.Text = "" ;
            comafPaidAmount.Text = "";

        }

        private void showStudentFinanRpt_Click(object sender, EventArgs e)
        {
            if (comafSearchStuId.Text.Length == 6 && comafSearchStuId.Text != "")
            {
                ConnectionToRoom conroom = new ConnectionToRoom();
                DataTable dt = conroom.searchStudentPaidRpt(comafSearchStuId.Text);
                showFinanRptDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show(" Student_ID will be 6 digit !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comafSearchStuId.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();
            DataTable dt = con.showAllStudent();
            String temp="";
            
            for (int i = 0; i < con.countAllStu; i++)
            {
                Printstr = dt.Rows[i].Field<string>(0) + "\t" + dt.Rows[i].Field<string>(1) + "\t" + dt.Rows[i].Field<string>(2) + "\t" + dt.Rows[i].Field<string>(3) + "\t" + dt.Rows[i].Field<string>(4) + "\t" + dt.Rows[i].Field<string>(5) + "\t" + dt.Rows[i].Field<string>(6) + "\n";
                temp = temp + Printstr;
            }
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                // Send a printer-specific to the printer.
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, temp);
            }

        }

        private void addFinancialReport_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void ibackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dbackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void sbackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void abackBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        
        
       

       
    }
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
