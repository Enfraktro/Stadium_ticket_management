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

namespace TicketManagmnet
{
    public partial class addstaffsform: UserControl
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

        public addstaffsform()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            staffData sData = new staffData();

            List<staffData> listData = sData.staffDataListData();

            dataGridView1.DataSource = listData;
        }

        private void addstaffsform_Load(object sender, EventArgs e)
        {

        }
        public bool isEmpty()
        {
            if(add_staff_username.Text == "" || add_staff_password.Text == "" || add_staff_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void add_staff_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Празни полета", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();


                    string selectUsername = "SELECT * FROM users WHERE username = @usern";

                    using(SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", add_staff_username.Text.Trim());


                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show(add_staff_username.Text.Substring(0, 1).ToUpper() + add_staff_username.Text.Substring(1) + " вече съществува", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string InsertData = "INSERT INTO users (username, password, role, status, date_reg) VALUES(@usern, @pass, @role, @status, @date)";

                            using(SqlCommand cmd = new SqlCommand(InsertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", add_staff_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", add_staff_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff"); 
                                cmd.Parameters.AddWithValue("@status", add_staff_status.SelectedItem.ToString());

                               DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();


                                MessageBox.Show("Добавено успешно", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }


                    }
                }
            }
        }

        private int getID = 0;
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                getID = (int)row.Cells[0].Value;
                add_staff_username.Text = row.Cells[1].Value.ToString();
                add_staff_password.Text = row.Cells[2].Value.ToString();
                add_staff_status.SelectedItem = row.Cells[4].Value.ToString();

            }

        }

       

        public void clearFields()
        {
            add_staff_username.Text = "";
            add_staff_password.Text = "";
            add_staff_status.SelectedIndex = -1;


        }

        private void add_staff_updateBtn_Click_1(object sender, EventArgs e)
        {
 if (isEmpty())
            {
                MessageBox.Show("Празни полета", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                string selectUsername = "SELECT * FROM users WHERE username = @usern";

                    using(SqlCommand checkUsern = new SqlCommand(selectUsername,connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", add_staff_username.Text.Trim());


                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 2)
                        {
                            MessageBox.Show(add_staff_username.Text.Substring(0, 1).ToUpper() + add_staff_username.Text.Substring(1) + " вече съществува", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string updateData = "UPDATE users SET username = @usern, password = @pass, status = @status WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", add_staff_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", add_staff_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", add_staff_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@id", getID);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Обновени успешно", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }
                    }


                }

            }
        }

        private void add_staff_deleteBtn_Click(object sender, EventArgs e)
        {

            if (isEmpty())
            {
                MessageBox.Show("Празни полета", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                   
                            string updateData = "UPDATE users SET status = @status WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                               
                                cmd.Parameters.AddWithValue("@status", "deleted");
                                cmd.Parameters.AddWithValue("@id", getID);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Изтрити успешно", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        
                    }


                

            }
        }

        private void add_staff_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
