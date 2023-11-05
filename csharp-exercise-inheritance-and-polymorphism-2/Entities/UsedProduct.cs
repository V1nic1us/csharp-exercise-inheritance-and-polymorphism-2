using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_inheritance_and_polymorphism_2.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacture) : base(name, price)
        {
            Name = name;
            Price = price;
            Manufacture = manufacture;
        }

        public override string priceTag()
        {
            return $"{Name} (Used) R$ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {Manufacture.Date})";
        }
    }
}
