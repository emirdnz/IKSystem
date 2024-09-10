using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Settings : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
