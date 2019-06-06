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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server= VDI-NET-0016\\LOCAL;database=140105;trusted_connection = true");
            connection.Open();
            SqlCommand command = new SqlCommand("select productName from products ", connection);
            SqlDataReader reader = command.ExecuteReader();
            foreach (var item in reader)
            {
                productComboBox.Items.Add(item);
            }



        }
    }
}
