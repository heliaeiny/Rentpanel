using BaseBackend.Models;
using BaseBackend.Services;
using Rentpanel.Helpers;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rentpanel.Forms
{
    public partial class LessorForm : Form
    {
        LessorServices lessorServices;
        public LessorForm()
        {
            InitializeComponent();
            lessorServices = new LessorServices();
            
            FillDataGridView(lessorServices.GetAll());


        }

        private void Enterbutton1_Click(object sender, EventArgs e)
        {


            string firstName = firstNametextBox1.Text;
            string lastName = lastnametextBox2.Text;
            string nationalCode = nationalIdtextBox3.Text;
            string phoneNumber = phoneNumbertextBox4.Text;
            string password = passwordTextBox.Text;
            string userName = userNametextBox5.Text;
            DateTime birthDate = BirthDatedateTimePicker1.Value;



            if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("please  enter true phonenumber");

            }
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("please  enter true information");

                return;
            }
            Lessor lessor = new Lessor(nationalCode: nationalCode, phoneNumber: phoneNumber, firstName, lastName, birthDate)
            {

                LastName = lastName,
                FirstName = firstName,
                Password = password,
                Username = userName,
            };
            Lessor lessor1 = new Lessor(nationalCode: "", phoneNumber: "");
            lessor.CreatedAt = DateTime.Now;
            lessor.BirthDate = DateTime.Now.AddDays(7);

            lessorServices.Add(lessor);
            FillDataGridView(lessorServices.GetAll());

            ResetForm();

        }
        private void FillDataGridView(List<Lessor> mylessors)
        {
            LessordataGridView1.DataSource = null;
            LessordataGridView1.DataSource = mylessors;
            LessordataGridView1.Refresh();

        }
        private void reserRejisterutton1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            firstNametextBox1.Text = null;
            lastnametextBox2.Text = null;
            nationalIdtextBox3.Text = null;
            phoneNumbertextBox4.Text = null;
            userNametextBox5.Text = null;
            passwordTextBox.Text = null;
        }
    }
}

