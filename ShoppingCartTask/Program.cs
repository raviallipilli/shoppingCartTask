using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTask
{
    class Program
    {
        static void Main(string[] args)

        {
            string apples;
            string oranges;
            decimal total;
            decimal appleTotal;
            decimal orangeTotal;

            //User inputs
            Console.WriteLine("Welcome to Fruit Shop");
            Console.WriteLine("\nFruit Menu \nApples ----------------- .60p \nOranges ---------------- .25p  \n<Press any key to continue>");

            Console.ReadKey();

            // enter apples
            Console.Write("Please enter the quantity (in number) for Apples: ");
            apples = Console.ReadLine();

            // enter oranges
            Console.Write("Please enter the quantity (in number) for Oranges: ");
            oranges = Console.ReadLine();

            appleTotal = 0.60m * Convert.ToDecimal(apples);
            orangeTotal = 0.25m * Convert.ToDecimal(oranges);

            total = Convert.ToDecimal(appleTotal) + Convert.ToDecimal(orangeTotal);

            Console.Write("\nThank you for shopping with us: ");
            Console.WriteLine("\nYour Total cost : " + "£" + total);
        }
    }
}
