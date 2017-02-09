using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GradeBook
{
    private string courseName; // course name for this GradeBook (this is a field and an instance variable)

    // propery to get and set the course name (This is the property of courseName)
    public string CourseName { get; set; }

    //{
    //    get
    //    {
    //        return courseName;
    //    } // end get
    //    set
    //    {
    //        courseName = value;
    //    } // end set
    //} // end property CourseName

    //// diplay a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        // use property CourseName to get the name of the course that this GradeBook represents
        Console.WriteLine("Welcome to the Grade Book for\n{0}", CourseName);
    }// end method DisplayMessage
} // end Class GradeBook
