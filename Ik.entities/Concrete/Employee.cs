using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
