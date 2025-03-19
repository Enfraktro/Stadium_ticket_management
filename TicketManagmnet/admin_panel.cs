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
    public partial class admin_panel: Form
    {
       
        public admin_panel()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Сигурни ли сте, че искате да напунете?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            addeventform1.Hide();
            addstaffsform1.Hide();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            addeventform1.Hide();
            addstaffsform1.Show();
        }

        private void event_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            addeventform1.Show();
            addstaffsform1.Hide();
        }
    }
}
