namespace _140105
{
    partial class ProductProject
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
            this.addproductButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.displayAllProductButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addproductButton
            // 
            this.addproductButton.Location = new System.Drawing.Point(23, 247);
            this.addproductButton.Name = "addproductButton";
            this.addproductButton.Size = new System.Drawing.Size(102, 39);
            this.addproductButton.TabIndex = 0;
            this.addproductButton.Text = "Add Product";
            this.addproductButton.UseVisualStyleBackColor = true;
            this.addproductButton.Click += new System.EventHandler(this.addproductButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(148, 247);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(97, 39);
            this.addCategoryButton.TabIndex = 1;
            this.addCategoryButton.Text = "Add a Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // displayAllProductButton
            // 
            this.displayAllProductButton.Location = new System.Drawing.Point(530, 247);
            this.displayAllProductButton.Name = "displayAllProductButton";
            this.displayAllProductButton.Size = new System.Drawing.Size(119, 39);
            this.displayAllProductButton.TabIndex = 3;
            this.displayAllProductButton.Text = "Display all product";
            this.displayAllProductButton.UseVisualStyleBackColor = true;
            this.displayAllProductButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(264, 247);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(121, 39);
            this.placeOrderButton.TabIndex = 2;
            this.placeOrderButton.Text = "Place an Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(400, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "Search by OrderDate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select From the Below";
            // 
            // ProductProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.displayAllProductButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.addproductButton);
            this.Name = "ProductProject";
            this.Text = "Menu Display Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addproductButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button displayAllProductButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

