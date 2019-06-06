using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140105
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //Here is the Function for the button in which by clicking it it adds information into product table
            


            if(Convert.ToInt32( productPriceTextBox.Text )>= 0 || Convert.ToInt32( productQuantityTextBox.Text) > 0)
           {



                SqlConnection connection = new SqlConnection("server= VDI-NET-0016\\LOCAL;database=140105;trusted_connection = true");
                connection.Open();
                SqlCommand command = new SqlCommand("sp_insertProduct", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductName", productNameTextBox.Text.ToString());

                SqlCommand newCommand = new SqlCommand("Insert Into category values('" + categoryNametextBox.Text + "')", connection);
                int commandReader = newCommand.ExecuteNonQuery();
                var categoryValue = newCommand;
                command.Parameters.AddWithValue("@Category", categoryNametextBox.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(productPriceTextBox.Text));
                command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(productQuantityTextBox.Text));

                int reader = command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted In the Product Ta");




            }
           else
            {
                MessageBox.Show("Wrong Product Input ");
           }

        }
    }
}
