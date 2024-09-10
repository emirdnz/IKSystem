using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class HolidayEvent : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsPublicHoliday { get; set; }
        public string Description { get; set; }
    }
}
