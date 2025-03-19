namespace TicketManagmnet
{
    partial class buyTicketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyTicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buyTicket_clearEvent = new System.Windows.Forms.Button();
            this.buyTicket_selectEvent = new System.Windows.Forms.Button();
            this.buyTicket_regularPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buyTicket_eventType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buyTicket_eventName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyTicket_eventID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyTicket_Calculate = new System.Windows.Forms.Button();
            this.buyTicket_clearFields = new System.Windows.Forms.Button();
            this.buyTicket_buyEvent = new System.Windows.Forms.Button();
            this.buyTicket_receipt = new System.Windows.Forms.Button();
            this.buyTicket_change = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buyTicket_ammount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buyTicket_totalPrice = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buyTicket_drinks = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buyTicket_foods = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buyTicket_availableSeats = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 197);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 144);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Налични събития";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buyTicket_clearEvent);
            this.panel2.Controls.Add(this.buyTicket_selectEvent);
            this.panel2.Controls.Add(this.buyTicket_regularPrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buyTicket_eventType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buyTicket_eventName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buyTicket_eventID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 197);
            this.panel2.TabIndex = 1;
            // 
            // buyTicket_clearEvent
            // 
            this.buyTicket_clearEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_clearEvent.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearEvent.Location = new System.Drawing.Point(240, 156);
            this.buyTicket_clearEvent.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_clearEvent.Name = "buyTicket_clearEvent";
            this.buyTicket_clearEvent.Size = new System.Drawing.Size(112, 29);
            this.buyTicket_clearEvent.TabIndex = 16;
            this.buyTicket_clearEvent.Text = "Изчисти";
            this.buyTicket_clearEvent.UseVisualStyleBackColor = false;
            this.buyTicket_clearEvent.Click += new System.EventHandler(this.buyTicket_clearEvent_Click);
            // 
            // buyTicket_selectEvent
            // 
            this.buyTicket_selectEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_selectEvent.ForeColor = System.Drawing.Color.White;
            this.buyTicket_selectEvent.Location = new System.Drawing.Point(130, 156);
            this.buyTicket_selectEvent.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_selectEvent.Name = "buyTicket_selectEvent";
            this.buyTicket_selectEvent.Size = new System.Drawing.Size(112, 29);
            this.buyTicket_selectEvent.TabIndex = 15;
            this.buyTicket_selectEvent.Text = "Избери събитие";
            this.buyTicket_selectEvent.UseVisualStyleBackColor = false;
            this.buyTicket_selectEvent.Click += new System.EventHandler(this.buyTicket_selectEvent_Click);
            // 
            // buyTicket_regularPrice
            // 
            this.buyTicket_regularPrice.AutoSize = true;
            this.buyTicket_regularPrice.Location = new System.Drawing.Point(245, 115);
            this.buyTicket_regularPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            this.buyTicket_regularPrice.Size = new System.Drawing.Size(16, 13);
            this.buyTicket_regularPrice.TabIndex = 9;
            this.buyTicket_regularPrice.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Първоначална цена:";
            // 
            // buyTicket_eventType
            // 
            this.buyTicket_eventType.AutoSize = true;
            this.buyTicket_eventType.Location = new System.Drawing.Point(245, 87);
            this.buyTicket_eventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyTicket_eventType.Name = "buyTicket_eventType";
            this.buyTicket_eventType.Size = new System.Drawing.Size(16, 13);
            this.buyTicket_eventType.TabIndex = 7;
            this.buyTicket_eventType.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Тип на събитие:";
            // 
            // buyTicket_eventName
            // 
            this.buyTicket_eventName.AutoSize = true;
            this.buyTicket_eventName.Location = new System.Drawing.Point(245, 55);
            this.buyTicket_eventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyTicket_eventName.Name = "buyTicket_eventName";
            this.buyTicket_eventName.Size = new System.Drawing.Size(16, 13);
            this.buyTicket_eventName.TabIndex = 5;
            this.buyTicket_eventName.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Име на събитие:";
            // 
            // buyTicket_eventID
            // 
            this.buyTicket_eventID.AutoSize = true;
            this.buyTicket_eventID.Location = new System.Drawing.Point(245, 24);
            this.buyTicket_eventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyTicket_eventID.Name = "buyTicket_eventID";
            this.buyTicket_eventID.Size = new System.Drawing.Size(16, 13);
            this.buyTicket_eventID.TabIndex = 3;
            this.buyTicket_eventID.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(17, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 173);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buyTicket_Calculate);
            this.panel3.Controls.Add(this.buyTicket_clearFields);
            this.panel3.Controls.Add(this.buyTicket_buyEvent);
            this.panel3.Controls.Add(this.buyTicket_receipt);
            this.panel3.Controls.Add(this.buyTicket_change);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.buyTicket_ammount);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.buyTicket_totalPrice);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.buyTicket_drinks);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.buyTicket_foods);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.buyTicket_availableSeats);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(363, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 415);
            this.panel3.TabIndex = 2;
            // 
            // buyTicket_Calculate
            // 
            this.buyTicket_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_Calculate.ForeColor = System.Drawing.Color.White;
            this.buyTicket_Calculate.Location = new System.Drawing.Point(6, 203);
            this.buyTicket_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_Calculate.Name = "buyTicket_Calculate";
            this.buyTicket_Calculate.Size = new System.Drawing.Size(263, 28);
            this.buyTicket_Calculate.TabIndex = 20;
            this.buyTicket_Calculate.Text = "Изчисли";
            this.buyTicket_Calculate.UseVisualStyleBackColor = false;
            this.buyTicket_Calculate.Click += new System.EventHandler(this.buyTicket_Calculate_Click);
            // 
            // buyTicket_clearFields
            // 
            this.buyTicket_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_clearFields.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearFields.Location = new System.Drawing.Point(12, 384);
            this.buyTicket_clearFields.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_clearFields.Name = "buyTicket_clearFields";
            this.buyTicket_clearFields.Size = new System.Drawing.Size(263, 29);
            this.buyTicket_clearFields.TabIndex = 19;
            this.buyTicket_clearFields.Text = "Изчисти";
            this.buyTicket_clearFields.UseVisualStyleBackColor = false;
            this.buyTicket_clearFields.Click += new System.EventHandler(this.buyTicket_clearFields_Click);
            // 
            // buyTicket_buyEvent
            // 
            this.buyTicket_buyEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_buyEvent.ForeColor = System.Drawing.Color.White;
            this.buyTicket_buyEvent.Location = new System.Drawing.Point(12, 321);
            this.buyTicket_buyEvent.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_buyEvent.Name = "buyTicket_buyEvent";
            this.buyTicket_buyEvent.Size = new System.Drawing.Size(263, 28);
            this.buyTicket_buyEvent.TabIndex = 18;
            this.buyTicket_buyEvent.Text = "Купи";
            this.buyTicket_buyEvent.UseVisualStyleBackColor = false;
            this.buyTicket_buyEvent.Click += new System.EventHandler(this.buyTicket_buyEvent_Click);
            // 
            // buyTicket_receipt
            // 
            this.buyTicket_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.buyTicket_receipt.ForeColor = System.Drawing.Color.White;
            this.buyTicket_receipt.Location = new System.Drawing.Point(12, 353);
            this.buyTicket_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.buyTicket_receipt.Name = "buyTicket_receipt";
            this.buyTicket_receipt.Size = new System.Drawing.Size(263, 27);
            this.buyTicket_receipt.TabIndex = 17;
            this.buyTicket_receipt.Text = "Касов бон";
            this.buyTicket_receipt.UseVisualStyleBackColor = false;
            this.buyTicket_receipt.Click += new System.EventHandler(this.buyTicket_receipt_Click);
            // 
            // buyTicket_change
            // 
            this.buyTicket_change.AutoSize = true;
            this.buyTicket_change.Location = new System.Drawing.Point(63, 305);
            this.buyTicket_change.Name = "buyTicket_change";
            this.buyTicket_change.Size = new System.Drawing.Size(34, 13);
            this.buyTicket_change.TabIndex = 14;
            this.buyTicket_change.Text = "$0.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Ресто:";
            // 
            // buyTicket_ammount
            // 
            this.buyTicket_ammount.Location = new System.Drawing.Point(52, 277);
            this.buyTicket_ammount.Name = "buyTicket_ammount";
            this.buyTicket_ammount.Size = new System.Drawing.Size(100, 20);
            this.buyTicket_ammount.TabIndex = 12;
            this.buyTicket_ammount.TextChanged += new System.EventHandler(this.buyTicket_ammount_TextChanged);
            this.buyTicket_ammount.Enter += new System.EventHandler(this.buyTicket_ammount_Enter);
            this.buyTicket_ammount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buyTicket_ammount_KeyDown);
            this.buyTicket_ammount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyTicket_ammount_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 277);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Сума:";
            // 
            // buyTicket_totalPrice
            // 
            this.buyTicket_totalPrice.AutoSize = true;
            this.buyTicket_totalPrice.Location = new System.Drawing.Point(63, 245);
            this.buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            this.buyTicket_totalPrice.Size = new System.Drawing.Size(34, 13);
            this.buyTicket_totalPrice.TabIndex = 10;
            this.buyTicket_totalPrice.Text = "$0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Сметка:";
            // 
            // buyTicket_drinks
            // 
            this.buyTicket_drinks.FormattingEnabled = true;
            this.buyTicket_drinks.Items.AddRange(new object[] {
            "Beer",
            "Coca-Cola",
            "Pepsi Cola",
            "Water"});
            this.buyTicket_drinks.Location = new System.Drawing.Point(96, 167);
            this.buyTicket_drinks.Name = "buyTicket_drinks";
            this.buyTicket_drinks.Size = new System.Drawing.Size(121, 21);
            this.buyTicket_drinks.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Напитки:";
            // 
            // buyTicket_foods
            // 
            this.buyTicket_foods.FormattingEnabled = true;
            this.buyTicket_foods.Items.AddRange(new object[] {
            "French Fries",
            "Hot Dog",
            "Hamburger"});
            this.buyTicket_foods.Location = new System.Drawing.Point(96, 132);
            this.buyTicket_foods.Name = "buyTicket_foods";
            this.buyTicket_foods.Size = new System.Drawing.Size(121, 21);
            this.buyTicket_foods.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Храна:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Налични храни:";
            // 
            // buyTicket_availableSeats
            // 
            this.buyTicket_availableSeats.FormattingEnabled = true;
            this.buyTicket_availableSeats.Location = new System.Drawing.Point(96, 24);
            this.buyTicket_availableSeats.Name = "buyTicket_availableSeats";
            this.buyTicket_availableSeats.Size = new System.Drawing.Size(121, 21);
            this.buyTicket_availableSeats.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Налични места:";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyTicketForm";
            this.Size = new System.Drawing.Size(643, 453);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label buyTicket_eventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label buyTicket_eventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buyTicket_eventType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label buyTicket_regularPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buyTicket_selectEvent;
        private System.Windows.Forms.Button buyTicket_clearEvent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox buyTicket_availableSeats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label buyTicket_change;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox buyTicket_ammount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label buyTicket_totalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox buyTicket_drinks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox buyTicket_foods;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buyTicket_clearFields;
        private System.Windows.Forms.Button buyTicket_buyEvent;
        private System.Windows.Forms.Button buyTicket_receipt;
        private System.Windows.Forms.Button buyTicket_Calculate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
