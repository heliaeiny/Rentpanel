using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentpanel.Enums
{
    internal enum  OrderStatus
    {
        None = 0,
        Approved = 1,
        Paid_Completed = 2,
        Processing = 3,
        Canceled = 4,
        Delivered = 5,
    }
}
