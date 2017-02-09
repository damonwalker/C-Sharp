using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public string firstName { get; set; } // employee first name
    public string lastName { get; set; } // employee last name
    private decimal monthlySalary; // employee salary

    //constructor
    public Employee(string fname, string lname, decimal salary)
    {
        firstName = fname; // set firstName property
        lastName = lname; // set lastName property
        MonthlySalaryProperty = salary; // set salary property
    }// end constructor

    //// credit (add) amount to the account
    //public void Credit(decimal amount)
    //{
    //    Balance = Balance + amount; // add amount to balance
    //}// end method Credit

    

    // a property to get and set the account balance
    public decimal MonthlySalaryProperty
    {
        get
        {
            return monthlySalary;
        }// end get
        set
        {
            //validate that the value is greater that 0; if not the salary is not changed
            if (value >= 0)
                monthlySalary = value;
        }// end set

    } // end property Balance
}// end Employee class
