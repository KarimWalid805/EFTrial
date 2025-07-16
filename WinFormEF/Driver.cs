using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormEF
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public string vehicleType { get; set; }

    }
}

