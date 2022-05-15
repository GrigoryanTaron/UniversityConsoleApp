using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Teacher : Person
    {
        private int _age;
        public override int Age { get => _age; set => _age = value < 21 ? throw new Exception("Age of tacher must be >21") : value; }
        public Student[] _students;
        public Group[] _groups;
    }
}
