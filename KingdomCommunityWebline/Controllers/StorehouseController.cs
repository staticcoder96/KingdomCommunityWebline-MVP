using Microsoft.AspNetCore.Mvc;
using KingdomCommunityWebline.Models;

namespace KingdomCommunityWebline.Controllers
{
    public class StorehouseController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<StorehouseItem>()
            {
                new StorehouseItem
                {
                    Id = 1,
                    Need = "Rice",
                    Description = "5 lb bag",
                    DateAdded = DateTime.Now,
                    RequestorName = "Charlie",
                    RequestorChurch = "Angel Tabernacle"
                },

                new StorehouseItem
                {
                    Id = 2,
                    Need = "Canned Beans",
                    Description = "6 packs => 60 Total",
                    DateAdded = DateTime.Now,
                    RequestorName = "Donna",
                    RequestorChurch = "Church on the Rock"
                }
            };

            return View(items);
        }
    }
}
