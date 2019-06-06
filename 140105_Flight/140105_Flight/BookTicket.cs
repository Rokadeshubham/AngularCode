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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void sourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookTicket_Load(object sender, EventArgs e)
        {



            try
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (sourceComboBox.SelectedItem == null || destinationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Enter source and destination");
            }
            else
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

                            SqlCommand command = new SqlCommand("select");


                            connection.Open();
                            SqlCommand command1 = new SqlCommand("AddPassenger", connection);
                            command1.CommandType = CommandType.StoredProcedure;
                            command1.Parameters.AddWithValue("@firstname", nameTextBox.Text);
                            command1.Parameters.AddWithValue("@lname", lastNameTextBox.Text);
                            command1.Parameters.AddWithValue("@age", ageTextBox.Text);
                            command1.Parameters.AddWithValue("@gender", genderComboBox.SelectedItem);
                            int reader = command1.ExecuteNonQuery();
                            MessageBox.Show("data inserted into passenger table");



                        }
                    }
                    catch (Exception e1)
                    {

                        MessageBox.Show(e1.Message);
                    }
                   
                    








                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            PassengerDetails passenger = new PassengerDetails();
            passenger.ShowDialog();


        }
    }
}
