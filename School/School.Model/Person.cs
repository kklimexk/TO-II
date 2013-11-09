using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Model
{
    public class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
