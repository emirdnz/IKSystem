using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Resume : BaseEntity
    {

        public Employee Employee { get; set; }
        public string EducationDetails { get; set; }
        public string CertificationDetails { get; set; }
        public string ExperienceDetails { get; set; }
        public string Skills { get; set; }
    }
}
