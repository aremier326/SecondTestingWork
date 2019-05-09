using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestingWork
{
    // Class for comparing ExpDate.
    class ExpiryDateComparer : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product x, Product y)
        {
            if (x.ExpDate > y.ExpDate) return 1;
            if (x.ExpDate < y.ExpDate) return -1;
            else return 0;
        }
    }
}
