using AutoMapper;
using Ik.Bl.Abstract;
using Ik.Dal.Context;
using Ik.entities.Concrete;
using IKAPI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IKAPI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IKDB _context;
        private readonly IUserManager _usermanager;
        private readonly IMapper _mapper;

        public AdminController(IKDB context,IUserManager userManager,IMapper mapper)
        {
            _context = context;
            _usermanager = userManager; 
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            var users = _context.Users.ToList();
            return View(users);
        }



        [HttpGet]
        public IActionResult Create() 
        { 
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateDTO createDTO)
        {

            if (!ModelState.IsValid)
            {
                return View(createDTO);

            }


            var user = _mapper.Map<User>(createDTO);
            try
            {
                await _usermanager.InsertAsync(user);

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
                return View(createDTO);
            }


            return RedirectToAction("Index");
        }




        public IActionResult Reporting() { return View(); }

        public IActionResult Log() { return View(); }

        public IActionResult CompanyApproval() { return View(); }

        public IActionResult Login() { return View(); }

        public IActionResult AccountLog() { return View(); }


    }



}