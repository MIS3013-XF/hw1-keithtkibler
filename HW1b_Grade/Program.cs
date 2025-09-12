// HW1b Grade

// Your Name: Keith Kibler
// Did you seek help ? If yes, specify the helper or web link here: Again, I used the Rounding function from the previous problem here. I used this link https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-9.0

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            double studentID = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double exam1Grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double exam2Grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            double exam3Grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double homeworksGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations?");
            double participationsGrade = Convert.ToDouble(Console.ReadLine());

            double finalGrade = Math.Round(exam1Grade * .15 + exam2Grade * .25 + exam3Grade * .25 + homeworksGrade * .2 + participationsGrade * .15,2);
            Console.WriteLine(firstName + " " + lastName + " (" + studentID + "), your final grade is " + finalGrade + "%.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();









        }
    }
}
