﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestingWork
{
    // Class for comparing of availability.
    class AvailabilityComparer : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product x, Product y)
        {
            if (x.Availability > y.Availability) return 1;
            if (x.Availability < y.Availability) return -1;
            else return 0;
        }
    }
}
