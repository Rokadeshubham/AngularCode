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

namespace _140105_Flight
{
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {


            try
            {
                //searching date must be greater than the todays date+one day
                searchDatePicker.MinDate = DateTime.Now.AddDays(1);

                //Inserting source and destination

                using (SqlConnection connection = new SqlConnection("server=VDI-NET-0016\\LOCAL;database=140105_Flight;trusted_connection=true"))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("select * from City", connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        sourceComboBox.Items.Add(reader1["Cityname"].ToString());
                        destinationComboBox.Items.Add(reader1["Cityname"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (sourceComboBox.SelectedItem == destinationComboBox.SelectedItem)
            {
                MessageBox.Show("Please Select valid source and destination");

            }
            else
            {

                try
                {


                    using (SqlConnection connection = new SqlConnection("server=VDI-NET-0016\\LOCAL;database=140105_Flight;trusted_connection=true"))
                    {
                        connection.Open();


                        //Finding Id of source city
                        SqlCommand command1 = new SqlCommand("CityId", connection);
                        command1.CommandType = CommandType.StoredProcedure;
                        command1.Parameters.AddWithValue("@city", sourceComboBox.SelectedItem.ToString());
                        int sourceId = Convert.ToInt32(command1.ExecuteScalar());
                        //Finding Id of destination city
                        SqlCommand command11 = new SqlCommand("CityId1", connection);
                        command11.CommandType = CommandType.StoredProcedure;
                        command11.Parameters.AddWithValue("@city1", destinationComboBox.SelectedItem.ToString());
                        int destinationId = Convert.ToInt32(command11.ExecuteScalar());
                        //Below code is for searching the flight
                        SqlCommand command = new SqlCommand("SearchFlight", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@source", sourceId);
                        command.Parameters.AddWithValue("@destination", destinationId);
                        SqlDataReader reader = command.ExecuteReader();
                        //Below Loop Display search data into the grid

                       if (reader.HasRows)
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            searchDataGrid.DataSource = table;
                         
                        }




                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                
            }
        }
    }
}
