using BaseBackend.Abstraction;


namespace BaseBackend.Models;

public class Product : BaseEntity
{

    public Product() : base()
    { }
    public Product(string name, string code)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code))
        {
            throw new Exception();
        }
        
        Name = name;
        Code = code;
    }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public bool IsSellable { get; set; }
    public decimal Price { get; set; }
   public CodeTakhfif CodeTakhfif { get; set; }
    public int CodeTakhfifId { get; set; }

}
