using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faculty ComputerScience;
            //List<Specialty> specialities = new List<Specialty>();
            //Specialty Cybernetics, InformationTechnology;
            //specialities.Add(Cybernetics);
            //specialities.Add(InformationTechnology);
            List<Student> students = new List<Student>();
            Student student;
            List<Subject> subjects = new List<Subject>();
            Subject subject;
            for(int i = 0; i < 2; i++)
            {
                Console.Write("Enter the first-name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter the last-name: ");
                string lastName = Console.ReadLine();
                students.Add(student = new Student(firstName, lastName));
            }
            for(int i = 0; i < 2; i++)
            {
                students[i].Show();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter the subject name: ");
                string subjectName = Console.ReadLine();
                Console.Write("Enter the hours of subject: ");
                int hours = int.Parse(Console.ReadLine());
                subjects.Add(subject = new Subject(subjectName, hours));
            }
            for (int i = 0; i < 2; i++)
            {
                subjects[i].Show();
            }
            Group group = new Group(students);
            List<Group> groups = new List<Group>();
            groups.Add(group);

        }
    }
}
