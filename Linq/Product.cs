using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;

namespace Linq_QUERY
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Rating { get; set; }
        public int SupplierId { get; set; }
        public class Supplier
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Product> pro = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Brand = "Dell",
                    Category = "Electronics",
                    Price = 800.00m,
                    Stock = 10,
                    Rating = 4.5,
                    SupplierId = 101

                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Brand = "Samsung",
                    Category = "Electronics",
                    Price = 600.00m,
                    Stock = 20,
                    Rating = 4.2,
                    SupplierId = 102
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Brand = "Sony",
                    Category = "Electronics",
                    Price = 150.00m,
                    Stock = 15,
                    Rating = 4.0,
                    SupplierId = 103
                },
                 new Product
                 {
                     Id = 4,
                    Name = "Refrigerator",
                    Brand = "LG",
                    Category = "Appliances",
                    Price = 1200.00m,
                    Stock = 5,
                    Rating = 4.3,
                    SupplierId = 104
                 },
                 new Product
                    {
                        Id = 5,
                        Name = "Microwave",
                        Brand = "Panasonic",
                        Category = "Appliances",
                        Price = 200.00m,
                        Stock = 8,
                        Rating = 4.1,
                        SupplierId = 105
                    }

            };
            var findAll = pro.Where(p => p.Price >= 7000).ToList();
            foreach (var item in findAll)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Brand: {item.Brand}, Category: {item.Category}, Price: {item.Price}, Stock: {item.Stock}, Rating: {item.Rating}, SupplierId: {item.SupplierId}");
            }
            var project = pro.Select(p => new
            {
                p.Name,
                p.Brand,
                p.Price
            });
            foreach (var item in project)
            {
                Console.WriteLine($"Name: {item.Name}, Brand: {item.Brand}, Price: {item.Price}");
            }

            //Sort products by Rating highest first, and if ratings are equal, sort by Price lowest first.
            var sortProducts = pro.OrderByDescending(p => p.Rating).ThenBy(p => p.Price).ToList();
            foreach (var item in sortProducts)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Brand: {item.Brand}, Category: {item.Category}, Price: {item.Price}, Stock: {item.Stock}, Rating: {item.Rating}, SupplierId: {item.SupplierId}");
            }
            //4. Find the product with Id = 5 
            Product? proId = pro.FirstOrDefault(p => p.Id == 5);
            if (proId != null)
            {
                Console.WriteLine($"Id: {proId.Id}, Name: {proId.Name}, Brand: {proId.Brand}, Category: {proId.Category}, Price: {proId.Price}, Stock: {proId.Stock}, Rating: {proId.Rating}, SupplierId: {proId.SupplierId}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            //5
            var productCost = pro.Any(p => p.Price > 100000);
            if (productCost)
            {
                Console.WriteLine("There is at least one product with a price greater than 100,000.");
            }
            else
            {
                Console.WriteLine("There are no products with a price greater than 100,000.");
            }
            var stock = pro.All(p => p.Stock > 0);
            if (stock)
            {
                Console.WriteLine("All products are in stock.");
            }
            else
            {
                Console.WriteLine("There are products that are out of stock.");
            }
            //6
            var proCategory = pro.Where (p=> p.Category == "Laptops").ToList();

            int allProCategory = proCategory.Count();
            Console.WriteLine($"Total products in category 'Laptops': {allProCategory}");

            int totalProCateory = pro.Sum(p => p.Category == "Laptops" ? 1 : 0);
            Console.WriteLine($"Total products in category 'Laptops': {totalProCateory}");

            decimal avgPrice =pro.Average(p => p.Category == "Laptops" ? p.Price : 0);
            Console.WriteLine($"Average price of products in category 'Laptops': {avgPrice}");

            int highestCategory = pro.Max(p=>p.Category == "Laptops" ? p.Stock : 0);
            Console.WriteLine($"Highest stock level in category 'Laptops': {highestCategory}");

            int lowestCategory = pro.Min(p => p.Category == "Laptops" ? p.Stock : 0);
            Console.WriteLine($"Lowest stock level in category 'Laptops': {lowestCategory}");

            //8. Return all unique product categories.

            //Expected conceptually:
            //Laptop
            //Phone
            //Tablet
            //Monitor

            var uniqueCategories = pro.Select(p=> p.Category).Distinct().ToList();
            Console.WriteLine("Unique product categories:");
            foreach (var category in uniqueCategories)
            {
                Console.WriteLine($"- {category}");
            }

            //7.7. Group products by Brand and return:
            //  Brand
            // ProductCount
            //AveragePrice
            //TotalStock
            //HighestRating

            //var groupPro = pro.GroupBy(p=>p.Brand).Select(g => new
            //{
            //    Brand = g.Key,
            //    ProductCount = g.Count(),
            //    AveragePrice = g.Average(p => p.Price),
            //    TotalStock = g.Sum(p => p.Stock),
            //    HighestRating = g.Max(p => p.Rating)
            //}).ToList();


            var productGroup = pro.GroupBy(p => p.Brand)
                .Select(
                    g => new
                    {
                        Brand = g.Key,
                        TotalProduct = g.Count(),
                        averagePrice = g.Average(p => p.Price),
                        totalStock = g.Sum(p=>p.Stock),
                        highestRating = g.Max(p => p.Rating)

                    }
                ).ToList();

            foreach(var item in productGroup)
            {
                Console.WriteLine($"Brand: {item.Brand}, Total Products: {item.TotalProduct}, Average Price: {item.averagePrice}, Total Stock: {item.totalStock}, Highest Rating: {item.highestRating}");
            }

            List<Supplier> suppliers = new()
            {
                new Supplier { Id = 1, Name = "Tech Distribution Ltd." },
                new Supplier { Id = 2, Name = "Digital Supply Co." },
                new Supplier { Id = 3, Name = "Global Devices Ltd." }
            };

            ////9Join products and suppliers and return:
            //  ProductName
            //Brand
            //SupplierName
            //Price

            var joinProducts = from productsSome in pro
                               join sup in suppliers
                               on productsSome.SupplierId
                               equals sup.Id
                               select new
                               {
                                 productsSome.Name,
                                productsSome.Brand,
                                SupplierName = sup.Name,
                                productsSome.Price


                               };


            foreach (var item in joinProducts)
            {
                Console.WriteLine($"Product Name: {item.Name}, Brand: {item.Brand}, Supplier Name: {item.SupplierName}, Price: {item.Price}");
            }

            //10. Find the top 3 highest-rated products that:
            //  -have at least 5 items in stock,
            //cost no more than 100000.
            //Return only:
            //Name
            //Category
            //Price
            //Rating
            var topRateProducts = pro.OrderByDescending(p => p.Rating).ThenBy(P => P.Price <= 100000).Select(p=> new {
                
                p.Name,
                p.Category,
                p.Price,
                p.Rating

            }).Take(3).ToList();
            foreach(var item in topRateProducts)
            {
                Console.WriteLine($"Name: {item.Name}, Category: {item.Category}, Price: {item.Price}, Rating: {item.Rating}");
            }
            

        } 
    }
}


