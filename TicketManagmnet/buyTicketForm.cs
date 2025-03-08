using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TicketManagmnet
{
    public partial class buyTicketForm: UserControl
    {

        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";
        public buyTicketForm()
        {
            InitializeComponent();

            displayAvailableEvents();

        }
            
        public void displayAvailableEvents()
        {
            EventData eData = new EventData();

            List<EventData> listData = eData.eventAvailableListData();

            dataGridView1.DataSource = listData;
        }
        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                buyTicket_eventID.Text = row.Cells[1].Value.ToString();
                buyTicket_eventName.Text = row.Cells[2].Value.ToString();
                buyTicket_eventType.Text = row.Cells[3].Value.ToString();
                buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();


                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();

            }
        }
        string event_id;
        private void buyTicket_selectEvent_Click(object sender, EventArgs e)
        {

            event_id = buyTicket_eventID.Text.Trim();
            // Ако event_id не е празен, обновяваме списъка със свободни седалки:
            if (!string.IsNullOrEmpty(event_id))
            {
                DisplayAvailableSeats();
            }
        }

        public void DisplayAvailableSeats()
        {
            string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectAvailableSeat = $"SELECT capacity FROM events WHERE delete_date IS NULL AND event_status != 'Deleted' AND event_id = '" + event_id + "'";
                int setAvailable = 0;

                using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connect))
                {

                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();


                    if (reader.Read())
                    {
                        setAvailable = (int)reader["capacity"];
                    }
                    reader.Close();
                }
                if (setAvailable > 0)
                {
                    string selectBookSeats = "SELECT seat_number FROM buy_tickets WHERE event_id = @event_id";
                    List<int> bookSeat = new List<int>();
                    using(SqlCommand cmd = new SqlCommand(selectBookSeats,connect))
                    {
                        cmd.Parameters.AddWithValue("@event_id", event_id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            bookSeat.Add((int)reader["seat_number"]);
                        }
                        reader.Close();

                        List<int> allSeats = Enumerable.Range(1, setAvailable).ToList();

                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));
                        foreach(int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }
                        if(table.Rows.Count>0)
                        {
                            buyTicket_availableSeats.DataSource = table;
                            buyTicket_availableSeats.DisplayMember = "seat_number";
                            buyTicket_availableSeats.ValueMember = "seat_number";

                        }
                        else
                        {
                            buyTicket_availableSeats.DataSource = null;
                        }
                    }
                }
                else
                {
                    buyTicket_availableSeats.DataSource = null;
                }
                    
                    
                }
                
            }

        }
    }
