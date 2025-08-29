using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEF.CatPro;

namespace WinFormEF.Customers
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public string Address { get; set; }

        public DateTime orderDate { get; set; }


        public string products_list { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;

    }
}
