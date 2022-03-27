using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShopCore
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Distributor { get; set; }
        public int Price { get; set; }
        public bool Actually { get; set; }
        public int Count { get; set; }

        public Product() { }

        public Product(string[] prodParamsArray)
        {
            int i = 0;
            Name = prodParamsArray[i++];
            Description = prodParamsArray[i++];
            Distributor = prodParamsArray[i++];
            Price = int.Parse(prodParamsArray[i++]);
            Actually = bool.Parse(prodParamsArray[i++]);
            Count = int.Parse(prodParamsArray[i++]);
        }

        public Product(string str)
        {
            var data = str.Split(';');
            Name = data[0];
            Description = data[1];
            Distributor = data[2];
            Price = int.Parse(data[3]);
            Actually = bool.Parse(data[4]);
            Count = int.Parse(data[5]);
        }

        public override string ToString()
        {
            return $"{Name};{Description};{Distributor};{Price};{Actually};{Count}";
        }
    }
}
