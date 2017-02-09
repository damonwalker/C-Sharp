using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusPi
{
    class RadiusPi
    {
        static void Main(string[] args)
        {
            float num1; //radius of the circle
            float sum; // sum of number
            float pi = 3.14159F;

            Console.Write("Enter the radius of your circle: ");
            num1 = Convert.ToInt32( Console.ReadLine() );

            {
                sum = (num1 * 2);
                Console.WriteLine("{0} is the diameter of the circle ", sum);
                sum = (2 * pi * num1);
                Console.WriteLine("{0} is the circumference of the circle ", sum);
                sum = pi * (num1 * num1);
                Console.WriteLine("{0} is the area of the circle ", sum);
                Console.WriteLine("The character {0} has the value {1}", 'A', ((int)'A'));
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
