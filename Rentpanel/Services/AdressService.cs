using Rentpanel.InterFace;
using Rentpanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Services
{
    internal class AdressService : BaseService<Adress>
    {
        List<Adress> adresses = new();
        public void Add(Adress address)
        {
            adresses.Add(address);
        }
        public List<Adress> GetAll()
        {
            return adresses;
        }




    }
}
