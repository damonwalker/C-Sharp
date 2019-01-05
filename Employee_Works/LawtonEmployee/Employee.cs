using System;
using System.Collections.Generic;
using System.Text;

namespace LawtonEmployee
{
    [Serializable()]
    public abstract class Employee
    {
        /*********************
             Attributes
        *********************/
        public float rate;
        float taxrate = 0.2f;
        public int hours;
        public float gross = 0.0f;
        float tax = 0.0f;
        float net = 0.0f;
        float net_percent = 0.0f;

        //End Attributes

        /********************
	     Constructors
	********************/
        public Employee()
        {

        }

        /********************
             Methods
        ********************/
        public void menu()
        {
            Console.WriteLine("Please Choose the following \n1)Calculate Gross Pay \n2)Calculate Tax \n3)Calculate Net Pay \n4)Calculate Net Percent \n5)Display Employee \n6) to Exit ");
            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    computeGross();
                    menu();
                    break;
                    
                case 2:
                    computeTax();
                    menu();
                    break;

                case 3:
                    computeNet();
                    menu();
                    break;

                case 4:
                    computeNetperc();
                    menu();
                    break;

                case 5:
                    displayEmployee();
                    menu();
                    break;

                default:
                    break;

            }
        }

        public abstract void computeGross();
        //{
        //    gross = rate * hours;
        //}

        public void computeTax()
        {
            tax = gross * taxrate;
        }

        public void computeNet()
        {
            net = gross - tax;
        }

        public void computeNetperc()
        {
            net_percent = (net / gross) * 100;
        }

        public void displayEmployee()
        {
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
        }
    }

}

