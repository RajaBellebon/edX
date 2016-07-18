using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourse
{
    class Program
    {
        
      
       
        public static void Main(string[] args)
        {
            string numberOfStudents;
            Console.WriteLine("Please enter the number of students:");
            numberOfStudents = Console.ReadLine();
            string[][] arrayStudent = new string[Convert.ToInt32(numberOfStudents)][];
            for (int i = 0; i < Convert.ToInt32(numberOfStudents); i++)
            {
                var arr1 = Student.GetStudentInformation();
                arrayStudent[i] = arr1;
                Console.WriteLine("The student N:{0}\r\n{1} {2} lives here: {3} {4} in {5} {6} {7} {8} and born in {9}", i, arrayStudent[i][0], arrayStudent[i][1], arrayStudent[i][2], arrayStudent[i][3], arrayStudent[i][4], arrayStudent[i][5], arrayStudent[i][6], arrayStudent[i][7], arrayStudent[i][8]);
            }
        }
    }
}