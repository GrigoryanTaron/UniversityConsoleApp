using UniversityConsoleApp.BL;
using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            Student st =(Student) studentManager.Create("Bob", "Marley", 24);
            Student[] students = (Student[])studentManager.Create(12, 18);
            TeacherManager teacherManager = new TeacherManager();
            Teacher tch =(Teacher) teacherManager.Create("John", "Doe", 22);
            Teacher[] teachers =(Teacher[]) teacherManager.Create(6, 22);
           // StudentManager.Print(st);
           // TeacherManager.Print(tch);
            //TeacherManager.Print(teachers);
            //StudentManager.Print(students);
            teachers = UniversityManager.SwapWithStudents(teachers, students);
            students = UniversityManager.SwapWithTeachers(students, teachers);
            TeacherManager.Print(teachers);
            StudentManager.Print(students);
            Group group = GroupManager.Create("math");
            Group[] groups = GroupManager.Create(3);
            teachers = UniversityManager.SwapWithGroups(teachers, groups);
            //TeacherManager.Print(teachers);
            Console.ReadLine();
        }
    }
}
