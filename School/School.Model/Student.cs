using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Model
{
    public class Student : Person
    {
        public Student(string name, string surname) : base(name, surname)
        {
        }

        public SchoolClass SchoolClass { get; set; }
    }
}
