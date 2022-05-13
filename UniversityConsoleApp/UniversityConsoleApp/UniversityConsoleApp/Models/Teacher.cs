using System;
using System.Text.RegularExpressions;

namespace UniversityConsoleApp.Models
{
    public class Teacher : ModelBase
    {
        public string FirstName
        {
            get =>  "fg";
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;

        }
        public Teacher() : base()
        {

        }

        public Teacher(string firstName, string lastName, int age) : base()
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }


        private string _firstName;
        private string _lastName;
        private int _age;
        public Student[] _students;
        public Group[] _groups;
    }
}
