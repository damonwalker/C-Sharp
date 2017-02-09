using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a GradeBook object and call its DisplayMessaage method.
public class GradeBookTest
{
    public static void Main(String[] args )
    {
        //create a GradeBook object and assign it to myGradeBook
        GradeBook myGradeBook = new GradeBook();

        // display initial value of CourseName
        Console.WriteLine("Initial course name is: '{0}'\n", myGradeBook.CourseName);

        //prompt for input course name
        Console.WriteLine("Please enter the course name: ");
        myGradeBook.CourseName = Console.ReadLine(); // set CourseName (which is the property of courseName)
        //string nameOfCourse = Console.ReadLine(); //read the text entered and assign it to nameOfCourse
        Console.WriteLine(); //input a blank line

        //call myGradeBook's DisplayMessage method
        //pass nameOfCourse into the DisplayMessage argument
        //myGradeBook.DisplayMessage(nameOfCourse);
        myGradeBook.DisplayMessage();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }// end Main
} // end class GradeBookTest
