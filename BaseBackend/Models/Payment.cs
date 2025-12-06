using BaseBackend.Abstraction;

namespace BaseBackend.Models;

public class Payment : BaseEntity
{
    public Payment() : base()
    { }
    public  string CurrentPrice {  get; set; }
    public string GhestiPayment{  get; set; }
    public string FrooshHouzooriPayment { get; set; }
    public DateTime CreatedAt { get; set; }
    public Order order { get; set; }
    
    public int  OrderId { get; set; }
    //چطوری روی payment را در این بنویسم 















}
