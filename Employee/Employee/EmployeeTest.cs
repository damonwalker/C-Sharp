using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeeTest
{
    // main method begins the executiong of class EmployeeTest
        static void Main(string[] args)
        {
        Employee employee1 = new Employee("John", "Doe", 2500.00M);
        Employee employee2 = new Employee("Sally", "Mae", 5200.00M);

        //display employee information
        Console.WriteLine("Employee: {0},{1}, balance is {2:C}", employee1.firstName, employee1.lastName, 12* employee1.MonthlySalaryProperty);
        Console.WriteLine("Employee: {0},{1}, balance is {2:C}", employee2.firstName, employee2.lastName, 12* employee2.MonthlySalaryProperty);

        //decimal depositAmount; // deposit amount read from user

        // prompt user for input for employee1
        Console.WriteLine("Employee {0} salary will be increased by 10% : ", employee1.firstName );
        Console.WriteLine("Employee {0} salary will be increased by 10% : ", employee2.firstName);
        //depositAmount = Convert.ToDecimal(Console.ReadLine());
        employee1.MonthlySalaryProperty = employee1.MonthlySalaryProperty * 1.10M;
        employee2.MonthlySalaryProperty = employee2.MonthlySalaryProperty * 1.10M;

        //display employee new information
        Console.WriteLine("Employee: {0},{1}, balance is {2:C}", employee1.firstName, employee1.lastName, 12 * employee1.MonthlySalaryProperty);
        Console.WriteLine("Employee: {0},{1}, balance is {2:C}", employee2.firstName, employee2.lastName, 12 * employee2.MonthlySalaryProperty);


        Console.ReadKey();
        //Console.WriteLine("adding {2:C} to employee1 balance\n", depositAmount);
        //employee1.Credit(depositAmount); // add to employee account

        //display balances
        //Console.WriteLine("employee1 balance: {2:C}", employee1.Balance);
        //Console.WriteLine("employee2 balance: {2:C}\n", employee2.Balance);

        // prompt user for input for employee2
        //Console.WriteLine("Enter the amount of deposit for employee2: ");
        //depositAmount = Convert.ToDecimal(Console.ReadLine());
        //Console.WriteLine("adding {2:C} to employee2 balance\n", depositAmount);
        //employee2.Credit(depositAmount); // add to employee account

        ////display balances
        //Console.WriteLine("employee1 balance: {2:C}", employee1.Balance);
        //Console.WriteLine("employee2 balance: {2:C}\n", employee2.Balance);


    }//end Main
} // end class EmployeeTest

