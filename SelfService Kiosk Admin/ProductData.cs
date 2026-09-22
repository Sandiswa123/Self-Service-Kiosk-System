using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product
            {
                ProductId = "P001",
                ProductName = "Coca-Cola Original 1.5L x2",
                Price = 32.99m,
                Category = "Beverages",
                Barcode = "P001",
                Stock = 50,
                IsAvailable = true
            },

            new Product
            {
                ProductId = "P002",
                ProductName = "Top Red Apples 1.5kg",
                Price = 39.99m,
                Category = "Produce",
                Barcode = "P002",
                Stock = 50,
                IsAvailable = true
            },

            new Product
            {
                ProductId = "P003",
                ProductName = "Albany Low GI Brown Bread 700g",
                Price = 19.99m,
                Category = "Bakery",
                Barcode = "P003",
                Stock = 50,
                IsAvailable = true
            },

             new Product
            {
                ProductId = "P004",
                ProductName ="Nulaid 18 Jumbo Eggs" ,
                Price = 89.99m,
                Category = "Dairy",
                Barcode = "P004",
                Stock = 50,
                IsAvailable = true
            },

              new Product
            {
                ProductId = "P005",
                ProductName ="Clover Cheddar Cheese 100g",
                Price = 22.99m,
                Category = "Dairy",
                Barcode = "P005",
                Stock = 50,
                IsAvailable = true

            },

                new Product
            {
                ProductId = "P006",
                ProductName ="Tastic Long Grain Rice 2kg",
                Price = 55.99m,
                Category = "Pantry",
                Barcode = "P006",
                Stock = 50,
                IsAvailable = true
            },


                new Product
            {
                ProductId = "P007",
                ProductName ="B-well Canola Oil 750ml",
                Price = 45.99m,
                Category = "Pantry",
                Barcode = "P007",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P008",
                ProductName ="Fresh Chicken Braai Pack",
                Price = 79.99m,
                Category = "Meat",
                Barcode = "P008",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P009",
                ProductName ="Brown Sugar 500g",
                Price = 18.99m,
                Category = "Pantry",
                Barcode = "P009",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0010",
                ProductName ="Bananas 1kg",
                Price = 25.99m,
                Category = "Produce",
                Barcode = "P010",
                Stock = 50,
                IsAvailable = true
            },


                 new Product
            {
                ProductId = "P0011",
                ProductName ="Oranges 1.5kg",
                Price = 29.99m,
                Category = "Produce",
                Barcode = "P011",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0012",
                ProductName ="Clover Tropika 2L",
                Price = 38.99m,
                Category = "Beverages",
                Barcode = "P012",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0013",
                ProductName ="Butchers Best Steak Pack",
                Price = 129.99m,
                Category = "Meat",
                Barcode = "P013",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0014",
                ProductName ="Simba Tomato Sauce Chips 120g",
                Price = 21.99m,
                Category = "Snacks",
                Barcode = "P014",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0015",
                ProductName ="Vanilla Cream Cake",
                Price = 149.99m,
                Category = "Bakery",
                Barcode = "P015",
                Stock = 50,
                IsAvailable = true
            },

                 new Product
            {
                ProductId = "P0016",
                ProductName ="Top Red Apples 1.5kg",
                Price = 39.99m,
                Category = "Produce",
                Barcode = "P015",
                Stock = 50,
                IsAvailable = true
            },

        };
        public static void LoadAvailability()
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(folder, "availability.txt");

            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    string productCode = parts[0];

                    bool available;

                    if (bool.TryParse(parts[1], out available))
                    {
                        Product product = Products.FirstOrDefault(
                            p => p.ProductId == productCode);

                        if (product != null)
                        {
                            product.IsAvailable = available;

                            if (available)
                            {
                                product.Stock =50;
                            }
                            else
                            {
                                product.Stock = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
