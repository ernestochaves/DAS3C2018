using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Person
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public virtual string GetSummary()
        {
            return FirstName + " " + LastName;
        }
    }
}
