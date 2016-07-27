using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
     
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
      
        


        // Constructors
        public Student(string firstName, string lastName, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;        
            this.City = city;
            
        }


        public Student()
        {
        }
       
        
 

    }
}