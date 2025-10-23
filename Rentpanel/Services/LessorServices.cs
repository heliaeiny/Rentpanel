using Rentpanel.InterFace;
using Rentpanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Services
{
    internal class LessorServices :BaseService<Lessor>
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
