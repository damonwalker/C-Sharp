using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int num1; //first number

            Console.Write("Enter your number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
                Console.WriteLine("{0} is even ", num1);
            else
                Console.WriteLine("{0} is odd ", num1);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
