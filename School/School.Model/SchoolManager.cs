using System.Collections.Generic;
using System.Linq;

namespace School.Model
{
    public class SchoolManager
    {
        private readonly List<SchoolClass> _schoolClasses;

        public SchoolManager()
        {
            _schoolClasses = new List<SchoolClass>();
        }

        public IEnumerable<SchoolClass> SchoolClasses
        {
            get { return _schoolClasses; }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }

        public IEnumerable<Person> FindPersonsBySurname(string surname)
        {
            IEnumerable<Person> persons = new List<Person>();
            foreach (var schoolClass in _schoolClasses)
               persons = persons.Concat(schoolClass.FindPersonsBySurname(surname));
            
            return persons;
        }
    }
}
