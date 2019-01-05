using System;
using System.Collections.Generic;
using System.Text;

namespace LawtonEmployee
{
    [Serializable()]
    class Commission : Employee
    {
        public override void computeGross()
        {
            Console.WriteLine("How many items sold?  ");
            int items = int.Parse(Console.ReadLine());

            Console.WriteLine("Price of items sold?  ");
            float price = float.Parse(Console.ReadLine());

            gross = (items * price) * .50f;


        }


    }
}
