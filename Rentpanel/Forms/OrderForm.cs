using Rentpanel.Models;
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

          
            Order order = new Order(adress: adress , SendAt: sendAt)
            {
                DeliveryFullName = deliveryFullName,
                DeliveryPhoneNumber =deliverPhoneNumber,
            };
            Order order1 = new Order(adress = "", sendAt = "");
            order.CreatedAt = DateTime.Now;
            string owner1 = owner;
            // az ostad beprsam :
            // chera inja nemitoonam oon masalan 
            // Order.Owner = owner ;
            // va Order Product = product ; 
            // va baghiashun ro benevisam?
            // va ike bayad alave bar constructori ke baraye sendat va adrees sakhtam yek constuctor ham baraye deliverphonenumber 
            // va deliveru fullname benevisam 
            // ama aya bayad oonha ro ham inja benevisam?
            // in 2ta tamrin baraye safhe 21 hastand
        }

    }

}
