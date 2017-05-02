using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace RunEmployee
{
    [Serializable()]
    [XmlInclude(typeof(HourlyEmp)), XmlInclude(typeof(SalaryEmp)), XmlInclude(typeof(CommEmp)),
     XmlInclude(typeof(Employee))]

    // [XmlArray]
    // [XmlArrayItem(typeof(int),
    //ElementName = "MyNumber"),
    //XmlArrayItem(typeof(string),
    //ElementName = "MyString"),
    //XmlArrayItem(typeof(Employee))]
    // public object[] ExtraInfo;
    //[xmlArrayItem(typeof HourlyEmp)]
    //[xmlArrayItem(typeof (SalaryEmp))]
    //[xmlArrayItem(typeof (CommEmp))]
    //[XMLInclude(typeof HourlyEmp)]
    public abstract class Employee
    {

        public float rate;
        float taxrate = 0.2f;
        public int hours;
        protected float gross; // same as pay
        float tax = 0.0f;
        float net_percent = 0.0f;
        float netpay;
        //protected float pay;

        public Employee()
        {
            //Console.WriteLine("Employees have been initialized." );
        }

        public void DisplayMenu() // what do you want to do to the employee???
        {
            int input;

            do
            {
                Console.WriteLine("Please enter a choice [1-6]: ");
                Console.WriteLine("1) Calculate Gross Pay");
                Console.WriteLine("2) Calculate Tax");
                Console.WriteLine("3) Calculate Net Pay");
                Console.WriteLine("4) Calculate Net Percent");
                Console.WriteLine("5) Display Employee");
                Console.WriteLine("6) Exit");

                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ComputeGross();
                        break;
                    case 2:
                        CalcTax();
                        break;
                    case 3:
                        CalcNet();
                        break;
                    case 4:
                        CalcNetPer();
                        break;
                    case 5:
                        DisplayEmp();
                        break;
                    //case 6:
                    //    Exit();
                    //    break;

                    //default:
                    //    {
                    //        //Console.WriteLine("Invalid Entry. Please try again. ");
                    //        Console.Clear();
                    //        DisplayMenu();
                    //        break;
                    //    } // end default


                }
            }while(input >= 1 && input <= 5);
        }
        public void CalcTax()
        {
            tax = gross * taxrate;
            Console.WriteLine("you are in the CalcTax method");
            //DisplayMenu();
        }
        public void CalcNet()
        {
            netpay = gross - tax;
            Console.WriteLine("you are in the CalcNet method");
            //DisplayMenu();
        }
        public void CalcNetPer()
        {
            net_percent = (netpay / gross) * 100;
            Console.WriteLine("you are in the CalcNetPer method");
            //DisplayMenu();
        }
        public void DisplayEmp()
        {
            Console.WriteLine(employee[index].GetType();
            Console.WriteLine("Hours:{0} ", hours);
            Console.WriteLine("Rate:{0} ", rate);
            Console.WriteLine("Gross:{0} ", gross);
            Console.WriteLine("Net:{0} ", netpay);
            Console.WriteLine("Net%:{0} ", net_percent);

        }
        public abstract void ComputeGross();
        //{

        //    //return rate * hours;
        //   Console.WriteLine("Gross hours has been calculated");
        //    //DisplayMenu();
        //} // end ComputeGross

    //public static void Exit()
    //    {

    //        Console.WriteLine("You are in the EXIT METHOD.");
    //        Console.ReadKey();
    //        System.Environment.Exit(0);
    //    }

        
    } // end class Employee
} // end namespace


    

    
