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
        public string name;
        public float rate;
        public float taxrate = 0.2f;
        public int hours;
        public float gross; // same as pay
        public float tax = 0.0f;
        public float net_percent = 0.0f;
        public float netpay;
        //protected float pay;

        public Employee()
        {
            //Console.WriteLine("{0} have been initialized.", GetType() );
        }

        public void DisplayMenu() // what do you want to do to the employee???
        {
            int input;

            do
            {
                //Console.WriteLine(GetType());
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
                  


                }
            }while(input >= 1 && input <= 5);
        }
        public void CalcTax()
        {
            tax = gross * taxrate;
            Console.WriteLine("Tax is {0} ", tax);
            //DisplayMenu();
        }
        public void CalcNet()
        {
            netpay = gross - tax;
            Console.WriteLine("Net pay is {0} ", netpay);
            //DisplayMenu();
        }
        public void CalcNetPer()
        {
            net_percent = (netpay / gross) * 100;
            Console.WriteLine("Net percentage is {0} ", net_percent);
            //DisplayMenu();
        }
        public void DisplayEmp()
        {
            Console.WriteLine("Employee: ", name);
            Console.WriteLine("Hours:{0} ", hours);
            Console.WriteLine("Rate:{0} ", rate);
            Console.WriteLine("Gross:{0:c} ",  gross);
            Console.WriteLine("Net:{0:c} ", netpay);
            Console.WriteLine("Net%: {0}", net_percent);

        }
        public abstract void ComputeGross();


        public override string ToString()
        {
            return "Employee Earnings info: " + hours + rate + gross + netpay + net_percent;
        }

        public virtual string EmployeeTextData() // Problem Solved
        {

            return "Employee "+ name\n + " Earnings Info: " + "  Hours Worked:  " + hours\n + "  Rate of Pay: " + rate\n + "  Gross Pay: "+ gross\n + "  Net Pay: " + netpay\n + "  Net Percentage: " + net_percent\n; 
        }
        


    } // end class Employee
} // end namespace


    

    
