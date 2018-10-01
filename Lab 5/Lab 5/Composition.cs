using System;

namespace Lab_5
{

    public class StudentC
    {

        Person person = new Person();

        public string FormatNameAndId(string name, int id)
        {
            //Changes to person interface not necessarily need to break all the code, just this part. 
            return person.FormatNameAndId(name, id);
        }
    }
}
