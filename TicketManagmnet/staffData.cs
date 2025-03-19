using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TicketManagmnet
{
    class staffData
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

        public int ID { set; get; }
        public string Username { set; get; }

        public string Password { set; get; }

        public string Role { set; get; }
        public string Status { set; get; }

        public List<staffData> staffDataListData()
        {
            List<staffData> listData = new List<staffData>();

            using(SqlConnection connect = new SqlConnection(conn))
            {

                connect.Open();

                string selectData = "SELECT * FROM users WHERE role = 'Staff' AND status != 'deleted'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        staffData sData = new staffData();

                        sData.ID = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.Role = reader[3].ToString();
                        sData.Status = reader[4].ToString();

                        listData.Add(sData);


                    }
                }

            }
                return listData;

        }
    }
}
