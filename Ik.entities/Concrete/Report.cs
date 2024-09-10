using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Report : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; } 
    }
}
