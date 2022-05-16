using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Student : Person
    {
        private int _age;
        public override int Age { get => _age; set => _age = value < 16 ? throw new Exception("Age of student must be >16") : value; }
        public Teacher _teacher;
        public Group _group;
    }
}
