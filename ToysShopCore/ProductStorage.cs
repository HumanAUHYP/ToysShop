using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShopCore
{
    class ProductStorage
    {
        List<Product> Products { get; set; }

        public ProductStorage()
        {
            Products = new List<Product>();
        }

        public void ReadFromFile(string path)
        {
            Products.Clear();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Products.Add(new Product(str));
                    }
                }
            }
            catch (Exception) { }
        }

        public void WriteInFile(string path)
        {
            using (var writer = new StreamWriter(path, false))
            {
                foreach (var product in Products)
                {
                    writer.WriteLine(product);
                }
            }
        }
    }
}
