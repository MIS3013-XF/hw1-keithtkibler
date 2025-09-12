// HW1a Sales Total

// Your Name: Keith Kibler
// Did you seek help ? If yes, specify the helper or web link here: Yes. I used the following link to learn the Math.Round() function, so that my results came out in proper monetary values. https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-9.0 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salesTax = 0.085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            string itemName = Console.ReadLine();
            Console.WriteLine("How many " + itemName + "'s do you want to buy?");
            double itemQuantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the price for each " + itemName + "?");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            double subtotal = Math.Round(itemQuantity * itemPrice,2);
            double taxTotal = Math.Round(subtotal * salesTax, 2);
            double orderTotal = Math.Round(subtotal + taxTotal, 2);

            Console.WriteLine("Your subtotal for your bill is $" + subtotal + ".");
            Console.WriteLine("Your sales tax for your bill is " + taxTotal + ".");
            Console.WriteLine("Your total for your bill is $" + orderTotal + ".");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
