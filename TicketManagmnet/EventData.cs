using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TicketManagmnet
{
    class EventData
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

        public int ID { set; get; }
        public string EventID { set; get; }
        public string EventName { set; get; }
        public string Type { set; get; }
        public string Price { set; get; }
        public string Capacity { set; get; }
        public string Status { set; get; }
        public string Image { set; get; }
        public string Date { set; get; }

        public List<EventData> eventAvailableListData()
        {
            List<EventData> listData = new List<EventData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM events WHERE event_status  = 'Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EventData eData = new EventData();

                        eData.ID = Convert.ToInt32(reader["id"]);
                        eData.EventID = reader["event_id"].ToString();
                        eData.EventName = reader["event_name"].ToString();
                        eData.Type = reader["type_event"].ToString();
                        eData.Price = reader["price"].ToString();
                        eData.Capacity = reader["capacity"].ToString();
                        eData.Status = reader["event_status"].ToString();
                        eData.Image = reader["event_image"].ToString();
                        listData.Add(eData);

                    }
                }
            }
            return listData;

        }
    }  
    }

