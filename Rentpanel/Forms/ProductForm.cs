using BaseBackend.Models;
using BaseBackend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentpanel.Forms
{
    public partial class ProductForm : Form
    {
        ProductService productService;
        public ProductForm()
        {
            InitializeComponent();
            productService =new ProductService();

           
            FillDataGridView(productService.GetAll()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string description = descriptiontextBox1.Text;
            string name = nametextBox6.Text;
            string code = codetextBox3.Text;
            string price = pricetextBox1.Text;
            // az ostad bprsam bbinam age bekham khdwam behesh meghdar bedam ke daemi bashe bayad inja behesh bedamesh va inke oon radiobutton haye dakhele khode form ra chejuri bayad meghdaar daemi bdm
            //bool issellable=



            Product product = new Product(name: name, code: code)
            {

                Description = description,
                //az osatad bporsam ke inja price typesh decimale va man nmitoonam stringesh knm hala byd chikr knm
                // Price = price;
            };



            Product product1 = new Product(name: "", code: "");
            productService.Add(product);
            FillDataGridView(productService.GetAll());
            ResetForm();

        }
        private void FillDataGridView(List<Product> myproducts)
        {
            ProductdataGridView1.DataSource = null;
            ProductdataGridView1.DataSource = myproducts;
            ProductdataGridView1.Refresh();


        }

        private void rsetRejisterButton1_Click(object sender, EventArgs e)
        {

            ResetForm();
        }
        private void ResetForm()
        {
            nametextBox6.Text = null;
            codetextBox3.Text = null;
            pricetextBox1.Text = null;
            descriptiontextBox1.Text = null;
            //harvaght taklif price rooshan shd inja bnvisamesh
        }
    }
}
