using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallManagementSystem
{
    class ConnectionToRoom
    {
        public String[] str = new String[10];
        public int count;
        public int countRoom;
        public int countDept;
        public string error = "";
        public SqlCeConnection cn = new SqlCeConnection(@"Data Source = D:\Library\3rd year 1st term\Database System\project\project\HallManagement.sdf");
        public Boolean allotmentOfResidentialStudent(String studentID, String roomNo, String date)
        {
            cn.Open();

            SqlCeCommand sc = new SqlCeCommand("INSERT INTO Residential_Student VALUES(@Student_ID,@Room_No,@Date_Of_Allottment)", cn);
            sc.Parameters.AddWithValue("@Student_ID", studentID);
            sc.Parameters.AddWithValue("@Room_No", roomNo);
            sc.Parameters.AddWithValue("@Date_Of_Allottment", date);
            String residentialRpt = "Residential";
            SqlCeCommand sc1 = new SqlCeCommand("Update Students set Residential_Report = '" + residentialRpt + "' where Student_ID = '" + studentID + "'", cn);
            try
            {
                
               
                sc.ExecuteNonQuery();
                sc1.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                cn.Close();
                throw;
                //error = exp.Message.ToString();
                //return error;
            }

            cn.Close();
            return true;
        }
        public Boolean deleteStudent(String studentId)
        {
            cn.Open();

            SqlCeCommand sc = new SqlCeCommand("Delete from Residential_Student where Student_ID = '" + studentId + "'", cn);
            try
            {
                sc.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

            cn.Close();
            return true;
        }
        public Boolean searchStudentRoom(String roomNo)
        {
            cn.Open();
            try
            {
                SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Residential_Student", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                count = 0;
                while (oSqlDataReader.Read())
                {
                    if (oSqlDataReader[1].Equals(roomNo))
                    {
                       
                            str[count] = oSqlDataReader[0].ToString();

                            count++;

                    }
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

            cn.Close();
            return true;

        }
        public DataTable searchStudentId(String studentId)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Student_ID = '" + studentId + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public String[] lodeRoom()
        {
            try
            {
                String[] strroom = new String[1000];
                cn.Open();
                //SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Room_No FROM Room", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT Room_No FROM Room", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countRoom = 0;
                while (oSqlDataReader.Read())
                {
                    strroom[countRoom] = oSqlDataReader[0].ToString();
                    countRoom++;
                }
                cn.Close();
                return strroom;
            }
            catch
            {
                throw;
            }
        }

        public Boolean addRoom(String roomNo, String floor, String block)
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("INSERT INTO Room VALUES(@Room_No,@Floor,@Block)", cn);
            sc.Parameters.AddWithValue("@Room_No", roomNo);
            sc.Parameters.AddWithValue("@Floor", floor);
            sc.Parameters.AddWithValue("@Block", block);
            try
            {


                sc.ExecuteNonQuery();
               // sc1.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                cn.Close();
                throw;
                //error = exp.Message.ToString();
                //return error;
            }

            cn.Close();
            return true;
        }
        public Boolean addFinancialReport(String studentId, String session, String paidRpt,String paidAmount)
        {
            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("INSERT INTO Financial_Report VALUES(@Student_ID,@Session,@Paid_Report,@Paid_Amount)", cn);
            sc.Parameters.AddWithValue("@Student_ID", studentId);
            sc.Parameters.AddWithValue("@Session", session);
            sc.Parameters.AddWithValue("@Paid_Report", paidRpt);
            sc.Parameters.AddWithValue("@Paid_Amount", paidAmount);
            try
            {


                sc.ExecuteNonQuery();
                // sc1.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                cn.Close();
                throw;
                //error = exp.Message.ToString();
                //return error;
            }

            cn.Close();
            return true;
        }
        public DataTable searchStudentPaidRpt(String studentId)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Financial_Report where Student_ID = '" + studentId + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable deptWiseView(String deptName)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Dept_Name = '" + deptName + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }

        }
        public String[] lodeDepartment()
        {
            try
            {
                String[] strDept = new String[1000];
                cn.Open();
                //SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT Room_No FROM Room", cn);
                SqlCeCommand oSqlCommand = new SqlCeCommand("SELECT distinct Dept_Name FROM Students", cn);
                SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                countDept = 0;
                while (oSqlDataReader.Read())
                {
                    strDept[countDept] = oSqlDataReader[0].ToString();
                    countDept++;
                }
                cn.Close();
                return strDept;
            }
            catch
            {
                throw;
            }
        }
        public DataTable viewDepartmentAndBatch(String deptName, String batch)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Dept_Name = '" + deptName + "' AND Batch = '" + batch + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable viewBatch(String batch)
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM Students where Batch = '" + batch + "'", cn);
                a.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public Boolean updateRoom(String studentID, String newRoom)
        {

            cn.Open();
            SqlCeCommand sc = new SqlCeCommand("Update Residential_Student set Room_No = '" + newRoom + "' where Student_ID = '" + studentID + "'", cn);

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
    }
}