using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestingWork
{
    class Product : IComparable<Product>
    {
        // Public properties.
        public string Name { get; set; }
        public double Price { get; set; }
        public int Availability { get; set; }
        public int ExpDate { get; set; }

        // Overriden method ToString().
        public override string ToString()
        {
            return string.Format($"Product Name = {Name}, Price = {Price:f2}, Availability = {Availability}, Exp Date = {ExpDate}.");
        }

        // Method for comparing Names.
        int IComparable<Product>.CompareTo(Product other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
