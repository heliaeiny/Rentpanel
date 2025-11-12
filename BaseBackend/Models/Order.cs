using BaseBackend.Abstraction;
using BaseBackend.Enums;


namespace BaseBackend.Models;

public class Order : BaseEntity
{


    public Order() : base()
    { }
    public Order( string adress , string  SendAt) 
    {
        if (string.IsNullOrEmpty(adress) || string.IsNullOrEmpty(SendAt))
        {
            throw new Exception();
        }
        //az ostad bporsam inke kodesh datatypesh adresse hala chejuri jniha bnvisamesh
        //
        //Adress = adress;
        SendAt = SendAt;
      
    }
    public Owner Owner {  get; set; }   
    public decimal CurrentPrice { get; set; } 
    public List<OrderItem> orderItems { get; set; }
    public Product Product { get; set; }
    public DateTime CreatedAt { get; set; }
    public Adress? Adress { get; set; }
    public DateTime? SendAt { get; set; }
    public OrderStatus status { get; set; }
    public string? DeliveryPhoneNumber { get; set; }
    public string? DeliveryFullName { get; set; }

}
