using System;
using System.Collections.Generic;
using UniversityConsoleApp.Interface;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class StudentManager : ManagerBase, ICreate
    {
       
        const short maxAge = 139;
       public Person Create(string firstName, string lastName, int age)
       => new Student()
       {
           FirstName = firstName,
           LastName = lastName,
           Age = age,
       };

      public List <Person> Create(int count, int minage)
        {
            List<Person> students = new List<Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students.Add(new Student
                {
                    FirstName = $"name{i}",
                    LastName = $"lastName{i}",
                    Age = rnd.Next(minage, maxAge),
                });
                
            }
            return students;
        }

        public  void Print(Student student)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id:{student._id} StName:{student.FirstName} StLastName:{student.LastName} StAge:{student.Age}");
            Console.WriteLine($"**********{student._id}-Teacher**********");
            if (student._teacher != null)
                Console.WriteLine($"id:{student._teacher._id} TchName:{student._teacher.FirstName} TchLastName:{student._teacher.LastName} TchAge:{student._teacher.Age}");
        }
        public void Print(List<Person> personsSt)
        {
            List <Student> students = new List<Student>(personsSt.Count);
            for(int i=0;i<personsSt.Count;i++)
            {
                students.Add((Student)personsSt[i]);
            }
            for (int i = 0; i < students.Count; i++)
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
