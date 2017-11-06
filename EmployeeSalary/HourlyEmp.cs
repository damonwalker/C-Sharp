using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunEmployee
{
    public class HourlyEmp : Employee
    {
        
        public override void ComputeGross()
        {
            Console.WriteLine("Please enter the Employee's Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the amount of hours worked this week: ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the rate of pay: ");
            Rate = Convert.ToInt32(Console.ReadLine());
            gross = Hours * Rate;
            //return pay;
            {
                if (Hours <= 40)
                    gross = Rate * Hours;
                else
                    gross = (40 * Rate) + ((Hours - 40) * (Rate * 1.5f));
            }
        }

        public string Name { get; set; }

        public float Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value >= 0) // validation
                    rate = value;
                else
                    throw new ArgumentOutOfRangeException("Rate", value, "Rate must be >=0");
            }// end set
        }//end property Rate

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168) // validation
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Rate must be >=0 and <=168");
            }// end set
        }//end property Rate
         




    }
}
