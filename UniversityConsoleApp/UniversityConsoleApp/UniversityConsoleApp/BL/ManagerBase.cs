using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class ManagerBase
    {
        public string Person Create(string firstName, string lastName, int age)
            => new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
            };
    }
}
