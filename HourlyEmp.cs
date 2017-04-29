using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunEmployee
{
    public class HourlyEmp : Employee
    {
        //private float rate; // wage per hour
        //private float hours;


        //public HourlyEmp( string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked): base(first, last, ssn)
        //public HourlyEmp()
        //{
        //    rate = hourlyWage;
        //}
        
       

        public override void ComputeGross()
        {
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
         //public float ComputePay // may change to compute gross
         //{
         //    get
         //    {
         //    return pay;
         //    {   // end get          

        //    set

        //    {
        //    //    if (value <= 40)
        //    //                pay = value;
        //    //    else
        //    //                pay = (Hours - 40) * Rate * 1.5;



        //    } // end set
        //        //return base.ComputeGross() + ((Hours - 40) * Rate * 1.5M);
        //        //Console.WriteLine("Pay is {0}, \n,", pay);
        //        //DisplayMenu();

        
        public override string ToString()
        {
            return string.Format("Pay is equal to: ", gross);
        }





    }
}
