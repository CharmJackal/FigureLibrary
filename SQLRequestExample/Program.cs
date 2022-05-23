using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace SQLRequestExample
{
    class Program
    {

        private class Product
        {
            public string ProductName;

            public int CategoryId;
        }

        private class Category
        {
            public int Id;

            public string CategoryName;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("IT's classic left join look like getting from https://docs.microsoft.com/en-us/office/client-developer/access/desktop-database-reference/left-join-right-join-operations-microsoft-access-sql" +
                              "SELECT ProductName, CategoryName" +
                              "FROM Products LEFT JOIN Categories" +
                              "ON Products.CategoryId = Categories.Id");

            var categories = new List<Category>() { new Category() { CategoryName = "Машина", Id = 1 } };
            var products = new List<Product>()
            {
                new Product() { CategoryId = 1, ProductName = "Лада души отрада" },
                new Product() { CategoryId = 2, ProductName = "Мяч" }
            };

            var query =
                from pr in products
                join cat in categories on pr.CategoryId equals cat.Id into gj
                from subcat in gj.DefaultIfEmpty()
                select new
                {
                    pr.ProductName,
                    CategoryName = subcat?.CategoryName ?? string.Empty
                };

            foreach (var product in query)
            {
                Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
            }
        }
    }
}
