namespace _140105_Flight
{
    partial class AddFlight
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.aircraftComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.traveldateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addFlightGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addFlightGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aircraft Name";
            // 
            // aircraftComboBox
            // 
            this.aircraftComboBox.FormattingEnabled = true;
            this.aircraftComboBox.Location = new System.Drawing.Point(125, 27);
            this.aircraftComboBox.Name = "aircraftComboBox";
            this.aircraftComboBox.Size = new System.Drawing.Size(121, 21);
            this.aircraftComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TravelDate";
            // 
            // traveldateTimePicker
            // 
            this.traveldateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.traveldateTimePicker.Location = new System.Drawing.Point(125, 72);
            this.traveldateTimePicker.Name = "traveldateTimePicker";
            this.traveldateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.traveldateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seating Capacity";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(125, 112);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(121, 20);
            this.capacityTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Travel Source";
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.Location = new System.Drawing.Point(125, 154);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.sourceComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Travel Destination";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(125, 209);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationComboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Depart Time";
            // 
            // departTimePicker
            // 
            this.departTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departTimePicker.Location = new System.Drawing.Point(125, 261);
            this.departTimePicker.Name = "departTimePicker";
            this.departTimePicker.Size = new System.Drawing.Size(121, 20);
            this.departTimePicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ArrivalTime";
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimePicker.Location = new System.Drawing.Point(125, 305);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.Size = new System.Drawing.Size(121, 20);
            this.arrivalTimePicker.TabIndex = 2;
            // 
            // addFlightGrid
            // 
            this.addFlightGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addFlightGrid.Location = new System.Drawing.Point(296, 25);
            this.addFlightGrid.Name = "addFlightGrid";
            this.addFlightGrid.Size = new System.Drawing.Size(448, 300);
            this.addFlightGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addFlightGrid);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.arrivalTimePicker);
            this.Controls.Add(this.departTimePicker);
            this.Controls.Add(this.traveldateTimePicker);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.sourceComboBox);
            this.Controls.Add(this.aircraftComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addFlightGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox aircraftComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker traveldateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sourceComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker departTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker arrivalTimePicker;
        private System.Windows.Forms.DataGridView addFlightGrid;
        private System.Windows.Forms.Button button1;
    }
}