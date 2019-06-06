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
    public partial class SearchByDate : Form
    {
        public SearchByDate()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Search By date Functionality In my database their no date but you can insert and check
            try
            {
                SqlConnection connection = new SqlConnection("server= VDI-NET-0016\\LOCAL;database=140105;trusted_connection = true");
                connection.Open();
                SqlCommand command = new SqlCommand("sp_searchByDate", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date", Convert.ToDateTime(searchDateTimePicker.Text));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dateGridView.DataSource = dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
