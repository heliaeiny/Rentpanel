using BaseBackend.Models;
using BaseBackend.Services;
using Rentpanel.Helpers;



namespace Rentpanel.Forms;

public partial class OwnerForm : Form
{

    OwnerService ownerService;

    //declare the delegate
    public delegate void ReloadData(List<Owner> myowner);
    //declare the even 
    public event ReloadData ReloadDataEvent;


    int SelectedOwnerId = 0;
    public delegate void ReaLoadData(List<Owner> myowners);

    public event ReaLoadData ReaLoadDataEvent;
    public OwnerForm()
    {
        InitializeComponent();

        ownerService = new OwnerService();

        ReaLoadDataEvent += FillDataGridView;
        ReaLoadDataEvent.Invoke(ownerService.GetAll());
    }



    private void registerButton_Click(object sender, EventArgs e)
    {

        // data collect from owner
        string firstName = firstNameTextBox.Text;
        string lastName = lastNameTextBox.Text;
        string nationalCode = nationalCodeTextBox.Text;
        string phoneNumber = phoneNumberTextBox.Text;
        string password = passwordtextBox5.Text;
        string userName = userNametextBox6.Text;

        nationalCode.FormatNationalCode();
        DateTime birthDate = birthdateTimePicker1.Value;

        //validation
        if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
        {
            MessageBox.Show("please  enter true phonenumber");
        }
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            MessageBox.Show("please  enter true information");

            return;
        }

        //object
        //object owner ra dorost kn va be oon code ownerservoce.add(owner ) objectet ra ezafe knn
        Owner owner = new Owner
        {
            Id = 1,
            LastName = lastName,
            FirstName = firstName,
            NationalCode=nationalCode,
            PhoneNumber=phoneNumber,
            Password = password,
            UserName = userName,

        };

        //object
        Owner owner1 = new Owner(nationalCode: "", phoneNumber: "");
        owner.CreatedAt = DateTime.Now;
        owner.BirthDate = DateTime.Now.AddDays(5);

        //object add to collection//dar inja obj owner ra be service ezafe miknim
        ownerService.Add(owner);
        //show data
        FillDataGridView(ownerService.GetAll());
        //reset my form
        ResetForm();
    }


    internal void FillDataGridView(List<Owner> myowners)
    {
        OwnerdataGridView1.DataSource = null;
        OwnerdataGridView1.DataSource = myowners;
        OwnerdataGridView1.Refresh();
        MessageBox.Show("record updated succesfully");
        ResetForm();
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

    private void OwnerdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            // get the current row
            var row = OwnerdataGridView1.Rows[e.RowIndex];
            //access the id from the row's data
            SelectedOwnerId=int.Parse(row.Cells["Id"].Value.ToString());

            firstNameTextBox.Text = row.Cells["FirstName"].Value?.ToString();
            lastNameTextBox.Text = row.Cells["LastName"].Value?.ToString();
            phoneNumberTextBox.Text = row.Cells["PhoneNumber"].Value?.ToString();
            nationalCodeTextBox.Text = row.Cells["NationalCode"].Value?.ToString();
            userNametextBox6.Text = row.Cells["UserName"].Value?.ToString();
            passwordtextBox5.Text = row.Cells["Passsword"].Value?.ToString();



        }
    }

    private void OwnerdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void OwnerForm_Load(object sender, EventArgs e)
    {

    }

    private void DeleteButton1_Click(object sender, EventArgs e)
    {
        //need id use


        //service call
        ownerService.Delete(SelectedOwnerId);




        if (SelectedOwnerId == 0)
        {
            MessageBox.Show("please select row");
            return;


        }
    }

    private void updatebutton3_Click(object sender, EventArgs e)
    {
        // collect data from owner
        string firstName = firstNameTextBox.Text;
        string lastName = lastNameTextBox.Text;
        string nationalCode = nationalCodeTextBox.Text;
        string phoneNumber = phoneNumberTextBox.Text;
        string password = passwordtextBox5.Text;
        string userName = userNametextBox6.Text;
        //validation
        if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
        {
            MessageBox.Show("please enter valid phonenumber");
            return;
        }
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {


            MessageBox.Show("please enter valid phonenumber");
            return;

        }
        if (SelectedOwnerId == 0)
        {
            MessageBox.Show("please select row");
            return;
        
        
        }
        //object
        Owner owner = new Owner
        {
            Id =SelectedOwnerId,
            FirstName = firstName,
            LastName = lastName,
            //az ostad bporsam chera nemishe inaro baraye nationalcode va phonenumber nevesht


        };

        //obj add to collection 
        ownerService.Update(owner);
        






    }
}
