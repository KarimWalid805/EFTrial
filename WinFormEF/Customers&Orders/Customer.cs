using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEF.CatPro;

namespace WinFormEF.Customers
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string Address { get; set; }



        public virtual ObservableCollectionListSource<Orders> Orders { get; } = new();
    }
}
