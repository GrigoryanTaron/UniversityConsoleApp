using UniversityConsoleApp.BL;
using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = StudentManager.Create("John", "Doe", 17);
            Student[] students = StudentManager.Create(7, 18);
            Teacher tch = TeacherManager.Create("John1", "Doe1", 22);
            Teacher[] teachers = TeacherManager.Create(6, 22);
            StudentManager.Print(st);
            TeacherManager.Print(tch);
            TeacherManager.Print(teachers);
            StudentManager.Print(students);
            teachers = UniversityManager.SwapWithStudents(teachers, students);
            students = UniversityManager.SwapWithTeachers(students, teachers);
            TeacherManager.Print(teachers);
            StudentManager.Print(students);
            Group group = GroupManager.Create("math");
            Group[] groups = GroupManager.Create(3);
            teachers = UniversityManager.SwapWithGroups(teachers, groups);
            TeacherManager.Print(teachers);
            Console.ReadLine();
        }
    }
}
