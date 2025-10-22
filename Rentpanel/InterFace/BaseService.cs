using Rentpanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.InterFace
{
    internal interface BaseService<T>
    {
        void Add(T item);

        List<T> GetAll();

    }
}
