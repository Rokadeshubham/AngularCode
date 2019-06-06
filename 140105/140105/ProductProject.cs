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
    public partial class ProductProject : Form
    {
        public ProductProject()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //By clicking this button you should able to display all product details

            try
            {


                DisplayAllProduct product = new DisplayAllProduct();
                product.Show();
                this.Hide();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Relocate to the place order page
            PlaceOrder order = new PlaceOrder();
            order.Show();
            this.Hide();
        }

        private void addproductButton_Click(object sender, EventArgs e)
        {
            //By clicking Add product button it shows another page where product the adding information is available
            AddProduct product = new AddProduct();
            product.Show();
            this.Hide();


        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            //By clicking add category button it display all Add category page

            try
            {
                AddCategory category = new AddCategory();
                category.Show();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //navidates to Search by order date

            SearchByDate date = new SearchByDate();
            date.Show();
            this.Hide();
        }
    }
}
