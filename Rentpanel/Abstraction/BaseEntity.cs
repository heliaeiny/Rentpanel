using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Abstraction
{
    internal abstract  class BaseEntity
    {
       public BaseEntity()

        { 
           CreatedAt = DateTime.Now;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
