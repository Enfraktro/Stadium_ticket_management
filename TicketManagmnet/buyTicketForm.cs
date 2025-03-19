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

            displayAvailableEvents(event_id);

        }

        public void displayAvailableEvents(string selectedEventID = null)
        {
            EventData eData = new EventData();

            List<EventData> listData = eData.eventAvailableListData();

            if (!string.IsNullOrEmpty(selectedEventID))
            {
                listData = eData.eventAvailableListData().Where(e => e.EventID.ToString() == selectedEventID).ToList();
            }
            else
            {
                listData = eData.eventAvailableListData();
            }
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
                buyTicket_regularPrice.Text = row.Cells[5].Value.ToString();


                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();

            }
        }
        string event_id;
        private void buyTicket_selectEvent_Click(object sender, EventArgs e)
        {

            event_id = buyTicket_eventID.Text.Trim();
            if (!string.IsNullOrEmpty(event_id))
            {
                displayAvailableEvents(event_id);
                dataGridView1.Refresh();
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


        double getTotal = 0;
        private void buyTicket_Calculate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectPrice = "SELECT event_id, price FROM events WHERE event_id = '" + event_id + "'";

                double getPrice = 0;

                using (SqlCommand cmd = new SqlCommand(selectPrice, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        getPrice = reader["price"] != DBNull.Value ? Convert.ToDouble(reader["price"]) : 0;
                        buyTicket_regularPrice.Text = "$" + getPrice.ToString("0.00"); // Добавено!
                    }
                    reader.Close();
                }

                double getFoodPrice = (buyTicket_foods.SelectedIndex == -1) ? 0 : 100;
                double getDrinkPrice = (buyTicket_drinks.SelectedIndex == -1) ? 0 : 50;

                getTotal = (getPrice + getFoodPrice + getDrinkPrice);

                buyTicket_totalPrice.Text = "$" + getTotal.ToString("0.00");

            }
        }
        public void ClearSelected()
        {
 id = 0;
            buyTicket_eventID.Text = "";
            buyTicket_eventName.Text = "";
            buyTicket_eventType.Text = "";
            buyTicket_regularPrice.Text = "";

            pictureBox1.Image = null;
        }

        private void buyTicket_clearEvent_Click(object sender, EventArgs e)
        {
            ClearSelected();
        }

        private void buyTicket_ammount_TextChanged(object sender, EventArgs e)
        {

        }
        double getChange = 0;
        double getAmount = 0;
        private void buyTicket_ammount_Enter(object sender, EventArgs e)
        {
           
        }

        private void buyTicket_ammount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buyTicket_ammount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Моля първо селектирайте събитие и после храна", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (Convert.ToDouble(buyTicket_ammount.Text) >= getTotal)
                        {
                            getChange = Convert.ToDouble(buyTicket_ammount.Text) - getTotal;
                            getAmount = Convert.ToDouble(buyTicket_ammount.Text);
                        }
                        else
                        {
                            MessageBox.Show("Моля въведете сума по-голяма или равна сума на сметката", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getChange = 0;

                        }
                        buyTicket_change.Text = getChange.ToString("$0.00");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Моля въведете само числа", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buyTicket_ammount.Text = "";
                        getAmount = 0;
                    }
                }
            }
        }

        private void buyTicket_buyEvent_Click(object sender, EventArgs e)
        {
          
            if (id == 0 && getTotal == 0)
            {
                MessageBox.Show("Моля първо селектирайте събитие и после храна", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string insertData = "INSERT INTO buy_tickets(event_id, seat_number, price, amount, [change], status, created_at)" + "VALUES(@event_id, @seatNum, @price, @amount, @change, @status, @date)";

                    using(SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@event_id", event_id);
                        cmd.Parameters.AddWithValue("@seatNum", 1);
                        cmd.Parameters.AddWithValue("@price", getTotal);
                        cmd.Parameters.AddWithValue("@amount", getAmount);
                        cmd.Parameters.AddWithValue("@change", getChange);
                        cmd.Parameters.AddWithValue("@status", "PAID");

                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Успешно закупихте своят билет!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ClearSelected();
                        //ClearFields();



                    }
                }
            }
        }
        public void ClearFields()
        {
            buyTicket_availableSeats.SelectedIndex = -1;
            buyTicket_drinks.SelectedIndex = -1;
            buyTicket_foods.SelectedIndex = -1;
            buyTicket_totalPrice.Text = "$0.00";
            buyTicket_ammount.Text = "";
            buyTicket_change.Text = "$0.00";
        }

        private void buyTicket_clearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buyTicket_receipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 10;
            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold); 
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);


            float margin = e.MarginBounds.Top;


            StringFormat aligncenter = new StringFormat();
            aligncenter.Alignment = StringAlignment.Center;
            aligncenter.LineAlignment = StringAlignment.Center;
            string headerText = "Стадион Христо Смирненски";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 3) * colWidth, y, aligncenter);
            count++;
            y += tableMargin;

            string[] header = { "Event_ID", "Име на събитие", "Тип", "Цена" };

            for(int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, aligncenter);
            }
            count++;



            float rSpace = e.MarginBounds.Bottom - y;
            while(rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                for (int q = 0; q < 4; q++) 
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(row.Cells[q].Value?.ToString() ?? "", font, Brushes.Black, e.MarginBounds.Left + (q - 1) * colWidth, y, aligncenter);
                }
                count++;
                rowIndex++;
                if(y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                int labelMargin = (int)Math.Min(rSpace, 200);
                DateTime today = DateTime.Now;


                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------------------",labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Сметката ви е: \t$" + getTotal.ToString("0.00") + "\nСума: \t$" + buyTicket_ammount.Text +
                    "\n\t\t=========\nРесто:\t" + buyTicket_change.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);

                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------------------", labelFont).Width, y);

            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
    }
