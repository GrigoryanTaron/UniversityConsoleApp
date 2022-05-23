using System;
using System.Collections.Generic;
using UniversityConsoleApp.Interface;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public  class TeacherManager:ManagerBase,ICreate,IPrint
    {
        const short maxAge = 139;
   public Person Create(string firstName, string lastName, int age)
            => new Teacher()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
      public List<Person> Create(int count, int minAge)
        {
           List<Person> teachers = new List< Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < teachers.Count; i++)
            {
                teachers.Add( new Teacher()
                {
                    FirstName = $" name{i}",
                    LastName = $" lastName{i}",
                    Age = rnd.Next(minAge, maxAge),
                });
            }
            return teachers;
        }

       

         void IPrint.Print(Person person)
        {
            Teacher teacher=new Teacher();
            teacher=(Teacher)person;
            Console.WriteLine("**********Teacher********");
            Console.WriteLine($"id:{teacher._id} name:{teacher.FirstName} lastName:{teacher.LastName} age:{teacher.Age}");
            Console.WriteLine($"**************{teacher._id}-Student**********");
            if (teacher._students != null)
                for (int i = 0; i < teacher._students.Length; i++)
                {
                    Console.WriteLine($"id:{teacher._students[i]._id} StName:{teacher._students[i].FirstName} StLastName:{teacher._students[i].LastName} StAge:{teacher._students[i].Age}");
                }
        }
       public  void Print(List<Person>personsTchs)
        {
           List< Teacher> teachers = new List <Teacher>(personsTchs.Count);
            for(int i=0;i<personsTchs.Count;i++)
            {
                teachers.Add((Teacher)personsTchs[i]);
            }
            

            for (int i = 0; i < teachers.Count; i++)
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
