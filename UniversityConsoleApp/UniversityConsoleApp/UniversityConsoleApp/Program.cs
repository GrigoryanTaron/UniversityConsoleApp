using UniversityConsoleApp.BL;
using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = StudentManager.Create("John", "Doe", 19);
            // StudentManager.Print(st);
            Student[] students = StudentManager.Create(21, 18);
            //StudentManager.Print(students);
            Teacher tch = TeacherManager.Create("John1", "Doe1", 21);
            Teacher[] teachers = TeacherManager.Create(8, 30);
            // TeacherManager.Print(teachers);
            st = UniversityManager.SwapWithTeacher(st, tch);
            // StudentManager.Print(st);
            Group group = GroupManager.Create("math");
            group = UniversityManager.SwapWithStudents(group, students);
           // GroupManager.Print(group);
            group = UniversityManager.SwapWithTeachers(group, teachers);
            //  GroupManager.Print(group);
            Group[] groups = GroupManager.Create(3);
            //teachers = UniversityManager.SwapWithStudents(teachers, students);
            // students = UniversityManager.SwapWithTeachers(students, teachers);
            //StudentManager.Print(students);
            // TeacherManager.Print(teachers);
            teachers = UniversityManager.SwapWithGroups(teachers, groups);
            GroupManager.Print(groups);
            Console.ReadLine();
        }
    }
}
