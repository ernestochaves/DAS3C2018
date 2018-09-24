using System;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person proffesor = new Professor( "John","Smith", new string[] { "DAS 3C" } );
            Person student = new Student("Juan", "Perez", 90.5);

            Console.WriteLine(PrintPerson(proffesor));
            Console.WriteLine(PrintPerson(student));

            Console.ReadKey();


        }

        private static string PrintPerson(Person p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p);
            sb.AppendLine();
            sb.Append(p.GetSummary());

            return sb.ToString();
        }
    }
}
