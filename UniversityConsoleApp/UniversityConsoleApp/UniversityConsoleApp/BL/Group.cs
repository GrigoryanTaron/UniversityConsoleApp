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
        public Group(Student[] students)
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"Students Group {_id}");
            StudentManager.Print(students);
        }
        public Group(Teacher[] teachers)
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"Teachers Group {_id} ");
            TeacherManager.Print(teachers);
        }
        public Guid _id;

    }
}
