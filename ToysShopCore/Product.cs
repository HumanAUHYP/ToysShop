using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShopCore
{
    class Product
    {
        public string Name { get; private set; }
        string Description { get; set; }
        string Distributor { get; set; }
        string Price { get; set; }
        bool Actually { get; set; }
        int Count { get; set; }

        public Product(string str)
        {
            var data = str.Split(';');
            Name = data[0];
            Description = data[1];
            Distributor = data[2];
            Price = data[3];
            Actually = bool.Parse(data[4]);
            Count = int.Parse(data[5]);
        }

        public override string ToString()
        {
            return $"{Name};{Description};{Distributor};{Price};{Actually};{Count}";
        }
    }
}
