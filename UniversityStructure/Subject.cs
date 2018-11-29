using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Subject
    {
        private string _nameOfSubject;
        private int _hours;
        public Subject(string Name, int Hours)
        {
            _nameOfSubject = Name;
            _hours = Hours;
        }

        public Subject()
        { }
        public void Show()
        {
            Console.WriteLine($"Subject name: {_nameOfSubject}  Hours of subject: {_hours}");
        }
    }
}
