using System;
using System.Collections.Generic;
using System.Text;

namespace LawtonEmployee
{
    [Serializable()]
    class Hourly : Employee
    {
        public override void computeGross()
        {
            Console.WriteLine("Please enter the number of hours worked:   ");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the rate of pay: ");
            rate = int.Parse(Console.ReadLine());

            if (hours <=40)
            {
                gross = hours * rate;
            }
            else if (hours > 40)
            {
                gross = (rate * 40) + ((hours - 40) * (rate * 1.5f));
            }
            Console.WriteLine("Total overtime hours " + (hours-40));
        }

    }
}
