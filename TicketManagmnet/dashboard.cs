using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TicketManagmnet
{
    public partial class dashboard: UserControl
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

 

        public dashboard()
        {
            InitializeComponent();

            displayAvailableEvents();
            displayTotalStaff();
            displayTotalBuys();
            displayTotalIncome();
            displayAETable();
        }

        public void displayAETable()
        {
            EventData eData = new EventData();

            List<EventData> listData = eData.eventAvailableListData();

            dataGridView1.DataSource = listData;
        }

        public void displayAvailableEvents()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as avEvents FROM events WHERE event_status = 'Available'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        if (reader["avEvents"] != DBNull.Value)
                        {
                            decimal totalAVEvents = Convert.ToDecimal(reader["avEvents"]);

                            dashboard_AE.Text = totalAVEvents.ToString();
                        }
                    }
                }
            }

        }
        public void displayTotalStaff()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalStaff FROM users WHERE role = 'staff' AND status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalStaff"] != DBNull.Value)
                        {
                            decimal totalStaff = Convert.ToDecimal(reader["totalStaff"]);

                            dashboard_TS.Text = totalStaff.ToString();
                        }
                    }
                }
            }

        }
        public void displayTotalBuys()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalBuys FROM buy_tickets WHERE  status = 'Paid'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalBuys"] != DBNull.Value)
                        {
                            decimal totalBuys = Convert.ToDecimal(reader["totalBuys"]);

                            dashboard_sales.Text = totalBuys.ToString();
                        }
                    }
                }
            }

        }
        public void displayTotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) as totalIncome FROM buy_tickets WHERE  status = 'Paid'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalIncome"] != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["totalIncome"]);

                            dashboard_TI.Text = "$" + totalIncome.ToString("0.00");
                        }
                    }
                }
            }

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
