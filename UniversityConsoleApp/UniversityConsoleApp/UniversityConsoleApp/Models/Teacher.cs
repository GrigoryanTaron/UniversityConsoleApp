using System;

namespace UniversityConsoleApp.Models
{
    public class Teacher : Models
    {
        public Teacher() : base()
        {

        }

        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }


        public Student[] _students;
    }
}
