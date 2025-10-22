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
    public partial class AdressForm : Form
    {
        public AdressForm()
        {
            InitializeComponent();
        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {


            string postalCode = postalcodetextBox2.Text;
            string houseNumber = housenumbertextBox3.Text;
            string floor = flooertextBox4.Text;
            string pelak = pelaktextBox5.Text;
            string street = streettextBox6.Text;
            string city = citytextBox7.Text;
            string title = titletextBox8.Text;
            Adress adress = new Adress();
            adress.CreatedAt = DateTime.Now;
            adress.PostalCode = postalCode;
            adress.HouseNumber = houseNumber;
            adress.Floor = floor;
            adress.City = city;
            adress.Title = title;
            adress.Pelak = pelak;
            adress.Street = street;


            // AdressForm adress = new AdressForm()
            //{
            //Alley = alleytextBox.Text,

            //            };


        }
    }
}
