using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public  class TeacherManager:ManagerBase
    {
        const short maxAge = 139;
        public override Person Create(string firstName, string lastName, int age)
            => new Teacher()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
        public override Person[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher()
                {
                    FirstName = $" name{i}",
                    LastName = $" lastName{i}",
                    Age = rnd.Next(minAge, maxAge),
                };
            }
            return teachers;
        }
        public static void Print(Teacher teacher)
        {
            Console.WriteLine("**********Teacher********");
            Console.WriteLine($"id:{teacher._id} name:{teacher.FirstName} lastName:{teacher.LastName} age:{teacher.Age}");
            Console.WriteLine($"**************{teacher._id}-Student**********");
            if (teacher._students != null)
                for (int i = 0; i < teacher._students.Length; i++)
                {
                    Console.WriteLine($"id:{teacher._students[i]._id} StName:{teacher._students[i].FirstName} StLastName:{teacher._students[i].LastName} StAge:{teacher._students[i].Age}");
                }
        }
        public static void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine("**********Teacher********");
                Console.WriteLine($"id:{teachers[i]._id} TchName:{teachers[i].FirstName} TchLastName{teachers[i].LastName} TchAge:{teachers[i].Age}");
                if (teachers[i]._students != null)
                {
                    Console.WriteLine($"**************Teacher id:{teachers[i]._id}-Student**********");
                    for (int j = 0; j < teachers[i]._students.Length; j++)
                    {
                        Console.WriteLine($"id:{teachers[i]._students[j]._id} StName:{teachers[i]._students[j].FirstName} StLastName:{teachers[i]._students[j].LastName} StAge:{teachers[i]._students[j].Age}");
                    }
                }

                if (teachers[i]._groups != null)
                {
                    for (int j = 0; j < teachers[i]._groups.Length; j++)
                    {
                        Console.WriteLine($"GroupId:{teachers[i]._groups[j]._id} GroupName:{teachers[i]._groups[j].Name}");
                    }

                }
            }
        }

    }
}
