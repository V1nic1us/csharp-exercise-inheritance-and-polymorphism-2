using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_inheritance_and_polymorphism_2.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return $"{Name} R${totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: {CustomsFee})";
        }
    }
}
