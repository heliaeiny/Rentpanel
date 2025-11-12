using BaseBackend.Abstraction;


namespace BaseBackend.Models;

public class Owner : BaseEntity
{
    public Owner() : base()
    { }
    public Owner(string nationalCode, string phoneNumber)
    {
        if (string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(phoneNumber))
        {
            throw new Exception();
        }
        NationalCode = nationalCode;
        phoneNumber = phoneNumber;

    }
    public Owner(string nationalCode,string phoneNumber,string firstname, string lastname ,DateTime birthDate):this(nationalCode,phoneNumber)
    {
       _birthDate= birthDate;
        FirstName = firstname;
        LastName = lastname;


    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }

    public int Age
    {
        get
        {

            if (_birthDate == DateTime.MinValue)
            {
                throw new Exception();
            }
            return DateTime.Now.Year - -BirthDate.Year;

        }
    }
    private int _email;
    public int Email
    {
        get { return _email; }
        set { _email = value; }
    }

    private DateTime _birthDate;
    public DateTime BirthDate
    {
        get { return _birthDate; }
        set { _birthDate = value; }
    }
}
