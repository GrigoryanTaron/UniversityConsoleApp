using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConsoleApp.Models
{
    public class Person:ModelBase
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get ; set ; }
    }
}
