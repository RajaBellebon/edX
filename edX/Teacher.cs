using System;
using System.Collections.Generic;
using System.Collections;

namespace edXCourse
{
    public class Teacher: Person
    {
        // Properties
        public int Score { get; set; }
       
        // Constructors
        public Teacher(string firstName, string lastName, int score)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Score = score;
        }

        public Teacher()
        {
        }
        public static List<string> getTeacher()
        {
            Teacher teach = new Teacher();
            Console.WriteLine("Enter the teacher information");
            List<string> listTeacher = new List<string>();
            var teacherInfo = CreateAPerson();

            listTeacher.Add(teacherInfo);
            return listTeacher;
        }
        
        public static string GradeTest(int averageSc)
        {
            Teacher teacher = new Teacher();
        
            teacher.Score = averageSc;
            var grade = "";
           if (teacher.Score >=80)
           { return grade = "A";}
            else if(teacher.Score < 80 && teacher.Score >=60)
            {return grade = "B";}
            else if(teacher.Score < 60 && teacher.Score >=50)
            {return grade = "C";}
            else if(teacher.Score < 50 && teacher.Score >=35)
            {return grade = "D";}
            else
           { return grade = "E"; }
            
        }
    }
}
