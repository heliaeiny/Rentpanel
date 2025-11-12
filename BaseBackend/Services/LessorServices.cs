using BaseBackend.Interface;
using BaseBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Services
{
    public class LessorServices :BaseService<Lessor>
    {
        List<Lessor> lessors = new();

        public void Add(Lessor lessor)
        {
            lessors.Add(lessor);

        }
        public List<Lessor> GetAll()
        {
            return lessors;
        }
    }
}
