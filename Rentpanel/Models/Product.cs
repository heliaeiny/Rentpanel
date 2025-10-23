using Rentpanel.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class Product : BaseEntity
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


    }
}
