namespace TicketManagmnet
{
    partial class addeventform
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
            this.add_Event_Status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addevent_addClear = new System.Windows.Forms.Button();
            this.addevent_addDelete = new System.Windows.Forms.Button();
            this.addevent_addUpdate = new System.Windows.Forms.Button();
            this.addevent_addBtn = new System.Windows.Forms.Button();
            this.addevent_capacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addevent_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addevent_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addevent_type = new System.Windows.Forms.ComboBox();
            this.addevent_eventName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addevent_eventID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.add_Event_Status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addevent_addClear);
            this.panel2.Controls.Add(this.addevent_addDelete);
            this.panel2.Controls.Add(this.addevent_addUpdate);
            this.panel2.Controls.Add(this.addevent_addBtn);
            this.panel2.Controls.Add(this.addevent_capacity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addevent_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addevent_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addevent_type);
            this.panel2.Controls.Add(this.addevent_eventName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addevent_eventID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 220);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 222);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // add_Event_Status
            // 
            this.add_Event_Status.FormattingEnabled = true;
            this.add_Event_Status.Items.AddRange(new object[] {
            "Ongoing",
            "Available",
            "Unavailable",
            "Deleted"});
            this.add_Event_Status.Location = new System.Drawing.Point(324, 133);
            this.add_Event_Status.Margin = new System.Windows.Forms.Padding(2);
            this.add_Event_Status.Name = "add_Event_Status";
            this.add_Event_Status.Size = new System.Drawing.Size(101, 21);
            this.add_Event_Status.TabIndex = 19;
            this.add_Event_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Статус";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addevent_addClear
            // 
            this.addevent_addClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.addevent_addClear.ForeColor = System.Drawing.Color.White;
            this.addevent_addClear.Location = new System.Drawing.Point(436, 184);
            this.addevent_addClear.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_addClear.Name = "addevent_addClear";
            this.addevent_addClear.Size = new System.Drawing.Size(141, 27);
            this.addevent_addClear.TabIndex = 17;
            this.addevent_addClear.Text = "Изчисти";
            this.addevent_addClear.UseVisualStyleBackColor = false;
            this.addevent_addClear.Click += new System.EventHandler(this.addevent_addClear_Click);
            // 
            // addevent_addDelete
            // 
            this.addevent_addDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.addevent_addDelete.ForeColor = System.Drawing.Color.White;
            this.addevent_addDelete.Location = new System.Drawing.Point(290, 184);
            this.addevent_addDelete.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_addDelete.Name = "addevent_addDelete";
            this.addevent_addDelete.Size = new System.Drawing.Size(141, 27);
            this.addevent_addDelete.TabIndex = 16;
            this.addevent_addDelete.Text = "Изтрий";
            this.addevent_addDelete.UseVisualStyleBackColor = false;
            this.addevent_addDelete.Click += new System.EventHandler(this.addevent_addDelete_Click);
            // 
            // addevent_addUpdate
            // 
            this.addevent_addUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.addevent_addUpdate.ForeColor = System.Drawing.Color.White;
            this.addevent_addUpdate.Location = new System.Drawing.Point(145, 184);
            this.addevent_addUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_addUpdate.Name = "addevent_addUpdate";
            this.addevent_addUpdate.Size = new System.Drawing.Size(141, 27);
            this.addevent_addUpdate.TabIndex = 15;
            this.addevent_addUpdate.Text = "Обнови";
            this.addevent_addUpdate.UseVisualStyleBackColor = false;
            this.addevent_addUpdate.Click += new System.EventHandler(this.addevent_addUpdate_Click);
            // 
            // addevent_addBtn
            // 
            this.addevent_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.addevent_addBtn.ForeColor = System.Drawing.Color.White;
            this.addevent_addBtn.Location = new System.Drawing.Point(2, 184);
            this.addevent_addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_addBtn.Name = "addevent_addBtn";
            this.addevent_addBtn.Size = new System.Drawing.Size(141, 27);
            this.addevent_addBtn.TabIndex = 14;
            this.addevent_addBtn.Text = "Добави";
            this.addevent_addBtn.UseVisualStyleBackColor = false;
            this.addevent_addBtn.Click += new System.EventHandler(this.addevent_addBtn_Click);
            // 
            // addevent_capacity
            // 
            this.addevent_capacity.Location = new System.Drawing.Point(324, 75);
            this.addevent_capacity.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_capacity.Name = "addevent_capacity";
            this.addevent_capacity.Size = new System.Drawing.Size(101, 20);
            this.addevent_capacity.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Капацитет:";
            // 
            // addevent_importBtn
            // 
            this.addevent_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.addevent_importBtn.FlatAppearance.BorderSize = 0;
            this.addevent_importBtn.ForeColor = System.Drawing.Color.White;
            this.addevent_importBtn.Location = new System.Drawing.Point(470, 124);
            this.addevent_importBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_importBtn.Name = "addevent_importBtn";
            this.addevent_importBtn.Size = new System.Drawing.Size(84, 30);
            this.addevent_importBtn.TabIndex = 11;
            this.addevent_importBtn.Text = "Импортиране";
            this.addevent_importBtn.UseVisualStyleBackColor = false;
            this.addevent_importBtn.Click += new System.EventHandler(this.addevent_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(470, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 104);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addevent_price
            // 
            this.addevent_price.Location = new System.Drawing.Point(324, 24);
            this.addevent_price.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_price.Name = "addevent_price";
            this.addevent_price.Size = new System.Drawing.Size(101, 20);
            this.addevent_price.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена:";
            // 
            // addevent_type
            // 
            this.addevent_type.FormattingEnabled = true;
            this.addevent_type.Items.AddRange(new object[] {
            "Rugby match",
            "Football match",
            "Rugby training",
            "Football training",
            "Friday night meeting"});
            this.addevent_type.Location = new System.Drawing.Point(111, 124);
            this.addevent_type.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_type.Name = "addevent_type";
            this.addevent_type.Size = new System.Drawing.Size(101, 21);
            this.addevent_type.TabIndex = 7;
            // 
            // addevent_eventName
            // 
            this.addevent_eventName.Location = new System.Drawing.Point(111, 75);
            this.addevent_eventName.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_eventName.Name = "addevent_eventName";
            this.addevent_eventName.Size = new System.Drawing.Size(101, 20);
            this.addevent_eventName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Име на събитие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип на събитието:";
            // 
            // addevent_eventID
            // 
            this.addevent_eventID.Location = new System.Drawing.Point(111, 24);
            this.addevent_eventID.Margin = new System.Windows.Forms.Padding(2);
            this.addevent_eventID.Name = "addevent_eventID";
            this.addevent_eventID.Size = new System.Drawing.Size(101, 20);
            this.addevent_eventID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 188);
            this.panel1.TabIndex = 2;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 144);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всички събития";
            // 
            // addeventform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addeventform";
            this.Size = new System.Drawing.Size(602, 452);
            this.Load += new System.EventHandler(this.addeventform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addevent_eventID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addevent_eventName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addevent_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addevent_type;
        private System.Windows.Forms.Button addevent_importBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addevent_addClear;
        private System.Windows.Forms.Button addevent_addDelete;
        private System.Windows.Forms.Button addevent_addUpdate;
        private System.Windows.Forms.Button addevent_addBtn;
        private System.Windows.Forms.TextBox addevent_capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_Event_Status;
        private System.Windows.Forms.Label label7;
    }
}
