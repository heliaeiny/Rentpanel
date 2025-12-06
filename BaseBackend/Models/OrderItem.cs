using BaseBackend.Abstraction;
using System;
using System.Collections.Generic;


namespace BaseBackend.Models;

public class OrderItem : BaseEntity
{
    public OrderItem() : base()
    { }
    public Order Order { get; set; }
    
    public int OrderId { get; set; }
    public Product product { get; set; }
    public int ProductId { get; set; }
    public decimal CurrentPrice { get; set; }
    public int Count { get; set; }
}
