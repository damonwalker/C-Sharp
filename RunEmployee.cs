using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace RunEmployee
{
    //[Serializable()]
    //[XmlInclude(typeof(HourlyEmp)), XmlInclude(typeof(SalaryEmp)), XmlInclude(typeof(CommEmp)),
    //XmlInclude(typeof(Employee))]
    public class RunEmployee
    {
        Employee[] emp = new Employee[3]; // create Account1 array object
        int input;
        static void Main(string[] args)
        {
            RunEmployee re = new RunEmployee(); // create RunAccount object
            Console.WriteLine("Would you like to: \n1) load the accounts from a file or \n2) populate them with data entry? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 2)
            {
                re.PopulateEmployees();
            }
            else if (input == 1)
            {
                re.ReadEmployees();
            }
            //ra.PopulateAccounts();
            //ra.ReadAccounts();
            re.ChooseEmployees();
            //WriteText();
            re.SaveAccounts();
            
            //Employee.Exit();

        }


        public void ChooseEmployees()
        {
            do
            { // This is to select the type of employee
                Console.WriteLine("Please choose \n0) for Hourly Employee, \n1) for Salaried Employee, \n2) to Commissioned Employee. \n[-99 to quit]");
                input = Convert.ToInt16(Console.ReadLine());
                if (input != -99)
                {
                    if (input == 0 || input == 1 || input == 2)
                    {
                        emp[input].DisplayMenu();
                    }
                }
            } while (input != -99);

        }
       

        public void PopulateEmployees()
        {
            for (int i = 0; i < emp.Length; i++)
            {
                if(i == 0)
                {
                    emp[i] = new HourlyEmp();
                }
                else if (i == 1)
                {
                    emp[i] = new SalaryEmp();
                }
                else if (i == 2)
                {
                    emp[i] = new CommEmp();
                }
                
            }
        }

        

        public void SaveAccounts()
        {

            Stream FileStream = File.Create("AcctDW.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Employee[]));
            serializer.Serialize(FileStream, emp);
            Console.WriteLine("Your information has been saved.");
            FileStream.Close();

            System.IO.StreamWriter file = new System.IO.StreamWriter("TextDW.txt");
            {
                for (int i = 0; i < emp.Length; i++)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    file.WriteLine(i + "-" + emp[i].EmployeeTextData());


                }
                file.Flush();
                file.Close();

            }


        }
            //catch(DirectoryNotFoundException e)
            //{
            //    //do nothing
            //}
            //catch(NullReferenceException ne)
            //{
            //    //do nothing
            //}
            //catch(IOException ioe)
            //{
            //    // do nothing
            //}
            //XmlSerializer serializer = new XmlSerializer(acctArray.GetType());
            //BinaryFormatter serializer = new BinaryFormatter();

        public void ReadEmployees()
        {
            Stream FileStream = File.OpenRead("AcctDW.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Employee[]));
            emp = (Employee[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            //Console.WriteLine("You are in the SaveAccounts method");
        } // end ReadAccounts

        //public static void WriteText() // this will write the employee information to the text file
        //{
            

        //        //string text = "Employee.EmployeeTextData()";
        //        //System.IO.StreamWriter file = new System.IO.StreamWriter("TextDW.txt");
        //        //file.WriteLine(text);
        //        //file.Close();
        //    } // end WriteText
    }// end class RunEmployee 
}// end namespace


//file.WriteLine(path);
//Console.WriteLine("What file would you like to write?");


//for (int i=0; i < 5; i++)
//{
//    writeText[i] = Console.ReadLine();
//}
//File.WriteAllLines(path, writeText, Encoding.UTF8);

// write the array to a file


//for (int i = 0; i < 5; i++)
//{
//    file.WriteLine(writeText[i]);
//}

//file.WriteLine(lines);
