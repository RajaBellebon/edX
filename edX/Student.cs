using System;
using System.Collections;
using System.Collections.Generic;

namespace edXCourse
{
    public class Student : Person
    {
        public int NumberOfStudent { get; set; }       
        
       
        public static int averageScore { get; set; }
        public Student(string firstName, string lastName, string address, string city, string state, string country, string birthdayDate, string postcode, int numberOfStudent)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.BirthdayDate = birthdayDate;
            this.Postcode = postcode;
            
        }
        public Student(int numberOfStudent)
        {
            this.NumberOfStudent = numberOfStudent;
           
        }
        public Student()
        {
        }
       
        public static List<string> StudentInfo(int NumberOfStudent)
        {
            
            Console.WriteLine("Enter the student information");
            List<string> listStudent = new List<string>();
            for (int i = 0; i < NumberOfStudent; i++)
            {
                
                var studentInfo = CreateAPerson();

                listStudent.Add(studentInfo);

            }
            
            return listStudent;             
        }
        
        public static int giveScore()
        {
            Random rnd = new Random();
            int value = rnd.Next(10, 95);
            return value;
        }
        public static int averageScoreMethod(int number)
        {
            int sum = 0;
            Stack<int> scoreStack = new Stack<int>();
            for (int j = 0; j < 5; j++)
            {
                var sc = giveScore();
                scoreStack.Push(sc);

            }
          
            foreach (int i in scoreStack)
            {

                sum = i + sum;
            }
            int averageScore = sum / scoreStack.Count;
            return averageScore;
        }


    }
}
