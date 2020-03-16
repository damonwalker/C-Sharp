using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    [Serializable()]
    class Account 
    {
        double balance;
        double deposit;
        double withdraw;
        double interest;
        DateTime date1 = DateTime.Now, date2;
        Boolean b;

        //public virtual string AccountTextData() // Problem Solved
        //    {
        //        for (int i=0; i < myAccou)
        //        return "Employee " + name\n + " Earnings Info: " + "  Hours Worked:  " + hours\n + "  Rate of Pay: " + rate\n + "  Gross Pay: " + gross\n + "  Net Pay: " + netpay\n + "  Net Percentage: " + net_percent\n;
        //    }

        public void SetBalance(double arg_balance)
        {
            balance = arg_balance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void CalcInterest()
        {
            double numOfDays = (date2 - date1).TotalDays;
            interest = (numOfDays * .05);
        }


        public Boolean CheckDate()
        {
            if ((date2 - date1).TotalDays > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //var x = DateTime.Now;
        //String.Format("{0:MM/dd/yyyy}", date2);

        //Console.ReadLine();
        //DateTime.Now.ToString("MM/dd/yyyy");
        //date1 = DateTime.Parse(Console.ReadLine());

        //var compare = (todayDate - DateTime.Now).TotalDays;

        //Console.WriteLine(compare);
        public void Menu()
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("Press 1) for Deposit");
            Console.WriteLine("Press 2) for Withdraw");
            Console.WriteLine("Press 3) for Show Balance");
            Console.WriteLine("Press 4) to Exit");
            int select;
            select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Deposit();
                    break;

                case 2:
                    Withdraw();
                    break;

                case 3:
                    CheckBalance();
                    break;


                default:
                    //System.Environment.Exit(0);
                    break;

            }

        }


        public void Deposit()
        {
            Console.WriteLine("Please enter a future date: MM/dd/yyyy");
            date2 = Convert.ToDateTime(Console.ReadLine());

            //date1 = DateTime.Now;
            b = CheckDate();

            if (b == false)
            {
                Console.WriteLine("You have entered a previous date");
                Console.WriteLine("Please enter a future date: MM/dd/yyyy");
            }
            else
            {

                //Console.WriteLine(b);
                //Console.ReadLine();

                Console.WriteLine("Please enter the amount that you would like to deposit");
                deposit = double.Parse(Console.ReadLine());
                CalcInterest();
                balance = balance + deposit + interest;
                Console.WriteLine("Your new balance is: " + balance);
                date1 = date2;
            }
            Menu();

        }

        public void Withdraw()
        {
            Console.WriteLine("Please enter a future date: MM/dd/yyyy");
            date2 = Convert.ToDateTime(Console.ReadLine());

            date1 = DateTime.Now;
            b = CheckDate();

            if (b == false)
            {
                Console.WriteLine("You have entered a previous date");
                Console.WriteLine("Please enter a future date: MM/dd/yyyy");
            }
            else
            {

                Console.WriteLine("Enter the amount that you would like to withdraw: ");
                withdraw = double.Parse(Console.ReadLine());

                if (withdraw > balance)
                {
                    Console.WriteLine("The amount you entered will overdraw your account. \n Please select a lesser ammount.");
                    Withdraw();
                }
                else if (withdraw < balance)
                {
                    CalcInterest();
                    balance = interest + balance - withdraw;
                    Console.WriteLine("Your new balance is: " + balance);
                }
            }
            Menu();
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your balance is " + balance);
            Menu();
        }

    }
}
