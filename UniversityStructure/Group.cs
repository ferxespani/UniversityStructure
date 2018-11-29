using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Group
    {
        private List<Student> students = new List<Student>();
        public Group(List<Student> students)
        {
            this.students = students;
        }
    }
}
