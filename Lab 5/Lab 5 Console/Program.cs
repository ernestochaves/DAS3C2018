using Lab_5;
using System;

namespace Lab_5_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INHERITANCE");
            Student student = new Student();
            PrintInheritance(student);
            Console.WriteLine("COMPOSITION");
            StudentC studentC = new StudentC();
            PrintInheritance(student);
            
            Console.ReadKey();
        }

        public static void PrintInheritance(Student student)
        {
            Console.WriteLine(student.FormatNameAndId("Ernesto Chaves", 111));
        }

        public static void PrintComposition(StudentC student)
        {
            Console.WriteLine(student.FormatNameAndId("Ernesto Chaves", 111));
        }
    }
}
