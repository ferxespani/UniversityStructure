using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Specialty
    {
        private List<Group> _groups = new List<Group>();
        private List<Subject> _subjects = new List<Subject>();

        public Specialty(List<Group> groups, List<Subject> subjects)
        {
            _groups = groups;
            _subjects = subjects;
        }

    }
}
