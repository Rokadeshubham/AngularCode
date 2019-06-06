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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

            try
            {
                


                //Travel Date is from tommorow onwards
                traveldateTimePicker.MinDate = DateTime.Now.AddDays(1);
                traveldateTimePicker.MaxDate = DateTime.Now.AddDays(60);

                //Inserting Aircraft Name into ComboBox
                using (SqlConnection connection = new SqlConnection("server=VDI-NET-0016\\LOCAL;database=140105_Flight;trusted_connection=true"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from Aircraft", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        aircraftComboBox.Items.Add(reader["AircraftName"].ToString());
                    }

                }


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
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }




            




        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (sourceComboBox.SelectedItem == destinationComboBox.SelectedItem)
                {
                    MessageBox.Show("Please Select valid source and destination");

                }
                else
                {
                    //Insering data into Flight table by clicking addFlight button
                    using (SqlConnection connection = new SqlConnection("server=VDI-NET-0016\\LOCAL;database=140105_Flight;trusted_connection=true"))
                    {
                        connection.Open();
                        //Finding ID of Aircraft
                        SqlCommand command = new SqlCommand("select AircraftId from AirCraft where AircraftName = @name", connection);
                        command.Parameters.AddWithValue("@name", aircraftComboBox.SelectedItem.ToString());
                        int aircraftId = Convert.ToInt32(command.ExecuteScalar());
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


                        //inserting into Flight table

                        SqlCommand insertCommand = new SqlCommand("InsertIntoFlight", connection);
                        insertCommand.CommandType = CommandType.StoredProcedure;
                        insertCommand.Parameters.AddWithValue("@AircraftId", aircraftId);
                        insertCommand.Parameters.AddWithValue("@Capacity", capacityTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@SourceId", sourceId);
                        insertCommand.Parameters.AddWithValue("@DestinationId", destinationId);
                        insertCommand.Parameters.AddWithValue("@Date", traveldateTimePicker.Text);
                        insertCommand.Parameters.AddWithValue("@DepartTime", departTimePicker.Value);
                        insertCommand.Parameters.AddWithValue("@ArrivalTime", arrivalTimePicker.Value);

                        int reader = insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Into Flight Tables");
                        DisplayInformation();


                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





            

        }

        //This method display data into grid
        void DisplayInformation()
        {
            using (SqlConnection connection = new SqlConnection("server=VDI-NET-0016\\LOCAL;database=140105_Flight;trusted_connection=true"))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("select * from Flight", connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(reader1);
                    addFlightGrid.DataSource = table;
                }
            }
        }
    }
}
