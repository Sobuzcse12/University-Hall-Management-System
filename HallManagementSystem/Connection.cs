using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace HallManagementSystem
{
    class Connection
    {
        public String[] str = new String[6];
        public String[] strContact = new String[5];
        public String[] userPass = new String[2];
        public Byte[] image = new Byte[1000];
        public String[,] show=new String[100,7];
        public int countAllStu;
        public int countResiStu;
        public int countNonResiStu;
        public int countBatch;
        public int countHomeTown;
        public int countContact;
        public string error = "";
        public int countRoll;
        public SqlCeConnection cn = new SqlCeConnection(@"Data Source = D:\Library\3rd year 1st term\Database System\project\project\HallManagement.sdf");
        public Boolean createManagement(String employID, String employDesige, String userName, String password)
        {
            cn.Open();

            SqlCeCommand sc = new SqlCeCommand("INSERT INTO Management VALUES(@Employer_ID,@Designation,@User_Name,@Password)", cn);
            sc.Parameters.AddWithValue("@Employer_ID", employID);
            sc.Parameters.AddWithValue("@Designation", employDesige);
            sc.Parameters.AddWithValue("@User_Name", userName);
            sc.Parameters.AddWithValue("@Password", password);
            try
            {
                sc.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cn.Close();
                // return false;
                throw;
            }
            cn.Close();
            return true;
        }
        public Boolean checkUserPass(String userName, String password)
        {
            cn.Open();
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Management", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

                while (oSqlDataReader.Read())
                {
                    if (oSqlDataReader[2].Equals(userName) && oSqlDataReader[3].Equals(password))
                    {
                        cn.Close();
                        return true;

                    }
                }



            }
            catch (Exception exp)
            {
                cn.Close();
                return false;
               // error = exp.Message.ToString();
                //return error;
            }
            cn.Close();
            return false;
        }
        public Boolean createStudent(String studentID, String studentName, String deptName, String residentialRpt, String homeTown, String bloodGroup, String batch, String studentContact, Byte[] image)
        {

                cn.Open();

                SqlCeCommand sc = new SqlCeCommand("INSERT INTO Students VALUES(@Student_ID,@Student_Name,@Dept_Name,@Residential_Report,@Home_Town,@Blood_Group,@Batch,@Student_Image)", cn);
                sc.Parameters.AddWithValue("@Student_ID", studentID);
                sc.Parameters.AddWithValue("@Student_Name", studentName);
                sc.Parameters.AddWithValue("@Dept_Name", deptName);
                sc.Parameters.AddWithValue("@Residential_Report", residentialRpt);
                sc.Parameters.AddWithValue("@Home_Town", homeTown);
                sc.Parameters.AddWithValue("@Blood_Group", bloodGroup);
                sc.Parameters.AddWithValue("@Batch", batch);
                SqlCeParameter picparameter = new SqlCeParameter();
                picparameter.SqlDbType = SqlDbType.Image;
                picparameter.ParameterName = "Student_Image";
                picparameter.Value = image;
                sc.Parameters.Add(picparameter);
                SqlCeCommand sc1 = new SqlCeCommand("INSERT INTO Student_contact VALUES(@Student_ID,@Contact_Number)", cn);
                sc1.Parameters.AddWithValue("@Student_ID", studentID);
                sc1.Parameters.AddWithValue("@Contact_Number", studentContact);
               /* if (residentialRpt == "Residential")
                {
                    String roomNo = "";
                    DateTime time = DateTime.Now;  
                    SqlCeCommand sc1 = new SqlCeCommand("INSERT INTO Residential_Student VALUES(@Student_ID,@Room_No,@Date_Of_Allottment)", cn);
                    sc1.Parameters.AddWithValue("@Student_ID", studentID);
                    sc1.Parameters.AddWithValue("@Room_No", roomNo);
                    sc1.Parameters.AddWithValue("@Date_Of_Allottment", time.ToString());
                    try
                    {
                        sc1.ExecuteNonQuery();
                    }
                    catch (Exception exp)
                    {
                        cn.Close();
                        //error = exp.Message.ToString();
                        //return error;
                        return false;
                        throw;
                    }

                }*/
               
                try
                {
                    sc.ExecuteNonQuery();
                    sc1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    cn.Close();
                   // return false;
                    throw;
                }
                cn.Close();
                return true;
        }
       
        public DataTable getFloorAndRoom(String studentID) {
            //SqlCeDataReader reader;
            //List<String> list = new List<String>();
            try {
                cn.Open();
                DataTable dt = new DataTable();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Residential_Student AS Re INNER JOIN Room AS R ON Re.Room_No = R.Room_No where Student_ID = '" + studentID + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
               /* reader = cm.ExecuteReader();

                while(reader.Read()){
                    list.Add(reader["*"].ToString());
                }*/

            }catch(Exception exp){
                error = exp.Message.ToString();
                throw;
            }
            
        }
        public DataTable getInformationOfAStudent(String id)
        {
            try
            {
                DataTable dt = new DataTable();
               // con.ConnectionString = constring.getConnection();
              //  if (ConnectionState.Closed == con.State)
                    cn.Open();

                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students WHERE Student_ID = '" + id + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }


        public Boolean deleteStudent(String studentId)
        {
            cn.Open();
            String str1 = "Residential";
            SqlCeCommand sc = new SqlCeCommand("Delete from Students where Student_ID = '" + studentId + "'", cn);
            SqlCeCommand sc2 = new SqlCeCommand("Delete from Student_contact where Student_ID = '" + studentId + "'", cn);
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeCommand oSqlCommand1 = new SqlCeCommand("select * from Student_contact", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                SqlCeDataReader oSqlDataReader1 = oSqlCommand1.ExecuteReader();
                countContact = 0;
                while (oSqlDataReader1.Read())
                {
                    if (oSqlDataReader1[0].Equals(studentId))
                    {
                        strContact[countContact] = oSqlDataReader1[1].ToString();
                        countContact++;
                    }
                  
                }
                while (oSqlDataReader.Read())
                {
                    if (oSqlDataReader[0].Equals(studentId))
                    {
                        for (int i = 1; i < 7; i++)
                        {
                            str[i-1] = oSqlDataReader[i].ToString();
                        }
                        
                       
                    }
                    if (str[2] == str1)
                    {
                        SqlCeCommand sc1 = new SqlCeCommand("Delete from Residential_Student where Student_ID = '" + studentId + "'", cn);
                        try
                        {
                            sc1.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            //cn.Close();
                            //return false;
                            throw;
                        }

            
                    }

                }
                
                sc.ExecuteNonQuery();
                sc2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

            cn.Close();
            return true;

        }
        public DataTable showAllStudent()
        {
            cn.Open();
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countAllStu = 0;
                while (oSqlDataReader.Read())
                {
                    countAllStu = countAllStu + 1;
                }
            }
            catch (Exception ex)
            {
                
               
            }
            

            try
            {
                DataTable dt = new DataTable();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
            

        }
        public DataTable showNonResidentialStudent()
        {
            cn.Open();
            String str = "Non Residential";
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT * FROM Students where Residential_Report = '" + str + "'", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countNonResiStu = 0;
                while (oSqlDataReader.Read())
                {
                    countNonResiStu = countNonResiStu + 1;
                }
            }
            catch (Exception ex)
            {


            }
            try
            {
                DataTable dt = new DataTable();
               
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Residential_Report = '" + str + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable showResidentialStudent()
        {
            cn.Open();
            String str = "Residential";
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT * FROM Students where Residential_Report = '" + str + "'", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countResiStu = 0;
                while (oSqlDataReader.Read())
                {
                    countResiStu = countResiStu + 1;
                }
            }
            catch (Exception ex)
            {


            }
            try
            {
                DataTable dt = new DataTable();
               
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Residential_Report = '" + str + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public Boolean updateStudent(String studentID, String studentName, String deptName, String residentialRpt, String homeTown, String bloodGroup, String batch)
        {

            cn.Open();
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

                while (oSqlDataReader.Read())
                {
                    if (oSqlDataReader[0].Equals(studentID))
                    {
                        for (int i = 1; i < 7; i++)
                        {
                            str[i - 1] = oSqlDataReader[i].ToString();
                        }
                        if(studentName=="")
                            studentName=str[0];
                        if(deptName=="")
                            deptName=str[1];
                        if(residentialRpt=="")
                            residentialRpt=str[2];
                        if(homeTown=="")
                            homeTown=str[3];
                        if(bloodGroup=="")
                            bloodGroup=str[4];
                        if(batch=="")
                            batch=str[5];


                    }
                }

                

            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }
            
            SqlCeCommand sc = new SqlCeCommand("Update Students set Student_Name = '" + studentName + "',Dept_Name = '" + deptName + "',Residential_Report = '" + residentialRpt + "',Home_Town = '" + homeTown + "',Blood_Group = '" + bloodGroup + "',Batch = '" + batch + "' where Student_ID = '" + studentID + "'", cn);

            try
            {
                sc.ExecuteNonQuery();
            }
            catch (Exception)
            {
                cn.Close();
                return false;
            }

            cn.Close();
            return true;
        }
       
        public DataTable searchStudent(String studentId)
        {
           /* cn.Open();
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

                while (oSqlDataReader.Read())
                {
                    if (oSqlDataReader[0].Equals(studentId))
                    {
                        for (int i = 1; i < 7; i++)
                        {
                            str[i - 1] = oSqlDataReader[i].ToString();
                        }
                      //  image = oSqlDataReader[7].;


                    }
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

            cn.Close();
            return true;*/
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                // SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Student_ID = '" + studentId + "'", cn);
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students AS S INNER JOIN Student_contact AS SR ON S.Student_ID = SR.Student_ID where S.Student_ID = '" + studentId + "'", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeCommand oSqlCommand1 = new SqlCeCommand("select * from Student_contact", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                SqlCeDataReader oSqlDataReader1 = oSqlCommand1.ExecuteReader();
                countContact = 0;
                while (oSqlDataReader1.Read())
                {
                    if (oSqlDataReader1[0].Equals(studentId))
                    {
                        strContact[countContact] = oSqlDataReader1[1].ToString();
                        countContact++;
                    }

                }
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch(Exception exp)
            {
                throw;
                //error = exp.Message.ToString();
               // return error;
            }

        }
        public DataTable searchStudentId(String studentId)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
               // SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Student_ID = '" + studentId + "'", cn);
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students AS S INNER JOIN Student_contact AS SR ON S.Student_ID = SR.Student_ID where R.Student_ID = '" + studentId + "'", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Students", cn);
                SqlCeCommand oSqlCommand1 = new SqlCeCommand("select * from Student_contact", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                SqlCeDataReader oSqlDataReader1 = oSqlCommand1.ExecuteReader();
                countContact = 0;
                while (oSqlDataReader1.Read())
                {
                    if (oSqlDataReader1[0].Equals(studentId))
                    {
                        strContact[countContact] = oSqlDataReader1[1].ToString();
                        countContact++;
                    }

                }
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable searchStudentName(String studentName)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Student_Name = '" + studentName + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable searchStudentHomeTown(String studentHomeTown)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Home_Town = '" + studentHomeTown + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable searchStudentBloodGroup(String studentBloodGroup)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Blood_Group = '" + studentBloodGroup + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public String[] lodeStudentRoll()
        {
            try
            {
                String[] strroll = new String[1000];
                cn.Open();
                //SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Room_No FROM Room", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT Student_ID FROM Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countRoll = 0;
                while (oSqlDataReader.Read())
                {
                    strroll[countRoll] = oSqlDataReader[0].ToString();
                    countRoll++;
                }
                cn.Close();
                return strroll;
            }
            catch
            {
                throw;
            }
        }
        public String[] lodeStudentBatch()
        {
            try
            {
                String[] strbatch = new String[1000];
                cn.Open();
                //SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Room_No FROM Room", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT distinct Batch FROM Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countBatch = 0;
                while (oSqlDataReader.Read())
                {
                    strbatch[countBatch] = oSqlDataReader[0].ToString();
                    countBatch++;
                }
                cn.Close();
                return strbatch;
            }
            catch
            {
                throw;
            }
        }
        public String[] lodeStudentHomeTown()
        {
            try
            {
                String[] strhome = new String[1000];
                cn.Open();
                //SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Room_No FROM Room", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT distinct Home_Town FROM Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countHomeTown = 0;
                while (oSqlDataReader.Read())
                {
                    strhome[countHomeTown] = oSqlDataReader[0].ToString();
                    countHomeTown++;
                }
                cn.Close();
                return strhome;
            }
            catch
            {
                throw;
            }
        }

    }
}
