using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day003
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            string unitOfMeasure = "";

            Console.WriteLine("What unit of measure are you using?");
            unitOfMeasure = Console.ReadLine();

            Console.WriteLine("Enter the length of your rectangle or square:");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of your rectangle or square:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("You entered {0} for the length and {1} for the width.", length, width);
            Console.WriteLine("The area of your rectangle or square is: {0} square {1}", calculateArea(length, width), unitOfMeasure);


            Console.ReadLine();
            
        }

        static double calculateArea(double l, double w)
        {
            return l * w;
        }
    }
}
