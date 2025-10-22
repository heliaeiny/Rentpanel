using Rentpanel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Models
{
    internal class Owner : BaseEntity
    {
        public Owner (string nationalCode , string phoneNumber, string lastName, string firstname)
        { 
         
        
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

      //  private int _email;
        //public int Email
        //{
          //  get { return _email; }
            //set { _email = value; }
        //}
    }


}
