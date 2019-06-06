using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140105_Flight
{
    public partial class FlightBooking : Form
    {
        public FlightBooking()
        {
            InitializeComponent();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {



            try
            {
                AddFlight flight = new AddFlight();
                flight.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            
        }

        private void searchFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFlight search = new SearchFlight();
                search.ShowDialog();
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Exit Button Click and Exit from the form
                FlightBooking booking = new FlightBooking();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




           
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Redirect to the  bookticket form
                BookTicket ticket = new BookTicket();
                ticket.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           
        }
    }
}
