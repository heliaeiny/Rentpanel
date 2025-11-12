using BaseBackend.Abstraction;

namespace BaseBackend.Models;

public class Payment : BaseEntity
{
    public Payment() : base()
    { }
    public  string OnlinePayment{  get; set; }
    public string GhestiPayment{  get; set; }
    public string FrooshHouzooriPayment { get; set; }
    public DateTime CreatedAt { get; set; }
    public Order order { get; set; }
    //چطوری روی payment را در این بنویسم 















}
