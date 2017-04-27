using DbCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateData();
        }
        private static void CreateData()
        {
            var products = CreateListOfProducts(20, 40);
            var shops = CreateListOfShops(5, 20);
            Shuffle(shops, products);
            using (var db = new ShopDbContext())
            {
                db.Shops.AddRange(shops);
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }
        private static List<Shop> CreateListOfShops(int minCount, int maxCount)
        {
            var lShops = new List<Shop>();
            var shopsCount = new Random();
            for (int i = 1; i <= shopsCount.Next(minCount, maxCount); i++)
            {
                lShops.Add(new Shop()
                {
                    ShopName = @"Магазин №" + i.ToString(),
                    ShopAddress = @"Адрес магазина №" + i.ToString(),
                    WorkingTime = @"Время работы магазина №" + i.ToString(),
                });
            }
            return lShops;
        }

        private static List<Product> CreateListOfProducts(int minCount, int maxCount)
        {
            var lProducts = new List<Product>();
            var productsCount = new Random();
            for (int i = 1; i <= productsCount.Next(minCount, maxCount); i++)
            {
                lProducts.Add(new Product()
                {
                    ProductName = @"Товар №" + i.ToString(),
                    ProductDescription = @"Описание товара №" + i.ToString(),
                });
            }
            return lProducts;
        }

        private static void Shuffle(IEnumerable<Shop> shops, IEnumerable<Product> products)
        {
            var productsCount = new Random();
            foreach (var shop in shops)
            {
                foreach (var product in products.OrderBy(a => Guid.NewGuid()).Take(productsCount.Next(products.Count())))
                {
                    shop.Products.Add(product);
                    product.Shops.Add(shop);
                }
            }
        }
    }
}
