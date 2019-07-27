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
            decimal totalBeforeOffer;
            decimal totalAfterOffer;
            decimal appleTotal;
            decimal orangeTotal;

            //User inputs
            Console.WriteLine("Welcome to Fruit Shop");
            Console.WriteLine("\nFruit Menu \nApples ----------------- .60p \nOranges ---------------- .25p  \n<Press any key to continue>");

            Console.ReadKey();

            // enter apples
            Console.Write("Please enter the quantity (in number) for Apples: ");
            apples = Console.ReadLine();

            int n = 0;

            // verifying if the input is valid
            try
            {
                n = int.Parse(apples);
            }
            catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("\nPlease enter the quantity (in number) for Apples: ");
                apples = Convert.ToString(int.Parse(Console.ReadLine()));
            }

            // enter oranges
            Console.Write("Please enter the quantity (in number) for Oranges: ");
            oranges = Console.ReadLine();

            // verifying if the input is valid
            try
            {
                n = int.Parse(oranges);
            }
            catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("\nPlease enter the quantity (in number) for Oranges: ");
                oranges = Convert.ToString(int.Parse(Console.ReadLine()));
            }

            appleTotal = 0.60m * Convert.ToDecimal(apples);
            orangeTotal = 0.25m * Convert.ToDecimal(oranges);

            totalBeforeOffer = Convert.ToDecimal(appleTotal) + Convert.ToDecimal(orangeTotal);

            // buy ine get ine free
            if (Convert.ToDecimal(apples) % 2 == 0)
            {
                appleTotal = Convert.ToDecimal(apples) / 2;
                appleTotal = 0.60m * Convert.ToDecimal(appleTotal);
            }
            else
            {
                appleTotal = (Convert.ToInt32(apples) / 2) + (Convert.ToInt32(apples) % 2);
                appleTotal = 0.60m * Convert.ToDecimal(appleTotal);
            }

            // 3 for a price of 2
            if (Convert.ToDecimal(oranges) % 3 == 0)
            {
                orangeTotal = Convert.ToDecimal(oranges) - (Convert.ToDecimal(oranges) / 3);
                orangeTotal = 0.25m * Convert.ToDecimal(orangeTotal);
            }
            else
            {
                orangeTotal = (Convert.ToInt32(oranges) - (Convert.ToInt32(oranges) / 3));
                orangeTotal = 0.25m * Convert.ToDecimal(orangeTotal);
            }

            totalAfterOffer = Convert.ToDecimal(appleTotal) + Convert.ToDecimal(orangeTotal);



            Console.Write("\nThank you for shopping with us: ");
            Console.WriteLine("\nYour Total cost : " + "£" + totalBeforeOffer);
            Console.WriteLine("\nYour Final cost : " + "£" + totalAfterOffer);

        }
    }
}
