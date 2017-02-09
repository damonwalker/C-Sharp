using System;

namespace Comparison
{
  public class Comparison
    {
        public static void Main(string[] args)
        {
        int number1; // declare first number to compare
        int number2; // declare second number to compare

        // prompt user and read first number
        Console.Write("Enter first interger: ");
        number1 = Convert.ToInt32(Console.ReadLine()); // take the text string entered and convert it to an integer

        // prompt user and read second number
        Console.Write("Enter second interger: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2)
            Console.WriteLine("{0} == {1}", number1, number2);

        if (number1 != number2)
            Console.WriteLine("{0} != {1}", number1, number2);

        if (number1 < number2)
            Console.WriteLine("{0} < {1}", number1, number2);

        if (number1 > number2)
            Console.WriteLine("{0} > {1}", number1, number2);

        if (number1 <= number2)
            Console.WriteLine("{0} <= {1}", number1, number2);

        if (number1 >= number2)
            Console.WriteLine("{0} >= {1}", number1, number2);

        Console.WriteLine("Press any key to exit: ");
        Console.ReadKey();


        }// end Main
    } //end Class Comparison
}


