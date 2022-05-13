using System;

namespace UniversityConsoleApp.Models
{
    public class Group:ModelBase
    {
        public Group()
        {

        }
        public Group(string name):base()
        {
            
            _name = name;
        }

        
        public string _name;
       
    }
}
