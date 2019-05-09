using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestingWork
{
    // Class for comparing price.
    class PriceComparer : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product x, Product y)
        {
            if (x.Price > y.Price) return 1;
            if (x.Price < y.Price) return -1;
            else return 0;
        }
    }
}
