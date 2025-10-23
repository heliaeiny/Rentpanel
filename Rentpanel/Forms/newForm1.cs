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
    public partial class newForm1 : Form
    {
        public newForm1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox1.Text;
            string password = PasswordTextBox2.Text;
            if (username == "admin" && password == "1234")
            {
                LayOutPanelForm layOutPanelForm = new LayOutPanelForm();
                layOutPanelForm.SuspendLayout();

            }
            else
            {
                MessageBox.Show("invalid login");
            }

            ResetForm();
        }

        private void resetRejisterButton2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {

            userNameTextBox1.Text = null;
            PasswordTextBox2.Text = null;
        }
    }
}
