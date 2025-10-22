using Rentpanel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class OrderItem : BaseEntity
    {
        
        public Order Order { get; set; }
        public Product product { get; set; }
        public decimal CurrentPrice { get; set; }
        public int Count { get; set; }
    }
}
