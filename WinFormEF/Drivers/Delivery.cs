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

        public virtual ObservableCollectionListSource<Orders> OrderId { get; } = new();

        public int DriverId { get; set; }

        public string customersName { get; set; }

        public string customersAddress { get; set; }

    }
}
