using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace TicketManagmnet
{
    public partial class addeventform: UserControl
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

        public addeventform()
        {
            InitializeComponent();
            displayData();
        }   

       
        public void displayData()
        {
            EventData eData = new EventData();

            List<EventData> listData = eData.eventAvailableListData();

            dataGridView1.DataSource = listData;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addevent_importBtn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog file = new OpenFileDialog();

                string imagePath = "";

                file.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if(file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addevent_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkID = "SELECT event_id FROM events WHERE event_id = @eventID";

                    using(SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@eventID", addevent_eventID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count>0)
                        {
                            MessageBox.Show($"Event ID: " + addevent_eventID.Text.Trim() + " е заето вече", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string InsertData = "INSERT INTO events (event_id, event_name, type_event, price, capacity,event_image, event_status, created_at)"
                                + "VALUES (@eventID, @eventName,@event_Type, @price, @capacity, @eventImage ,@status, @date)";

                            string path = Path.Combine(@"C:\Users\nikol\source\repos\TicketManagmnet\TicketManagmnet\event_directory\" + addevent_eventID.Text.Trim() + ".jpg");


                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using(SqlCommand cmd = new SqlCommand(InsertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@eventID", addevent_eventID.Text.Trim());
                                cmd.Parameters.AddWithValue("@eventName", addevent_eventName.Text.Trim());
                                cmd.Parameters.AddWithValue("@event_Type", addevent_type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addevent_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@capacity", addevent_capacity.Text.Trim());
                                cmd.Parameters.AddWithValue("@eventImage", path);
                                cmd.Parameters.AddWithValue("@status", add_Event_Status.SelectedItem.ToString());


                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date",today);


                                cmd.ExecuteNonQuery();


                                displayData();


                                MessageBox.Show("Добавен успешно", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                            }

                        }

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clearFields()
        {
            addevent_eventID.Text = "";
            addevent_eventName.Text = "";
            addevent_type.SelectedIndex = -1;
            addevent_price.Text = "";
            addevent_capacity.Text = "";
            pictureBox1.Image = null;
            add_Event_Status.SelectedIndex = -1;
        }

        private void addevent_addClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private int id = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex != 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                addevent_eventID.Text = row.Cells[1].Value.ToString();
                addevent_eventName.Text = row.Cells[2].Value.ToString();
                addevent_type.Text = row.Cells[3].Value.ToString();
                addevent_price.Text = row.Cells[4].Value.ToString();
                addevent_capacity.Text = row.Cells[5].Value.ToString();
                add_Event_Status.Text = row.Cells[6].Value.ToString();



                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();

            }

        }

        private void addevent_addUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Сигурни ли сте,че искате да обновите ID:"+addevent_eventID.Text + "?", "Confirmation message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkID = "SELECT COUNT(id) FROM events WHERE event_id = @eventID";

                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@eventID", addevent_eventID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show($"Event ID: " + addevent_eventID.Text.Trim() + " е заето вече", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string updateData = "UPDATE events SET event_id = @eventID, event_name = @eventName, type_event = @type, price = @price, capacity=@capacity, event_status =@status, update_date = @updateDate WHERE id = @id";




                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@eventID", addevent_eventID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@eventName", addevent_eventName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", addevent_type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@price", addevent_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@capacity", addevent_capacity.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", add_Event_Status.SelectedItem.ToString());


                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@updateDate", today);
                                    cmd.Parameters.AddWithValue("@id", id);



                                    cmd.ExecuteNonQuery();


                                    displayData();


                                    MessageBox.Show("Обновено успешно", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                }

                            }

                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addevent_addDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Сигурни ли сте,че искате да изтриете ID:" + addevent_eventID.Text + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();


                        string deleteData = "UPDATE events SET delete_date = @deleteDate, event_status=@status WHERE id = @id";




                                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        { 
                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@deleteDate", today);
                                    cmd.Parameters.AddWithValue("@status", "Deleted");
                                    cmd.Parameters.AddWithValue("@id", id);



                                    cmd.ExecuteNonQuery();


                                    displayData();


                                    MessageBox.Show("Обновено успешно", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                }

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addeventform_Load(object sender, EventArgs e)
        {

        }
    }
}
