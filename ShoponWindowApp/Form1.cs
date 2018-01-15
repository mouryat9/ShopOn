using Shopon.Business;
using Shopon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoponWindowApp
{
    public partial class Form1 : Form
    {
        private ProductManager manger = new ProductManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = Convert.ToInt16(txtProductId.Text);
            product.ProductName = txtProductName.Text;
            product.Price = Convert.ToDouble(txtProductPrice.Text);
            if (manger.InsertProduct(product))
            {
                lblMsg.Text = "Record added.";
            }
            else
            {
                lblMsg.Text = "There was problem adding record.";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> products = manger.GetAllProducts();
            dataGridView1.DataSource = products;
            dataGridView1.Refresh();
        }
    }
}
