namespace TicketManagmnet
{
    partial class addstaffsform
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_staff_clearBtn = new System.Windows.Forms.Button();
            this.add_staff_deleteBtn = new System.Windows.Forms.Button();
            this.add_staff_updateBtn = new System.Windows.Forms.Button();
            this.add_staff_addBtn = new System.Windows.Forms.Button();
            this.add_staff_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_staff_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_staff_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(278, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 523);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 466);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(11, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Всички служители";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.add_staff_clearBtn);
            this.panel1.Controls.Add(this.add_staff_deleteBtn);
            this.panel1.Controls.Add(this.add_staff_updateBtn);
            this.panel1.Controls.Add(this.add_staff_addBtn);
            this.panel1.Controls.Add(this.add_staff_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.add_staff_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.add_staff_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 523);
            this.panel1.TabIndex = 2;
            // 
            // add_staff_clearBtn
            // 
            this.add_staff_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.add_staff_clearBtn.Font = new System.Drawing.Font("Arial", 7.8F);
            this.add_staff_clearBtn.ForeColor = System.Drawing.Color.Black;
            this.add_staff_clearBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_staff_clearBtn.Location = new System.Drawing.Point(116, 431);
            this.add_staff_clearBtn.Name = "add_staff_clearBtn";
            this.add_staff_clearBtn.Size = new System.Drawing.Size(92, 55);
            this.add_staff_clearBtn.TabIndex = 15;
            this.add_staff_clearBtn.Text = "Изчисти";
            this.add_staff_clearBtn.UseVisualStyleBackColor = false;
            this.add_staff_clearBtn.Click += new System.EventHandler(this.add_staff_clearBtn_Click);
            // 
            // add_staff_deleteBtn
            // 
            this.add_staff_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.add_staff_deleteBtn.Font = new System.Drawing.Font("Arial", 7.8F);
            this.add_staff_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.add_staff_deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_staff_deleteBtn.Location = new System.Drawing.Point(5, 431);
            this.add_staff_deleteBtn.Name = "add_staff_deleteBtn";
            this.add_staff_deleteBtn.Size = new System.Drawing.Size(88, 55);
            this.add_staff_deleteBtn.TabIndex = 14;
            this.add_staff_deleteBtn.Text = "Изтрий";
            this.add_staff_deleteBtn.UseVisualStyleBackColor = false;
            this.add_staff_deleteBtn.Click += new System.EventHandler(this.add_staff_deleteBtn_Click);
            // 
            // add_staff_updateBtn
            // 
            this.add_staff_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.add_staff_updateBtn.Font = new System.Drawing.Font("Arial", 7.8F);
            this.add_staff_updateBtn.ForeColor = System.Drawing.Color.Black;
            this.add_staff_updateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_staff_updateBtn.Location = new System.Drawing.Point(116, 368);
            this.add_staff_updateBtn.Name = "add_staff_updateBtn";
            this.add_staff_updateBtn.Size = new System.Drawing.Size(92, 57);
            this.add_staff_updateBtn.TabIndex = 13;
            this.add_staff_updateBtn.Text = "Обнови";
            this.add_staff_updateBtn.UseVisualStyleBackColor = false;
            this.add_staff_updateBtn.Click += new System.EventHandler(this.add_staff_updateBtn_Click_1);
            // 
            // add_staff_addBtn
            // 
            this.add_staff_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.add_staff_addBtn.Font = new System.Drawing.Font("Arial", 7.8F);
            this.add_staff_addBtn.ForeColor = System.Drawing.Color.Black;
            this.add_staff_addBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_staff_addBtn.Location = new System.Drawing.Point(5, 368);
            this.add_staff_addBtn.Name = "add_staff_addBtn";
            this.add_staff_addBtn.Size = new System.Drawing.Size(88, 57);
            this.add_staff_addBtn.TabIndex = 12;
            this.add_staff_addBtn.Text = "Добави";
            this.add_staff_addBtn.UseVisualStyleBackColor = false;
            this.add_staff_addBtn.Click += new System.EventHandler(this.add_staff_addBtn_Click);
            // 
            // add_staff_status
            // 
            this.add_staff_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_staff_status.FormattingEnabled = true;
            this.add_staff_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.add_staff_status.Location = new System.Drawing.Point(5, 282);
            this.add_staff_status.Name = "add_staff_status";
            this.add_staff_status.Size = new System.Drawing.Size(202, 28);
            this.add_staff_status.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Статус";
            // 
            // add_staff_password
            // 
            this.add_staff_password.Location = new System.Drawing.Point(4, 189);
            this.add_staff_password.Name = "add_staff_password";
            this.add_staff_password.Size = new System.Drawing.Size(204, 22);
            this.add_staff_password.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Парола";
            // 
            // add_staff_username
            // 
            this.add_staff_username.Location = new System.Drawing.Point(4, 96);
            this.add_staff_username.Name = "add_staff_username";
            this.add_staff_username.Size = new System.Drawing.Size(204, 22);
            this.add_staff_username.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Потребителско име";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Попълни информация за служител";
            // 
            // addstaffsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addstaffsform";
            this.Size = new System.Drawing.Size(802, 556);
            this.Load += new System.EventHandler(this.addstaffsform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_staff_clearBtn;
        private System.Windows.Forms.Button add_staff_deleteBtn;
        private System.Windows.Forms.Button add_staff_updateBtn;
        private System.Windows.Forms.Button add_staff_addBtn;
        private System.Windows.Forms.ComboBox add_staff_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add_staff_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_staff_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
