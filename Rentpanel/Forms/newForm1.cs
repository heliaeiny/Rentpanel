using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentpanel.Wrappers;
using Rentpanel.Utitlities;

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
            if (username.Equals(password, StringComparison.OrdinalIgnoreCase))
            {
               Console.WriteLine( "strings are equal(Case-insensitive)");


            }

            //in firmatmobile ro bayad badan dorostesh knam yani az tooye utilities aval poresh knm baad inja azash estefade knam
            username.FormatMobile();

            /*  string PathUserLoginFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.txt");

              if (!File.Exists(PathUserLoginFile))
              {
                  MessageBox.Show("invalid login");
                  return;
              }
              string[] lines = File.ReadAllLines(PathUserLoginFile);

              for (int i = 0; i < lines.Length; i++)
              {


                  string currentline = lines[i];
                  string[] loogin = currentline.Split(",");


                  if (username == loogin[0] && password == loogin[1])
                  {

                      LayOutPanelForm form = new LayOutPanelForm();
                      form.ShowDialog();

                      return;
                  }
              }
              MessageBox.Show("invalid login");

              // ResetForm();
*/

            string pathUserLoginFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.json");

            if (!File.Exists(pathUserLoginFile))
            {
                MessageBox.Show("invalid login");
                return;
            }
            string content = File.ReadAllText(pathUserLoginFile);
            List<UserLogin> userLogins =JsonConvert.DeserializeObject<List<UserLogin>>(content);

            var login = userLogins.Where(item => item.UserName == username && item.Password ==password).FirstOrDefault();
            
            if (login is not null)
            {
                LayOutPanelForm form = new LayOutPanelForm();
                form.ShowDialog();
                return;
            }
            MessageBox.Show("invalid login");


       
            /* for (int i = 0; i < userLogins.Count; i++)
             {
                 if (username ==userLogins[i].UserName && password == userLogins[i].Password)
                 {

                     LayOutPanelForm form = new LayOutPanelForm();
                     form.ShowDialog();
                     return;
                 }

                 MessageBox.Show("invalid login");

             }
            */
            // ResetForm();

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
