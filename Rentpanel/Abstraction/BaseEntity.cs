using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Abstraction
{
    public abstract  class BaseEntity
    {
      //  public BaseEntity()

        //{ 
          //  CreatedAt = DateTime.Now;
        
        //}

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
