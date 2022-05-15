using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class ManagerBase
    {
        const short MaxAge = 70;
        public virtual Person Create(string firstName, string lastName, int age)
            => new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
        public virtual Person[] Create(int count,int minage)
        {
            Person[] persons = new Person[count];
            Random rand = new Random();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person()
                {
                    FirstName = $"firsname{i}",
                    LastName = $"lastname{i}",
                    Age = rand.Next(minage, MaxAge),

                };
            }
            return persons;
        }

    }
}
