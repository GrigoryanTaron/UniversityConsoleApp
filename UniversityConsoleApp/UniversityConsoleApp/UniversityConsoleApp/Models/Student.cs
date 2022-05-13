using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Student : ModelBase
    {
        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age) : base()
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;

        }

        public string _firstName;
        public string _lastName;
        public int _age;
        public Teacher _teacher;
        public Group _group;
    }
}
