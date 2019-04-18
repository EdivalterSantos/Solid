using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Demo
    {
         public static void Main(string[] args)
        {
            var apple = new Product("Apple", Enums.Color.Green, Enums.Size.Medium);
            var tree = new Product("Tree", Enums.Color.Green, Enums.Size.Large);
            var house = new Product("House", Enums.Color.Blue, Enums.Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green Products (old): ");

            foreach(var p in pf.FilterByColor(products, Enums.Color.Green))
            {
                Console.WriteLine($"- {p.Name} Is green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Grenn Products (New)");

            foreach (var p in bf.Filter(products, new ColorSpecification(Enums.Color.Green)))
            {
                Console.WriteLine($" {p.Name} is green");
            }

            Console.WriteLine("Large blue items");
            foreach  (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Enums.Color.Blue), new SizeSpecification(Enums.Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is big and Blue");
            }

            Console.ReadLine();   
        }
    }
}
