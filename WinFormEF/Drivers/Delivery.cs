using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEF.Customers;

namespace WinFormEF.Drivers
{
    public class Delivery
    {


        public int DeliveryId { get; set; }


        public int DriverId { get; set; }
        public int OrdersId { get; set; }

        public Driver Driver { get; set; }
        public Orders Order { get; set; }




        public DateTime DeliveryDate { get; set; }

        public string customersName { get; set; }

        public string customersAddress { get; set; }


    }
}
