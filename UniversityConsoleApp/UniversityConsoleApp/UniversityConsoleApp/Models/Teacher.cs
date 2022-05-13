using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Teacher : ModelBase
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get => _age; set => _age = value < 21 ? throw new Exception("Age of teacher must be >21") : value; }
        public string ID { get; set; }
        private int _age;
        public Student[] _students;
        public Group[] _groups;
    }
}
