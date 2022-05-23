using UniversityConsoleApp.BL;
using System;
using UniversityConsoleApp.Models;
using System.Collections.Generic;

namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            Student st = (Student)studentManager.Create("Bob", "Marley", 24);
            List<Person> persons = studentManager.Create(12, 18);
            TeacherManager teacherManager = new TeacherManager();
            Teacher tch = (Teacher)teacherManager.Create("John", "Doe", 22);
           List< Person> teachers = teacherManager.Create(6, 22);
            // StudentManager.Print(st);
            // TeacherManager.Print(tch);
            //TeacherManager.Print(teachers);
            //StudentManager.Print(students);
            //teachers = UniversityManager.SwapWithStudents(teachers, students);
            //students = UniversityManager.SwapWithTeachers(students, teachers);
            teacherManager.Print(teachers);
            studentManager.Print(persons);
            Group group = GroupManager.Create("math");
            Group[] groups = GroupManager.Create(3);
            //teachers = UniversityManager.SwapWithGroups(teachers, groups);
            //TeacherManager.Print(teachers);
            Console.ReadLine();
            
        }
    }
}
