using System;

namespace UniversityConsoleApp.Models
{
    public class Student : Models
    {
        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Teacher _teacher;
    }
}
