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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rentpanel.Forms
{
    public partial class LessorForm : Form
    {
        // List<Lessor> lessors;
        //private object lastNameTextBox;

        public LessorForm()
        {
            InitializeComponent();
            //  lessors = new List<Lessor>();
        }

        private void Enterbutton1_Click(object sender, EventArgs e)
        {


            string firstName = firstNametextBox1.Text;
            string lastName = lastnametextBox2.Text;
            string nationalCode = nationalIdtextBox3.Text;
            string phoneNumber = phoneNumbertextBox4.Text;
            string password = passwordTextBox.Text;
            string userName = userNametextBox5.Text;

            Lessor lessor = new Lessor(nationalCode: nationalCode, phoneNumber: phoneNumber)
            {
                LastName = lastName,
                FirstName = firstName,
            };
            Lessor lessor1 = new Lessor(nationalCode: "", phoneNumber: "");
            lessor.CreatedAt = DateTime.Now;


            lessor.FirstName = firstName;
            lessor.LastName = lastName;
            lessor.Password = password;
           lessor.Username = userName;

            // lessors.Add(lessor);
            // LessordataGridView1.DataSource = null;
            // LessordataGridView1.DataSource= lessors;
            //LessordataGridView1.Refresh();


        }
    }
}
