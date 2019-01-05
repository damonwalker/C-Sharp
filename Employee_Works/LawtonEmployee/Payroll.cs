using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LawtonEmployee
{
    class Payroll
    { 

        Employee[] emp = new Employee[3];

        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.TopMenu();
        }


        public void TopMenu()
        {
            Console.WriteLine("Please select \n1) to Populate New Employee \n2) to Load Existing Account \n3) to Exit");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    PopulateEmployee();
                    break;

                case 2:
                    ReadArray();
                    break;

                case 3:
                    WriteArray();
                    //System.Environment.Exit(0);
                    break;

            }
        }

        public void PopulateEmployee()
        {
            for (int i = 0; i < emp.Length; i++)
            {
                if (i == 0)
                {
                    emp[i] = new Hourly();
                }
                else if (i == 1)
                {
                    emp[i] = new Salary();
                }
                else if (i == 2)
                {
                    emp[i] = new Commission();
                }

            }
            Console.WriteLine("All Employee types have been created" );
            SelectEmployee();
        }

        public void SelectEmployee()
        {
            Console.WriteLine("Please select \n0) for Hourly Employee \n1) for Salary Employee \n2) for Commission Employee \n3) to Exit" );
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 0:
                    emp[input].menu();
                    SelectEmployee();
                    break;

                case 1:
                    emp[input].menu();
                    SelectEmployee();
                    break;

                case 2:
                    emp[input].menu();
                    SelectEmployee();
                    break;

                default:
                    WriteArray();
                    break;
            }

        }

        public void WriteArray()
        {
            Stream fileStream = File.Create("Payroll.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, emp);
            fileStream.Close();


        }

        public void ReadArray()
        {

            Stream fileStream = File.OpenRead("Payroll.txt");
            BinaryFormatter deserializer = new BinaryFormatter();
            emp = (Employee[])deserializer.Deserialize(fileStream);
            fileStream.Close();
            SelectEmployee();

        }
    }
}
