using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Faculty
    {
        private List<Specialty> _specialty = new List<Specialty>();
        public Faculty(List<Specialty> specialty)
        {
            _specialty = specialty;
        }
    }
}
