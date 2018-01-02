using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace Employee_Management_System
{
    class BaseClass
    {
        public String[] str = new String[4];

        public SqlCeConnection cn = new SqlCeConnection(@"Data Source = G:\31 Term\Database\project\HallManagement.sdf");

        public Boolean createStudent(String studentID, String studentName, String deptName, String residentialRpt, String homeTown ,String bloodGroup) {
            int flag = 0;

            cn.Open();

            SqlCeCommand oSqlCommand = new SqlCeCommand("select * from Student", cn);
            SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

            while (oSqlDataReader.Read())
            {
                    flag = 1;
            }

            if (flag == 0)
            {

                SqlCeCommand sc = new SqlCeCommand("INSERT INTO Student VALUES(@Student_ID,@Student_Name,@Dept_Name,@Residential_Report,@Home_Town,@Blood_Group)", cn);
                sc.Parameters.AddWithValue("@Student_ID", studentID);
                sc.Parameters.AddWithValue("@Student_Name", studentName);
                sc.Parameters.AddWithValue("@Dept_Name", deptName);
                sc.Parameters.AddWithValue("@Residential_Report", residentialRpt);
                sc.Parameters.AddWithValue("@Home_Town", homeTown);
                sc.Parameters.AddWithValue("@Blood_Group", bloodGroup);

                try
                {
                    sc.ExecuteNonQuery();
                }
                catch (Exception){}

                cn.Close();
                return true;
            }

            cn.Close();
            return false;
        }

        public Boolean changePassword(String oldPass, String newPass) {
            int flag = 0;

            cn.Open();

            SqlCeCommand oSqlCommand = new SqlCeCommand("select * from User_Info", cn);
            SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

            while (oSqlDataReader.Read())
            {
                if(oSqlDataReader[4].Equals(oldPass))
                    flag = 1;
            }

            if (flag == 1)
            {
                SqlCeCommand sc = new SqlCeCommand("Update User_Info set password = '" + newPass + "'", cn);

                sc.ExecuteNonQuery();

                cn.Close();
                return true;
            }
            cn.Close();
            return false;
        }

        public Boolean checkUser(String password)
        {
            cn.Open();

            SqlCeCommand oSqlCommand = new SqlCeCommand("select * from User_Info", cn);
            SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

            while (oSqlDataReader.Read())
            {
                if (oSqlDataReader[4].Equals(password)) {
                    for (int i = 0; i < 4; i++) {
                        str[i] = oSqlDataReader[i].ToString();
                    }
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }

        public Boolean updateUser(String fullName, String userName, String email, String mobile, String password) {

            cn.Open();

            SqlCeCommand sc = new SqlCeCommand("Update User_Info set full_name = '" + fullName + "',user_name = '" + userName + "',email = '" + email + "',mobile = '" + mobile + "' where password = '" + password + "'", cn);
            
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

        public Boolean deleteUser(String pass) {
            cn.Open();

            SqlCeCommand sc = new SqlCeCommand("Delete from User_Info where password = '" + pass + "'", cn);
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

        public Boolean logIn(String userName, String password) {
            cn.Open();

            SqlCeCommand oSqlCommand = new SqlCeCommand("select * from User_Info", cn);
            SqlCeDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

            while (oSqlDataReader.Read())
            {
                if (oSqlDataReader[4].Equals(password) && oSqlDataReader[1].Equals(userName))
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }
    }
}
