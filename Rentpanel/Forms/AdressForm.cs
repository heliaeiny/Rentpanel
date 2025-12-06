using BaseBackend.Models;
using BaseBackend.Services;

namespace Rentpanel.Forms;

public partial class AdressForm : Form
{
    AdressService adressService;
    public AdressForm()
    {
        InitializeComponent();
        adressService = new AdressService();
        //baraye adress bayaddatagridview bsazam
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

        Adress adress = new Adress(street = street, city = city)
        {
            PostalCode = postalCode,
            HouseNumber = houseNumber,
            Floor = floor,
            Title = title,
           
        };

        Adress adress1 = new Adress(city: "", street: "");

        List<Adress> adresses = new List<Adress>();
        adressdataGridView1.DataSource = null;
        adressdataGridView1.DataSource = adresses;
        adressdataGridView1.Refresh();


        ResetForm();


    }

    private void resetRejisterbutton2_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    private void ResetForm()
    {
        alleytextBox.Text = null;
        postalcodetextBox2.Text = null;
        housenumbertextBox3.Text = null;
        flooertextBox4.Text = null;
        pelaktextBox5.Text = null;
        streettextBox6.Text = null;
        citytextBox7.Text = null;
        titletextBox8.Text = null;

    }

    private void Removebutton1_Click(object sender, EventArgs e)
    {

    }

    private void AdressForm_Load(object sender, EventArgs e)
    {

    }
}
