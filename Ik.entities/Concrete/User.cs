using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string CompanyName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<Role>? Roles { get; set; } = new List<Role>();
        public User()
        {
            Roles = new List<Role>();
        }
        public bool IsActive { get; set; }

    }
}
