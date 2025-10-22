using Rentpanel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class Payment : BaseEntity
    {

        public  string OnlinePayment{  get; set; }
        public string GhestiPayment{  get; set; }
        public string FrooshHouzooriPayment { get; set; }
        public DateTime CreatedAt { get; set; }
        public Order order { get; set; }
        //چطوری روی payment را در این بنویسم 















    }
}
