using BaseBackend.Enums;
using BaseBackend.Models;
using BaseBackend.Services;

namespace Rentpanel.Forms;

public partial class CodeTakhfifForm : Form
{
    public CodeTakhfifForm()
    {
        InitializeComponent();
    }

    //vaghti ke tooye form load chizi minevisim yani dar shooroo form in method etefagh miofte
    //va IN  Behtarin zaman baraye por shdan combobox hast
    private void CodeTakhfifForm_Load(object sender, EventArgs e)
    {


    }

    private void CodeTakhfifTypecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void EnterClickButton_Click(object sender, EventArgs e)
    {
        string Code = CodeTakhfiftextBox1.Text;
        //az oonjaei ke CodeTakhfifTypecomboBox1 strin g barmigardoone va TakhfifStatus,enum barmigardoone
        //pas az parse etefade mikonim 
        TakhfifStatus Type = (TakhfifStatus)Enum.Parse(typeof(TakhfifStatus), CodeTakhfifTypecomboBox1.Text);


      //  CodeTakhfif codetakhfif = new CodeTakhfif(Type = type, Code = code)
        //{

        //};

       // CodeTakhfif codetakhfif1 = new CodeTakhfif(Type: "", Code: "");

        List<CodeTakhfif> codeTakhfifs = new List<CodeTakhfif>();

        CodeTakhfifdataGridView1.DataSource = null;
        CodeTakhfifdataGridView1.DataSource = codeTakhfifs;
        CodeTakhfifdataGridView1.Refresh();

        ResetForm();
    }

    private void ResetCLickbutton_Click(object sender, EventArgs e)
    {
        string Code = CodeTakhfiftextBox1.Text;
        //az oonjaei ke CodeTakhfifTypecomboBox1 strin g barmigardoone va TakhfifStatus,enum barmigardoone
        //pas az parse etefade mikonim 
        TakhfifStatus Type = (TakhfifStatus)Enum.Parse(typeof(TakhfifStatus), CodeTakhfifTypecomboBox1.Text);

        ResetForm();
    }
    private void ResetForm()
    {
        CodeTakhfiftextBox1.Text = null;
        CodeTakhfifTypecomboBox1.Text = null;

    }
}
