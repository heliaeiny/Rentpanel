using BaseBackend.Enums;
using BaseBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentpanel.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string owner = ownerTextBox1.Text;
            string currentPrice = CurrentPriceTextBox3.Text;
            string product = ProductTextBox2.Text;
            string deliverPhoneNumber = DeliveryFullNameTtextBox7.Text;
            string count = CountTextBox5.Text;
            string adress = AdressTextBox4.Text;
            string deliveryFullName = DeliveryFullNameTtextBox7.Text;
            string sendAt = SendAtTextBox6.Text;
            //ino az ostad beprsdam
            Order order = new Order(sendAt = sendAt, adress = adress)
            {
                //chera inja CurrentPrice,Count,Product,Owner k  khata mikhornd ra dorost knm
               // CurrentPrice = currentPrice,
                DeliveryFullName = deliveryFullName,
                DeliveryPhoneNumber = deliverPhoneNumber,
                //Count=count,
                //Product=product,
                //Owner=owner

            };
            //az ostad:chera sendat inja moshkel dare
            // Order order1 = new Order(sendAt: "", adress: "");
            //vaghti sendat drst shd byyd datagrid in form ro dorost knm

            order.CreatedAt = DateTime.Now;


            ResetForm();
        }

        private void resetrejisterbutton2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {

            ownerTextBox1.Text = null;
            CurrentPriceTextBox3.Text = null;
            ProductTextBox2.Text = null;
            DeliveryFullNameTtextBox7.Text = null;
            CountTextBox5.Text = null;
            AdressTextBox4.Text = null;
            SendAtTextBox6.Text = null;
            DeliveryFullNameTtextBox7.Text = null;
        }
    }

}
