using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Student : ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get => _age; set => _age = value < 16 ? throw new Exception("Age of student must be >16") : value; }

        private int _age;
        public Teacher _teacher;
        public Group _group;
    }
}
