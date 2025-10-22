using Rentpanel.Abstraction;
using Rentpanel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class Order : BaseEntity
    {
        public Order()
        {
        }

        public Order(string adress , string SendAt) 
        {
        
        }
        public Owner Owner {  get; set; }   
        public decimal CurrentPrice { get; set; } 
        //public List<OrderItem> Product { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Count { get; set; }
        public Adress? Adress { get; set; }
        public DateTime? SendAt { get; set; }
        public OrderStatus status { get; set; }
        public string? DeliveryPhoneNumber { get; set; }
        public string? DeliveryFullName { get; set; }

    }
}
