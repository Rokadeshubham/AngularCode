namespace _140105
{
    partial class SearchByDate
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
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDateTimePicker.Location = new System.Drawing.Point(103, 125);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.searchDateTimePicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Date And Search By Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateGridView
            // 
            this.dateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateGridView.Location = new System.Drawing.Point(385, 125);
            this.dateGridView.Name = "dateGridView";
            this.dateGridView.Size = new System.Drawing.Size(321, 108);
            this.dateGridView.TabIndex = 2;
            // 
            // SearchByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchDateTimePicker);
            this.Name = "SearchByDate";
            this.Text = "SearchByDate";
            ((System.ComponentModel.ISupportInitialize)(this.dateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dateGridView;
    }
}