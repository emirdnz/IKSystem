using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.entities.Concrete
{
    public class Expense : BaseEntity
    {
        public Employee Employee { get; set; }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
