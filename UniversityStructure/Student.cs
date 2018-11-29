using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        public Student(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }
        public Student()
        { }
        public void Show()
        {
            Console.WriteLine($"First-name: {_firstName}  Last-name: {_lastName}");
        }
    }
}
