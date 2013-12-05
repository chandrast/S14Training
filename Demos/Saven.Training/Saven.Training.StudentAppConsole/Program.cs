using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Saven.Training.StudentAppConsole
{
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student details:");

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Qualification:");
            //STANDARD: Use full names for variable name.  qln should be qualification in the line below.
            string qln = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks:");
            int marks = int.Parse(Console.ReadLine());

            //Code here to find out the grade
            //STANDARD:  Initialize any string with string.Empty, do not do like this - string str = ""
            string grade = string.Empty;

            if (marks >= 90)
            {
                grade = "A";
            }
            else if (marks >= 80 && marks < 90)
            {
                grade = "B";
            }
            else if (marks >= 70 && marks < 80)
            {
                grade = "C";
            }
            else if (marks >= 50 && marks < 70)
            {
                grade = "D";
            }
            else 
            {
                grade = "E";
            }

            Console.WriteLine("Enter any key to view output");
            Console.ReadLine();
            Console.WriteLine("Information of student with grade \nName: {0} \nQualification: {1} \nGrade: {2} ", name,qln,grade);
            Console.ReadLine();

        }
    }
}
