using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        static string myConstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karlos\source\repos\Summative_Pacson-Conding\Summative_Pacson-Conding\MasterFile.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConstr);


        //LOGIN LOGIC =============================================================================================
        public int ValidateLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(myConstr))
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; 
                }
            }
        }
        //LOGIN LOGIC =============================================================================================

        //ADD EQUIPMENT LOGIC =============================================================================================


        public bool AddEquipment(string equipmentName, string equipmentDesc, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(myConstr))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Equipment WHERE EquipmentName = @name AND Description = @description"; // validation bawal dupe pareho name at desc
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@name", equipmentName);
                    checkCmd.Parameters.AddWithValue("@description", equipmentDesc);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        return false;
                    }
                }


                string insertQuery = "INSERT INTO Equipment (EquipmentName, Description, Quantity) VALUES (@name, @description, @quantity)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@name", equipmentName);
                    insertCmd.Parameters.AddWithValue("@description", equipmentDesc);
                    insertCmd.Parameters.AddWithValue("@quantity", quantity);

                    insertCmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        //ADD EQUIPMENT LOGIC =============================================================================================

        //VIEW EQUIPMENT LOGIC =============================================================================================
        public DataTable GetAllEquipment()
        {
            using (SqlConnection conn = new SqlConnection(myConstr))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllEquipment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        //VIEW EQUIPMENT LOGIC =============================================================================================

        //UPDATE EQUIPMENT LOGIC =============================================================================================
        public bool UpdateEquipment(int id, string name, string desc, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(myConstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipmentID", id);
                cmd.Parameters.AddWithValue("@EquipmentName", name);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        //UPDATE EQUIPMENT LOGIC =============================================================================================

        //DELETE EQUIPMENT LOGIC =============================================================================================
        public bool DeleteEquipment(int id)
        {
            using (SqlConnection conn = new SqlConnection(myConstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipmentID", id);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        //DELETE EQUIPMENT LOGIC =============================================================================================

    }
}