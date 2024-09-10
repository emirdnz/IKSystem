using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Log : BaseEntity
    {
        public string Message { get; set; }
        public string LogLevel { get; set; } // örneğin, "Info", "Warning", "Error"
    }
}
