using System;
using System.Collections;
using System.Collections.Generic;


namespace edXCourse
{
    public class Program
    {
        public static List<string> newTeacherCourse;
        public static List<string> studentArray;
        private static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<List<string>, List<string>>>> degreeInformation;
        private static List<Tuple<string, string, int>> listProgramInfo;

       
        
        public static void Main(string[] args)
        {
            // Instatiation
            Student newStudentObj = new Student();
            Course newCourse = new Course();
            Teacher newTeacher = new Teacher();
            Degrees newDegree = new Degrees();
            Uprogram newProgram = new Uprogram();
            

            newCourse.courseName = "Programming with C#";
            newTeacherCourse = Teacher.getTeacher();
            newProgram.ProgramName = "Information Technology";
            newDegree.DegreesName = "Bachelor of Science";
            newDegree.DegreesCredit = 60;
            newStudentObj.NumberOfStudent = 3;
            studentArray = Student.StudentInfo(newStudentObj.NumberOfStudent);

            degreeInformation = Degrees.getDegree(newDegree.DegreesName, newDegree.DegreesCredit, newCourse.courseName, studentArray, newTeacherCourse);
            listProgramInfo = Uprogram.getUprogram(newProgram.ProgramName);
            
             foreach (string stud in studentArray)
             {
                
                 newTeacher.Score = Student.averageScoreMethod(newStudentObj.NumberOfStudent);
                 var newGrade = Teacher.GradeTest(newTeacher.Score);
                 Console.WriteLine("\r\nCurrently,the student {0}\r\n grade in average {1} for the tests for {2}, the {3} contains 5 tests, an average of B will give {4} for the year",
                 stud, newGrade, newCourse.courseName,  newDegree.DegreesName, newDegree.DegreesCredit);
             }
            Console.WriteLine("The {0} program contains the {1} degree where the students can earn {2} credits for the year.\r\n\r\nThe {1} degree contains the course {5}.\r\n\r\nThe {1} contains {3} student(s) and will be monitored by Mr {4}.\r\n", newProgram.ProgramName, newDegree.DegreesName, newDegree.DegreesCredit, newStudentObj.NumberOfStudent, newTeacher.FirstName + " " + newTeacher.LastName, newCourse.courseName);
        }
    }
}