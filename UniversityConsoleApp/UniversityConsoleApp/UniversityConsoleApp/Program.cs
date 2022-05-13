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
            Student[] students = StudentManager.Create(21, 18);
            Teacher tch = TeacherManager.Create("John1", "Doe1", 21);
            Teacher[] teachers = TeacherManager.Create(8, 30);
            st = UniversityManager.SwapWithTeacher(st, tch);
            Group group = GroupManager.Create("math");
           
            Group[] groups = GroupManager.Create(3);
            teachers = UniversityManager.SwapWithStudents(teachers, students);
            students = UniversityManager.SwapWithTeachers(students, teachers);
           
            teachers = UniversityManager.SwapWithGroups(teachers, groups);
            TeacherManager.Print(teachers);
            Console.ReadLine();
        }
    }
}
