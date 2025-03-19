using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagmnet
{
    public partial class staffMainForm: Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Сигурни ли сте, че искате да напсунете?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit(); 

            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyTicketForm1.Show();
            dashboard1.Hide();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            buyTicketForm1.Hide();
            dashboard1.Show();

        }
    }
}
