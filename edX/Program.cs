using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourse
{
    class Program
    {
        private static string[] newTeacherCourse;
        private static string[,] studentArray;
        private static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[,], string[]>>> degreeInformation;
        private static List<Tuple<string, string, int>> listProgramInfo;
        public static void Main(string[] args)
        {
            // Instatiation
            Student newStudentObj = new Student();
            Course newCourse = new Course();
            Teacher newTeacher = new Teacher();
            Degrees newDegree = new Degrees();
            Uprogram newProgram = new Uprogram();
            newStudentObj.NumberOfStudents = 3;
            Console.WriteLine("Do you want to record the student information?"); // Ask the user if he wants to record the students information 
            string answer = Console.ReadLine(); 
            if (answer.ToLower() == "yes")
            {
                int i = 0;
                while(i <3)
                {
                    studentArray = Student.GetStudentInformation(i);

                }
            }
            else
            {
                studentArray =new string[,]{ {"0", "The student Jean Joseph\r\n lives here:\r\nUnit 1/64, Pyrmont Street\r\n in Sydney, NSW, Australia\r\n and born in Katoomba"}, 
                                { "1","The student Jean Michel\r\n lives here:\r\nUnit 11/64, Harris Street\r\n in Katoomba, NSW, Australia\r\n and born in Sydney" },
                                { "2","The student Jean Reno\r\n lives here:\r\nUnit 8/68, Bunn Street\r\n in Sydney, NSW, Australia\r\n and born in Melbourne" },
                };
            }
            newCourse.courseName = "Programming with C#";
            newTeacher.TeacherFirstName = "Roger";
            newTeacher.TeacherFamilyName= "Patterson";         
            newTeacherCourse = Teacher.getTeacher(newTeacher.TeacherFirstName, newTeacher.TeacherFamilyName);
            newProgram.ProgramName = "Information Technology";          
            newDegree.DegreesName = "Bachelor of Science";
            newDegree.DegreesCredit = 60;
                         
                   
            degreeInformation = Degrees.getDegree(newDegree.DegreesName, newDegree.DegreesCredit, newCourse.courseName,studentArray, newTeacherCourse);
            listProgramInfo = Uprogram.getUprogram(newProgram.ProgramName);
            Console.WriteLine(" The {0} program contains the {1} degree where the students can earn {2} credits for the year.\r\n The {1} contains {3} student(s) and will be monitored by Mr {4} and Mr {5}", newProgram.ProgramName, newDegree.DegreesName, newDegree.DegreesCredit, newStudentObj.NumberOfStudents,(newTeacherCourse[0] + " " + newTeacherCourse[1]),(newTeacherCourse[2] + " " + newTeacherCourse[3]));
            Console.WriteLine("Do you want to know the student information?"); // Ask the user if he wants the 
            string answer1 = Console.ReadLine(); // Assign the value entered in the respectie variable
            if (answer.ToLower() == "yes")
            {              
                for (int i = 0; i < newStudentObj.NumberOfStudents; i++)
                { Console.WriteLine("The student {0} has this info {1}", i, studentArray[i, 1]); }
            }
            //string numberOfStudents;
            //Console.WriteLine("Please enter the number of students:");
            //numberOfStudents = Console.ReadLine();
            //string[][] arrayStudent = new string[Convert.ToInt32(numberOfStudents)][];
            //for (int i = 0; i < Convert.ToInt32(numberOfStudents); i++)
            //{
            //    var arr1 = Student.GetStudentInformation();
            //    arrayStudent[i] = arr1;
            //    Console.WriteLine("The student N:{0}\r\n{1} {2} lives here: {3} {4} in {5} {6} {7} {8} and born in {9}", i, arrayStudent[i][0], arrayStudent[i][1], arrayStudent[i][2], arrayStudent[i][3], arrayStudent[i][4], arrayStudent[i][5], arrayStudent[i][6], arrayStudent[i][7], arrayStudent[i][8]);
        }
    }
}