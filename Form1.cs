using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TicketManagmnet
{
    public partial class Form1: Form
    {
        string conn = @"Data Source=localhost\SQLEXPRESS01;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();

            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if(login_userName.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Моля въведете информацията във всички празни полета", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_userName.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {

                            string role = table.Rows[0]["role"].ToString();

                            MessageBox.Show("Влизането е успешно", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (role == "Admin")
                            {

                                admin_panel Apanel = new admin_panel();
                                Apanel.Show();

                            }
                            else if (role == "Staff")
                            {
                                staffMainForm sFor = new staffMainForm();
                                sFor.Show();
                            }


                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неправилно въведена парола или потребителско име", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }
    }
}
