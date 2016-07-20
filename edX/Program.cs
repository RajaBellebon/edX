using System;
using System.Collections.Generic;


namespace edXCourse
{
    class Program
    {
        public static string[] newTeacherCourse;       
        private static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<List<string>, string[]>>> degreeInformation;
        private static List<Tuple<string, string, int>> listProgramInfo;
        public static void Main(string[] args)
        {
            // Instatiation
            Student newStudentObj = new Student();
            Course newCourse = new Course();
            Teacher newTeacher = new Teacher();
            Degrees newDegree = new Degrees();
            Uprogram newProgram = new Uprogram();
            List<string> studentArray = new List<string>();
            newStudentObj.NumberOfStudents = 3;
            Console.WriteLine("Do you want to record the student information?: Enter 'Yes' if you want to record any student information or 'No' to use the saved information"); // Ask the user if he wants to record the students information 
            string answer = Console.ReadLine(); 
            if (answer.ToLower() == "yes")
            {
                int i = 0;
                while(i <2)
                {
                    studentArray.Add(Student.GetStudentInformation(i));
                   
                    i += 1;

                }
            }
            else
            {
                studentArray.Add("The student Jean Joseph\r\n lives here:\r\nUnit 1/64, Pyrmont Street\r\n in Sydney, NSW, Australia\r\n and born in 25/02/1988");
                studentArray.Add("The student Jean Michel\r\n lives here:\r\nUnit 11/64, Harris Street\r\n in Katoomba, NSW, Australia\r\n and born in 20/08/1989");
                studentArray.Add("The student Jean Reno\r\n lives here:\r\nUnit 8/68, Bunn Street\r\n in Sydney, NSW, Australia\r\n and born in 12/06/1987");
      
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
            Console.WriteLine("The {0} program contains the {1} degree where the students can earn {2} credits for the year.\r\n\r\nThe {1} degree contains the course {5}.\r\n\r\nThe {1} contains {3} student(s) and will be monitored by Mr {4}.\r\n", newProgram.ProgramName, newDegree.DegreesName, newDegree.DegreesCredit, newStudentObj.NumberOfStudents, newTeacher.TeacherFirstName + " " + newTeacher.TeacherFamilyName, newCourse.courseName);
            Console.WriteLine("Do you want to know the student information?"); // Ask the user if he wants the 
            string answer1 = Console.ReadLine(); // Assign the value entered in the respectie variable
            if (answer1.ToLower() == "yes")
            {              
                for (int i = 0; i < newStudentObj.NumberOfStudents; i++)
                { Console.WriteLine("The student {0} has this info:\r\n{1}\r\n", i, studentArray[i]); }
                Console.WriteLine();
            }
        }
    }
}