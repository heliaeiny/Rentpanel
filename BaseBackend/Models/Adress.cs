using BaseBackend.Abstraction;


namespace BaseBackend.Models;

public class Adress : BaseEntity
{
      public Adress() : base()
     { }
    public Adress(string city, string street)
    {
        if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(street))
        {
            throw new Exception();
        }

        City=city;
        Street=street;
    }
    public string Alley { get; set; }
    public string PostalCode { get; set;}     
    public string HouseNumber { get; set; }
    public string Floor {  get; set;}
    public string Pelak { get; set;}
    public string Street { get; set;}
    public string City { get; set;}
    public string Title { get; set;}

}
