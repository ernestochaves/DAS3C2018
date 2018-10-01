using System;
using System.Text;

namespace Lab_5
{
    public class Person
    {
        public string FormatNameAndId(string name, int id)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(name))
                sb.Append("No name provided - ");
            else
                sb.Append(name.ToUpper() + " - ");
            if (id <= 0)
                sb.Append("( NO ID )");
            else
                sb.Append("( " + id + " )");

            return sb.ToString();
        }
    }

    public class Student : Person
    {

    }
}
