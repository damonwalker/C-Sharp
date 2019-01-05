using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ATM
{
    class ATM
    {
        Account[] myAcct = new Account[3];

        static void Main(string[] args)
        {
            ATM myATM = new ATM();
            myATM.TopMenu();
            myATM.SaveAccount();
        }

        public void TopMenu()
        {
            int i;
            Console.WriteLine("Please press \n1) To Create new account \n2) To load existing account");
            i = int.Parse(Console.ReadLine());
            if (i == 1)
            {

                CreateNew();
            }
            else if (i == 2)
            {
                LoadAccount();
            }
            else if (i !=1 || i !=2)
            {
                Console.WriteLine("Please select 1 or 2");
                TopMenu();
            }
        }
        public void ChooseAcct()
        {
            int i;
            Console.WriteLine("Which Account would you like to use? 0) 1) 2) or -99 to exit.");
            i = int.Parse(Console.ReadLine());
            while (i !=-99) 
            {
                myAcct[i].Menu();
                ChooseAcct();
            }
            SaveAccount();
            System.Environment.Exit(0);
            
        }

        public void CreateNew()
        {
            int i;
            for (i = 0; i < myAcct.Length; i++)
            {
                myAcct[i] = new Account();
                myAcct[i].SetBalance(100);
                Console.WriteLine("Account " + i + " has been create");
            }
            ChooseAcct();
        }


        public void LoadAccount()
        {
            Stream FileStream = File.OpenRead("myAtm_csharp.txt");
            BinaryFormatter deserializer = new BinaryFormatter();
            myAcct = (Account[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            ChooseAcct();
        }


        public void SaveAccount()
        {
            Stream FileStream = File.Create("myAtm_csharp.txt");
            BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(FileStream, myAcct);
            Console.WriteLine("Your information has been saved.");
            FileStream.Close();
               

                System.IO.StreamWriter file = new System.IO.StreamWriter("myAtm.txt");
            {
                for (int i = 0; i < myAcct.Length; i++)
                {
                    // this writes the info to a plain text file
                    file.WriteLine(i + "-" + myAcct[i].GetBalance());


                }
                file.Flush();
                file.Close();

            }
        }
    
    }
}
