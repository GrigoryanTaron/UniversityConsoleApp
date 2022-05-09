using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class Group
    {
        public Group()
        {

        }
        public Group(Student[] students ,Teacher[] teachers)
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"Students Group {_id}");
            _students = students;
            StudentManager.Print(_students);
            _id = Guid.NewGuid();
            Console.WriteLine($"Teachers Group {_id} ");
            _teachers = teachers;
            TeacherManager.Print(_teachers);
        }
        public Guid _id;
        public Student[] _students;
        public Teacher[] _teachers;

    }
}
