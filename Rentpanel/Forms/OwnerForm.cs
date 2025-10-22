using Rentpanel.Models;
using Rentpanel.Services;
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
    public partial class OwnerForm : Form
    {
        // OwnerService ownerService;  
        //  public OwnerForm()
        //{
        //  InitializeComponent();
        // ownerService = new OwnerService();
        // }

        //List<Owner> owners = new List<Owner>();

        private void registerButton_Click(object sender, EventArgs e)
        {



            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string nationalCode = nationalCodeTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string password = passwordtextBox5.Text;
            string userName = userNametextBox6.Text;


            Owner owner = new Owner(nationalCode: nationalCode, phoneNumber: phoneNumber )
            {
                LastName = lastName,
                FirstName = firstName,
            };
            Owner owner2 = new Owner(, string lastName, string firstname)
            {


            };
            Owner owner1 = new Owner(nationalCode: "", phoneNumber: "");
            owner.CreatedAt = DateTime.Now;

            owner.FirstName = firstName;
            owner.LastName = lastName;
            owner.Password = password;
            owner.Username = userName;

            /* DateTime birthdate = birthdatedateTimePicker1.Value;
             if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
             {
                 MessageBox.Show("please enter true information");
                 return;
             }*/

            //  Owner owner = new Owner()
            //{
            //  firstName=firstNameTextBox.Text

            //};
            //List<Owner> list = new List<Owner>();

            // Owner owner = new Owner(NationalCode : nationalCode,phoneNumber:phoneNumber);
            //
            //            ownerService.Add(owner);
            //
            //dataGridView1.DataSource=ownerService.GetAll();

            //ResetForm();
        }
    }
}
