using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormEF.Orders
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string Address { get; set; }

        public string orderDate { get; set; }

        public int CustomerId { get; set; }


        public string products_list { get; set; }


    }
}
