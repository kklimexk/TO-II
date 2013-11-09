using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School.Model;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolManager school = new SchoolManager();
            SchoolClass schoolClass = new SchoolClass("4C");
            school.AddClass(schoolClass);

            schoolClass.Teacher = new Teacher("Janusz", "Kowalski", "Podstawy języka C#");
            schoolClass.AddStudent(new Student("Ania", "Misia"));
            schoolClass.AddStudent(new Student("Zuzia", "Pysia"));
            schoolClass.AddStudent(new Student("Grześ", "Kowalski"));
            schoolClass.AddStudent(new Student("Jaś", "Nowak"));

            Console.WriteLine(schoolClass.GetDescription());
            Console.WriteLine("=============================================\n");

            foreach (Person person in school.FindPersonsBySurname("Kowalski"))
                Console.WriteLine(" * " + person.ToString());

            Console.ReadKey();
        }
    }
}
