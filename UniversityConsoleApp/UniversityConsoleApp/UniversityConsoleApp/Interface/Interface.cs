using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.Interface
{
    public interface ICreate
    {
       
        Person Create(string firstName, string lastName, int age);
        List<Person> Create(int count, int minage);
    }
    public interface IPrint
    {
        void Print(Person person);
        void Print(List<Person> persons);
    }
}
