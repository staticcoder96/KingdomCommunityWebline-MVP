using KingdomCommunityWebline.Data;
using KingdomCommunityWebline.Models;
using KingdomCommunityWebline.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace KingdomCommunityWebline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KingdomDbContext _context;

        public HomeController(ILogger<HomeController> logger, KingdomDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET Login Page
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // We'll write the ApprovedMembers lookup next.

            //Check the ApprovedMembers table
            var member = _context.ApprovedMembers
                .FirstOrDefault(x => x.EmailAddress == model.EmailAddress);
            
            //Member not found
            if (member == null)
            {
                ModelState.AddModelError("", "You are not an Approved Member.");
                return View(model);
            }

            //User Exists
            if (member.IsRegistered)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity"} );                
            }

            //New & Approved Member & Not Registered, Email Address pre-filled
            return RedirectToPage("/Account/Register", new { area = "Identity", email = model.EmailAddress});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
