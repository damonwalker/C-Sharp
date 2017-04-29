using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunEmployee
{
    public class CommEmp : Employee
    {
        private int sold;
        private float cost;
        public override void ComputeGross()
        {
            Console.WriteLine("How many items were sold this month: ");
            sold = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Cost of the items sold this month: ");
            cost = Convert.ToInt16(Console.ReadLine());
            gross = (sold * cost) / 2;
        }
    }
}
