using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Person:IFormatIdName
    {
        public virtual string FormatIdAndName(string name, int id)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Name:");
            stringBuilder.Append(name);
            stringBuilder.Append("Id:");
            stringBuilder.Append(id);

            return stringBuilder.ToString();


        }
    }

    public class Student:Person
    {

    }
}
