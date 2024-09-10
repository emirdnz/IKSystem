using Ik.Dal.Context;
using IKAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IKAPI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IKDB _context;

        public AccountController(IKDB context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _context.Users
                    .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {

                    var userRole = user.RoleId;


                    if (userRole == 1) // Admin
                    {
                        return RedirectToAction("Login", "Admin", new { area = "Admin" });
                    }
                    else if (userRole == 2) // HR
                    {
                        return RedirectToAction("Index", "Hr", new { area = "Hr" });
                    }
                    else if (userRole == 3) // Employee
                    {
                        return RedirectToAction("Index", "Employee", new { area = "Employee" });
                    }
                    else
                    {

                        return RedirectToAction("AccessDenied", "Account");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            return View(model);
        }


    }
}
