using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_inheritance_and_polymorphism_2.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"{Name} R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
