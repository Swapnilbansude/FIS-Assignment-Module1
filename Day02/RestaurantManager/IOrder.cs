using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    interface IOrder
    {
        int ID { get; set; }
        string Status { get; set; }

        void Confirm();
    }
}
