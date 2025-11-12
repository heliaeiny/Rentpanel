using BaseBackend.Interface;
using BaseBackend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.Interface;

namespace BaseBackend.Services
{

    public class OwnerService : BaseService<Owner>
    {
        List<Owner> owners = new();
        public void Add(Owner owner)
        {
            owners.Add(owner);
        }
        public List<Owner> GetAll()
        {
            return owners;
        }



    }



}

