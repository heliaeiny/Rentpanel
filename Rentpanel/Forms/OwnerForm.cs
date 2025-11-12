using BaseBackend.Models;
using BaseBackend.Services;
using Rentpanel.Helpers;



namespace Rentpanel.Forms;

public partial class OwnerForm : Form
{
    OwnerService ownerService;  
    
    public OwnerForm()
    {
        InitializeComponent();
        ownerService = new OwnerService();
       
        FillDataGridView(ownerService.GetAll());
    }



    private void registerButton_Click(object sender, EventArgs e)
    {


        string firstName = firstNameTextBox.Text;
        string lastName = lastNameTextBox.Text;
        string nationalCode = nationalCodeTextBox.Text;
        string phoneNumber = phoneNumberTextBox.Text;
        string password = passwordtextBox5.Text;
        string userName = userNametextBox6.Text;

        nationalCode.FormatNationalCode();
        DateTime birthDate = birthdateTimePicker1.Value;

        if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
        {
            MessageBox.Show("please  enter true phonenumber");
        }
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            MessageBox.Show("please  enter true information");

            return;
        }


        Owner owner = new Owner(nationalCode: nationalCode, phoneNumber: phoneNumber, firstName, lastName, birthDate)
        {
            LastName = lastName,
            FirstName = firstName,
            Password = password,
            UserName = userName,

        };

        Owner owner1 = new Owner(nationalCode: "", phoneNumber: "");


        owner.CreatedAt = DateTime.Now;
        owner.BirthDate = DateTime.Now.AddDays(5);

       
        ownerService.Add(owner); 
        FillDataGridView(ownerService.GetAll());
        ResetForm();
    }


    internal void FillDataGridView(List<Owner> myowners)
    {
        OwnerdataGridView1.DataSource = null;
        OwnerdataGridView1.DataSource = myowners;
        OwnerdataGridView1.Refresh();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    private void ResetForm()
    {
        firstNameTextBox.Text = null;
        lastNameTextBox.Text = null;
        phoneNumberTextBox.Text = null;
        nationalCodeTextBox.Text = null;
        userNametextBox6.Text = null;
        passwordtextBox5.Text = null;
    }
}
