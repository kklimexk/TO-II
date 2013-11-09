using System.Collections.Generic;
using System.Linq;

namespace School.Model
{
    public class SchoolClass
    {
        private readonly string _name;
        private readonly List<Student> _students;
        private Teacher _teacher;

        public SchoolClass(string name)
        {
            _students = new List<Student>();
            this._name = name;
        }

        public string Name 
        {
            get { return _name; }        
        }

        public IEnumerable<Student> Students
        {
            get { return _students; }
        }

        public Teacher Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public IEnumerable<Person> FindPersonsBySurname(string surname)
        {
            var persons = new List<Person>();
            
            foreach (var student in _students.Where(student => (student.Surname == surname)))
                persons.Add(student);
            
            if (Teacher.Surname.Equals(surname))
                persons.Add(Teacher);

            return persons;
        }

        public string GetDescription()
        {
            string description = "Klasa " + this._name + "\n\n";
            description += "Wychowawca: ";
            if (_teacher != null)
            {
                description += _teacher.ToString() + "\n\n";
            }
            else
            {
                description += "[brak] \n\n";
            }
            description += "Uczniowie: " + _students.Count() + "\n";
            foreach (var student in _students)
            {
                description += " - " + student.ToString() + "\n";
            }
            return description;
        }
    }
}
