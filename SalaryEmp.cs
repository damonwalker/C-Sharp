using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunEmployee
{
    public class SalaryEmp : Employee
    {
        

        
        public override void ComputeGross()
        {
            Console.WriteLine("Enter\n 1) For Staff Employee\n 2) For Executive Employee: ");
            int input = Convert.ToInt16(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Staff Employee: ");
                gross = 50000;
            }

            else
            {
                Console.WriteLine("Executive Employee: ");
                gross = 100000;
            }
            // 0;
        }
    }
}
