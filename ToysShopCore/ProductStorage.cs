using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShopCore
{
    public class ProductStorage
    {
        List<Product> Products { get; set; }

        public ProductStorage()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void RemoveByName(string name)
        {
            Products.RemoveAll(p => p.Name == name);
        }

        public void ReadFromFile(string path)
        {
            Products.Clear();
            try
            {
                using var reader = new StreamReader(path);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    Products.Add(new Product(str));
                }
            }
            catch (Exception) { }
        }

        public void WriteInFile(string path)
        {
            using var writer = new StreamWriter(path, false);
            foreach (var product in Products)
            {
                writer.WriteLine(product);
            }
        }
    }
}
