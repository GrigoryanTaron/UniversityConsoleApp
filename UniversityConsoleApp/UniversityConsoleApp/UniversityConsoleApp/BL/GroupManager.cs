using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public static class GroupManager
    {
        public static Group Create(string name)
            => new Group(name);
        public static Group[] Create(int count)
        {
            Group[] groups = new Group[count];
            for (int i = 0; i < count; i++)
            {
                groups[i] = new Group($"GrName{i}");
            }
            return groups;
        }
        public static void Print(Group group)
        {
            Console.WriteLine("************Group************");
            Console.WriteLine($"GroupId:{group._id} GroupName:{group._name}");

            
        }
        public static void Print(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"**************Group**************");
                Console.WriteLine($"GroupId:{groups[i]._id} Groupname:{groups[i]._name}");
               
            }
        }

    }
}
