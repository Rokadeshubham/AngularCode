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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //By Clicking on add category button new category is added into database

            try
            {
                SqlConnection connection = new SqlConnection("server= VDI-NET-0016\\LOCAL;database=140105;trusted_connection = true");
                connection.Open();
                SqlCommand command = new SqlCommand("sp_insertCategory", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryName", categoryNameTextBox.Text);
                command.Parameters.AddWithValue("@CategoryDesc", categoryDescriptionTextBox.Text);
                int reader = command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted into category table");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception occured while adding category");
            }


            
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
