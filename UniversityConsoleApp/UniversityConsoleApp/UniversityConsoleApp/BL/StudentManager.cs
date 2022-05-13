using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public static class StudentManager
    {
        const short maxAge = 139;
        public static Student Create(string firstName, string lastName, int age)
            => new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
        public static Student[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student()
                {
                    FirstName = $"name{i}",
                    LastName = $"lastName{i}",
                    Age = rnd.Next(minAge, maxAge),
                };
            }
            return students;
        }
        public static void Print(Student student)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id:{student._id} StName:{student.FirstName} StLastName:{student.LastName} StAge:{student.Age}");
            Console.WriteLine($"**********{student._id}-Teacher**********");
            if (student._teacher != null)
                Console.WriteLine($"id:{student._teacher._id} TchName:{student._teacher.FirstName} TchLastName:{student._teacher.LastName} TchAge:{student._teacher.Age}");
        }
        public static void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("**********Student**********");
                Console.WriteLine($"id:{students[i]._id} StName:{students[i].FirstName} StLastName:{students[i].LastName} StAge:{students[i].Age}");
                if (students[i]._teacher != null)
                {
                    Console.WriteLine($"**********Student id:{students[i]._id}-Teacher**********");
                    Console.WriteLine($"id:{students[i]._teacher._id} TchName:{students[i]._teacher.FirstName} TchLastName:{students[i]._teacher.LastName} TchAge:{students[i]._teacher.Age}");
                }
                if (students[i]._group != null)
                    Console.WriteLine(value: $"GroupId:{students[i]._group._id} GroupName:{students[i]._group.Name}");
            }
        }
    }
}
