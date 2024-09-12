using Ik.Dal.Context;
using Ik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IKAPI.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        private readonly IKDB _context;

        public EmployeeController(IKDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitExpense(string expenseType, decimal amount, DateTime date, IFormFile receiptFile)
        {
            if (receiptFile != null && receiptFile.Length > 0)
            {
                // Dosyayı sunucuya kaydedin veya gerekli işlemleri yapın
                var filePath = Path.Combine("wwwroot/uploads", Path.GetFileName(receiptFile.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await receiptFile.CopyToAsync(stream);
                }
            }

            // Masraf nesnesini oluşturun ve kaydedin
            var expense = new Expense
            {
                ExpenseType = expenseType,
                Amount = amount,
                // Diğer özellikleri ayarlayın
            };

            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); // Yönlendirmek istediğiniz yere
        }


        public IActionResult LeaveRequest() { return View(); }

        public IActionResult Profile() { return View(); }

        public IActionResult Taskmanagement() { return View(); }
    }
}
