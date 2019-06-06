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
    public partial class DisplayAllProduct : Form
    {
        public DisplayAllProduct()
        {
            InitializeComponent();
        }

        private void DisplayAllProduct_Load(object sender, EventArgs e)
        {
            //By Clicking on the display product information it shows the all product information in another form
            try
            {
                SqlConnection connection = new SqlConnection("server= VDI-NET-0016\\LOCAL;database=140105;trusted_connection = true");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from product", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                productInformationGrid.DataSource = ds.Tables[0].AsDataView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
