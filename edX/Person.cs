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
        public string FirstName { get; set; }
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
    }
}
