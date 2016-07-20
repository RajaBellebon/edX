using System;
using System.Collections.Generic;

namespace edXCourse
{
    public class Student
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; } 
        public string Address2 { get; set; } 
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string BirthdayDate { get; set; }
        public string Postcode { get;set;}
        public int NumberOfStudents { get; set; }
        public static List<string> arrStudent { get; private set; }


        // Constructors
        public Student(string firstName, string lastName, string address1, string address2, string city, string state, string country, string birthdayDate, string postcode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.BirthdayDate = birthdayDate;
            this.Postcode = postcode;
        }

        public int Number(int numberOfStudent)
        {
            this.NumberOfStudents = numberOfStudent;
            return numberOfStudent;

        }
        public Student()
        {
        }



        // This function will try to parse the string date entered by the user and convert it to a date
        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;

            return DateTime.TryParse(txtDate, out tempDate) ? true : false;
        }
        public static string GetStudentInformation(int numberOfStudent)
        {
            // Variable declaration
            DateTime birthDay;
            Student student = new Student();
            Console.WriteLine("Please enter your firstname:"); // Ask the user to enter is first name
            student.FirstName = Console.ReadLine(); // Assign the value entered in the respectie variable
            Console.WriteLine("Please enter your lastName:");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your birthdate :");
            student.BirthdayDate = Console.ReadLine();
            if (IsDateTime(student.BirthdayDate) != true) // If the string date can t be converted to a date, we try to catch the error and as khe use ro enter it again
            {
                try
                {

                    birthDay = Convert.ToDateTime(student.BirthdayDate);

                }

                catch
                {
                    Console.WriteLine("You enter a wrong date, try again");

                    Console.WriteLine("Please enter again your birthdate :");
                    student.BirthdayDate = Console.ReadLine();
                }

            }
            Console.WriteLine("Please enter your first address:");
            student.Address1 = Console.ReadLine();
            Console.WriteLine("Please enter your second address:");
            student.Address2 = Console.ReadLine();
            Console.WriteLine("Please enter your city:");
            student.City = Console.ReadLine();
            Console.WriteLine("Please enter your postcode:");
            student.Postcode = Console.ReadLine();
            Console.WriteLine("Please enter your state:");
            student.State = Console.ReadLine();
            Console.WriteLine("Please enter your country:");
            student.Country = Console.ReadLine();
            string[] arrStudentInformation = { student.FirstName, student.LastName, student.Address1, student.Address2, student.City, student.Postcode, student.State, student.Country, student.BirthdayDate };                      
            string studentInfoLine = "The student " + arrStudentInformation[0] + " " + arrStudentInformation[1] + "\r\n lives here: " + arrStudentInformation[2] + " " + arrStudentInformation[3] + "\r\n in " + arrStudentInformation[4] + " " + arrStudentInformation[5] + " " + arrStudentInformation[6] + " " + arrStudentInformation[7] + "\r\n and born in " + arrStudentInformation[8];          
            numberOfStudent += 1;
            return studentInfoLine;
        }

    }
}