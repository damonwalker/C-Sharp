using System;
using System.Collections.Generic;
using System.Text;

namespace LawtonEmployee
{
    [Serializable()]
    class Salary : Employee
    {
        public override void computeGross()
        {
            Console.WriteLine("Please select 1. for Executive or 2. for Staff: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                gross = 100000;
            }
            else if (input == 2)
            {
                gross = 50000;
            }

        }
    }
}
