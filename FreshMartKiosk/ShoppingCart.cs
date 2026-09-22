using System.Collections.Generic;
using System.Linq;

namespace FreshMartKiosk
{
    public class ShoppingCart
    {
        public List<CartItem> Items = new List<CartItem>();
        public List<Product> Catalog = new List<Product>
        {
            new Product{ ProductId="P001", ProductName="Coca-Cola Original 1.5L x2", Price=32.99m, Category="Beverages", Barcode="P001", Stock=50 },
            new Product{ ProductId="P002", ProductName="Top Red Apples 1.5kg", Price=39.99m, Category="Produce", Barcode="P002", Stock=50 },
            new Product{ ProductId="P003", ProductName="Albany Low GI Brown Bread 700g", Price=19.99m, Category="Bakery", Barcode="P003", Stock=50 },
            new Product{ ProductId="P004", ProductName="Nulaid 18 Jumbo Eggs", Price=89.99m, Category="Dairy", Barcode="P004", Stock=50 },
            new Product{ ProductId="P005", ProductName="Clover Cheddar Cheese 100g", Price=22.99m, Category="Dairy", Barcode="P005", Stock=50 },
            new Product{ ProductId="P006", ProductName="Tastic Long Grain Rice 2kg", Price=55.99m, Category="Pantry", Barcode="P006", Stock=50 },
            new Product{ ProductId="P007", ProductName="B-well Canola Oil 750ml", Price=45.99m, Category="Pantry", Barcode="P007", Stock=50 },
            new Product{ ProductId="P008", ProductName="Fresh Chicken Braai Pack", Price=79.99m, Category="Meat", Barcode="P008", Stock=50 },
            new Product{ ProductId="P009", ProductName="Brown Sugar 500g" , Price=18.99m, Category="Pantry", Barcode="P009", Stock=50 },
            new Product{ ProductId="P010", ProductName="Bananas 1kg", Price=24.99m, Category="Produce", Barcode="P010", Stock=50 },
            new Product{ ProductId="P011", ProductName="Oranges 1.5kg", Price=29.99m, Category="Produce", Barcode="P011", Stock=50 },
            new Product{ ProductId="P012", ProductName="Clover Tropika 2L", Price=38.99m, Category="Beverages", Barcode="P012", Stock=50 },
            new Product{ ProductId="P013", ProductName="Butchers Best Steak Pack", Price=129.99m, Category="Meat", Barcode="P013", Stock=50 },
            new Product{ ProductId="P014", ProductName="Simba Tomato Sauce Chips 120g", Price=21.99m, Category="Snacks", Barcode="P014", Stock=50 },
            new Product{ ProductId="P015", ProductName="Vanilla Cream Cake", Price=149.99m, Category="Bakery", Barcode="P015", Stock=50 },
            new Product{ ProductId="P016", ProductName="Seafood Platter Mix", Price=199.99m, Category="Seafood", Barcode="P016", Stock=50 },
        };

        public Product FindProductByBarcode(string c)
        {
            if (string.IsNullOrWhiteSpace(c)) return null;
            return Catalog.FirstOrDefault(p => p.Barcode.ToLower() == c.Trim().ToLower() || p.ProductId.ToLower() == c.Trim().ToLower());
        }

        public bool AddProduct(Product product, int quantity)
        {
            int currentCount = Items.Sum(i => i.Quantity);
            if (currentCount + quantity > 10) return false;
            var existing = Items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (existing != null) existing.Quantity += quantity;
            else Items.Add(new CartItem { Product = product, Quantity = quantity });
            return true;
        }

        public void RemoveProduct(string id) { Items.RemoveAll(i => i.Product.ProductId == id); }
        public void ClearCart() { Items.Clear(); }
        public decimal CalculateSubtotal() { return Items.Sum(i => i.TotalPrice); }
    }
}