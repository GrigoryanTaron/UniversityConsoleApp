using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConsoleApp.Models
{
    public class ModelBase
    {
        public Guid _id { get; } = Guid.NewGuid();
    }
}
