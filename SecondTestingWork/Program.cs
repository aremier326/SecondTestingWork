using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestingWork
{
    class Program
    {

        static void Main(string[] args)
        {
            //Initialising of list.
            List<Product> products = new List<Product>()
            {
                new Product{ Name = "Braun", Price = 500, Availability = 100, ExpDate = 2020},
                new Product{ Name = "Apple", Price = 5000, Availability = 231, ExpDate = 2022},
                new Product{ Name = "Samsung", Price = 4000, Availability = 132, ExpDate = 2021},
                new Product{ Name = "Huawei", Price = 3000, Availability = 746, ExpDate = 2020}
            };

            // Initialising of dictionary.
            Dictionary<string, Func<List<Product>, List<Product>>> dictionary = new Dictionary<string, Func<List<Product>, List<Product>>>
            {
                ["NameSort"] = SortByProdName,
                ["PriceSort"] = SortByPrice,
                ["AvailabilitySort"] = SortByAvailability,
                ["ExpDateSort"] = SortByExpDate
            };

            dictionary["PriceSort"](products);
            dictionary["AvailabilitySort"](products);
            
            Console.ReadLine();

        }

        // Method for ouputting list of products
        private static void ShowProducts(List<Product> products)
        {
            foreach (var prod in products)
            {
                Console.WriteLine(prod.ToString());
            }
            Console.WriteLine();
        }

        // Method for sorting products by name.
        public static List<Product> SortByProdName(List<Product> products)
        {
            Console.WriteLine("Sort by name.");
            products.Sort();
            ShowProducts(products);
            return products;
        }

        // Method for sorting products by price.
        public static List<Product> SortByPrice(List<Product> products)
        {
            Console.WriteLine("Sort by price.");
            products.Sort(new PriceComparer());
            ShowProducts(products);
            return products;
        }

        // Method for sorting products by availability.
        public static List<Product> SortByAvailability(List<Product> products)
        {
            Console.WriteLine("Sort by availability.");
            products.Sort(new AvailabilityComparer());
            ShowProducts(products);
            return products;
        }

        // Method for sorting products by exp date.
        public static List<Product> SortByExpDate(List<Product> products)
        {
            Console.WriteLine("Sort by exp date.");
            products.Sort(new ExpiryDateComparer());
            ShowProducts(products);
            return products;
        }

    }
}
