using System;
using System.Collections.Generic;


namespace edXCourse
{
    public class Program
    {
        public static string[] newTeacherCourse;       
        private static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>> degreeInformation;
        private static List<Tuple<string, string, int>> listProgramInfo;

        public static int giveScore()
        {
            Random rnd = new Random();
            int value = rnd.Next(10,95);
            return value;
        }
        public static void Main(string[] args)
        {
            // Instatiation
            Student newStudentObj = new Student();
            Course newCourse = new Course();
            Teacher newTeacher = new Teacher();
            Degrees newDegree = new Degrees();
            Uprogram newProgram = new Uprogram();
            newStudentObj.NumberOfStudent = 3;
            string[] studentArray = {"The student Jean Joseph\r\n lives here:\r\nUnit 1/64, Pyrmont Street\r\n in Sydney, NSW, Australia\r\n and born in 25/02/1988",
            "The student Jean Michel\r\n lives here:\r\nUnit 11/64, Harris Street\r\n in Katoomba, NSW, Australia\r\n and born in 20/08/1989",
            "The student Jean Reno\r\n lives here:\r\nUnit 8/68, Bunn Street\r\n in Sydney, NSW, Australia\r\n and born in 12/06/1987"};

            newCourse.courseName = "Programming with C#";
            newTeacher.FirstName = "Roger";
            newTeacher.LastName = "Patterson";
            newTeacherCourse = Teacher.getTeacher();
            newProgram.ProgramName = "Information Technology";
            newDegree.DegreesName = "Bachelor of Science";
            newDegree.DegreesCredit = 60;


            degreeInformation = Degrees.getDegree(newDegree.DegreesName, newDegree.DegreesCredit, newCourse.courseName, studentArray, newTeacherCourse);
            listProgramInfo = Uprogram.getUprogram(newProgram.ProgramName);
            Console.WriteLine("The {0} program contains the {1} degree where the students can earn {2} credits for the year.\r\n\r\nThe {1} degree contains the course {5}.\r\n\r\nThe {1} contains {3} student(s) and will be monitored by Mr {4}.\r\n", newProgram.ProgramName, newDegree.DegreesName, newDegree.DegreesCredit, newStudentObj.NumberOfStudent, newTeacher.FirstName + " " + newTeacher.LastName, newCourse.courseName);
             for (int i = 0; i < newStudentObj.NumberOfStudent; i++)
             {
                 var sc = giveScore();
                 newTeacher.Score = Student.TakeTest(sc);
                 var newGrade = Teacher.GradeTest();
                 Console.WriteLine("\r\nCurrently, {0} passed the test for {1} and grade {2} in the last test, the {3} contains 5 tests, an average of B will give {4} for the year", 
                 studentArray[i], newCourse.courseName, newGrade, newDegree.DegreesName, newDegree.DegreesCredit);
             }
        }
    }
}