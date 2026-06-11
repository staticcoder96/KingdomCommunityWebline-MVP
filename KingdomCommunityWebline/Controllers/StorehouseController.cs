using Microsoft.AspNetCore.Mvc;
using KingdomCommunityWebline.Models;
using KingdomCommunityWebline.Data;
using Microsoft.EntityFrameworkCore;

namespace KingdomCommunityWebline.Controllers
{
    public class StorehouseController : Controller
    {
        private readonly KingdomDbContext _context;

        public StorehouseController(KingdomDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.StorehouseItems.ToListAsync();
            return View(items);
        }
    }
}
