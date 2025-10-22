using Rentpanel.InterFace;
using Rentpanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Services
{
    internal class ProductServices : BaseService<Product>
    { 

        public List<Product> Product { get; set; }

        public void Add(Product product)
        { 

        }
        public List<Product> GetAll()
        {
            return Product;
        }
    }
}
