﻿using UniversityConsoleApp.BL;
using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = StudentManager.Create("John", "Doe", 19);
            StudentManager.Print(st);
            Student[] students = StudentManager.Create(21, 18);
            StudentManager.Print(students);
            Teacher tch = TeacherManager.Create("John1", "Doe1", 21);
            Teacher[] teachers = TeacherManager.Create(5, 19);
            TeacherManager.Print(teachers);
            st = UniversityManager.SwapWithTeacher(st, tch);
            StudentManager.Print(st);
            teachers = UniversityManager.SwapWithStudents(teachers, students);
            students = UniversityManager.SwapWithTeachers(students, teachers);
            StudentManager.Print(students);
            TeacherManager.Print(teachers);
            Console.ReadLine();
        }
    }
}