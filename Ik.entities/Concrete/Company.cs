using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
