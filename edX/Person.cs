using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourse
{
    public class Person
    {
        // Properties
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string BirthdayDate { get; set; }
        public string Postcode { get; set; }
        
        

        // Constructors
        public Person(string firstName, string lastName, string address, string city, string state, string country, string birthdayDate, string postcode)
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

       
        public Person()
        {
        }
        // This function will try to parse the string date entered by the user and convert it to a date
        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;

            return DateTime.TryParse(txtDate, out tempDate) ? true : false;
        }

        public static string CreateAPerson()
        {
            Person person = new Person();
            // Variable declaration
            DateTime birthDay;
            string personInfoLine = string.Empty;
            Console.WriteLine("Please enter your firstname:"); // Ask the user to enter is first name
            person.FirstName = Console.ReadLine(); // Assign the value entered in the correct variable
            Console.WriteLine("Please enter your lastName:");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Do you want to enter additional information such as birthdate, adress, city, postcode...:if 'no', only firstname and lastname will be recorded");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Please enter your birthdate :");
                person.BirthdayDate = Console.ReadLine();
                if (IsDateTime(person.BirthdayDate) != true) // If the string date can t be converted to a date, we try to catch the error and as khe use ro enter it again
                {
                    try
                    {

                        birthDay = Convert.ToDateTime(person.BirthdayDate);

                    }

                    catch
                    {
                        Console.WriteLine("You enter a wrong date, try again");

                        Console.WriteLine("Please enter again your birthdate :");
                        person.BirthdayDate = Console.ReadLine();
                    }

                }
                Console.WriteLine("Please enter your address:");
                person.Address = Console.ReadLine();
                Console.WriteLine("Please enter your city:");
                person.City = Console.ReadLine();
                Console.WriteLine("Please enter your postcode:");
                person.Postcode = Console.ReadLine();
                Console.WriteLine("Please enter your state:");
                person.State = Console.ReadLine();
                Console.WriteLine("Please enter your country:");
                person.Country = Console.ReadLine();
                string[] personInformation = { person.FirstName, person.LastName, person.Address, person.City, person.Postcode, person.State, person.Country, person.BirthdayDate };
                personInfoLine = personInformation[0] + " " + personInformation[1] + "\r\n lives here: " + personInformation[2] + " " + personInformation[3] + "\r\n in " + personInformation[4] + " " + personInformation[5] + " " + personInformation[6] + " " + personInformation[7] + "\r\n and born in " + personInformation[8];
            }
            else
            {
                string[] personInformation = { person.FirstName, person.LastName };
                 personInfoLine = personInformation[0] + " " + personInformation[1];
            }
            return personInfoLine;
        }
    }
}
