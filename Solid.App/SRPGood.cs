using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.Good
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
    }

    public class ProductRepository
    {
        private static List<Product> productList = new List<Product>();

        public List<Product> GetProducts => productList;


        public ProductRepository()
        {
            productList = new()
            {
                new(){Id=1, Name="Kalem 1"},
                new(){Id=2, Name="Kalem 2"},
                new(){Id=3, Name="Kalem 3"},
                new(){Id=4, Name="Kalem 4"},
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = productList.Any(p => p.Id == product.Id);

            if (!hasProduct)
            {
                productList.Add(product);
            }
            else
            {
                var index = productList.FindIndex(x => x.Id == product.Id);

                productList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = productList.Find(x => x.Id == id);

            if (hasProduct == null)
            {
                throw new Exception("Ürün bulunamadı.");
            };

            productList.Remove(hasProduct);

        }

    }

    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> productList)
        {
            productList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} - {x.Name} ");
            });
        }
    }
}
