using System.Collections.Generic;

namespace School.Model
{
    public class Teacher : Person
    {
        protected List<SchoolClass> _schoolClasses;
        private readonly string _subject;

        public Teacher(string name, string surname, string subject) : base(name, surname)
        {
            this._subject = subject;
        }

        public IEnumerable<SchoolClass> SchoolClasses
        {
            get { return _schoolClasses; }
        }

        public string Subject
        {
            get { return _subject; }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }
    }
}
