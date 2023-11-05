using System.Globalization;
using csharp_exercise_inheritance_and_polymorphism_2.Entities;

namespace csharp_exercise_inheritance_and_polymorphism_2
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeProduct == 'i')
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (typeProduct == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY)");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufacture));
                }
            }

            Console.WriteLine("Price Tags");
            foreach (var product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}

