using Rentpanel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class Adress : BaseEntity
    {
      //  public Adress() : base()
       // { }
        public string Alley { get; set; }
        public string PostalCode { get; set;}     
        public string HouseNumber { get; set; }
        public string Floor {  get; set;}
        public string Pelak { get; set;}
        public string Street { get; set;}
        public string City { get; set;}
        public string Title { get; set;}

    }

}
