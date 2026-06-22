using Microsoft.AspNetCore.Mvc; //allows us to access ASP.Net stuff (controllers, View(), IActionResult etc)
using KingdomCommunityWebline.Models; //allows us to use our Models
using KingdomCommunityWebline.Data; //allows us to talk to the database
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;//use methods like ToListAsync() etc

namespace KingdomCommunityWebline.Controllers
{
    public class StorehouseController : Controller
    {
        private readonly KingdomDbContext _context;

        public StorehouseController(KingdomDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var items = await _context.StorehouseItems.ToListAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetStorehouseItems(
            DateTime? startDate,
            DateTime? endDate,
            string? status) 
        {
            var query = _context.StorehouseItems.AsQueryable();

            //Date Filter
            if (startDate.HasValue)
                query = query.Where(x => x.DateAdded >= startDate);

            if (endDate.HasValue)
                query = query.Where(x => x.DateAdded <= endDate);

            //Status Filter
            if(!string.IsNullOrEmpty(status))
                query = query.Where(x => x.Status == status);

            var data = await query
                .OrderByDescending(x => x.DateAdded)
                .ToListAsync();

            return Json(data);                      
        }

        //Create Item (Modal Post)
        [HttpPost]
        public async Task<IActionResult> Create(StorehouseItem model)
        {
            //If a required field is empty, return error.
            if (!ModelState.IsValid)
                return BadRequest();

            model.DateAdded = DateTime.Now;
            model.Status = "Open";

            _context.StorehouseItems.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        //Edit item (Modal Post)
        [HttpPost]
        public async Task<IActionResult> Update(StorehouseItem model)
        {
            //look up the existing record by ID.
            var item = await _context.StorehouseItems.FindAsync(model.Id);
            if (item == null) return NotFound();

            item.Need = model.Need;
            item.Description = model.Description;
            item.RequestorName = model.RequestorName;
            item.RequestorPhoneNumber = model.RequestorPhoneNumber;
            item.RequestorChurch = model.RequestorChurch;            
            item.RequestorChurchAddress = model.RequestorChurchAddress;
            item.DonorName = model.DonorName;
            item.DonorPhoneNumber = model.DonorPhoneNumber;
            item.DonorChurch = model.DonorChurch;
            item.DonorChurchAddress = model.DonorChurchAddress;
            item.DateDelivered = model.DateDelivered;
            item.DeliveryMethod = model.DeliveryMethod;
            item.Accepted = model.Accepted;
            item.Status = model.Status;
            item.Comments = model.Comments;

            await _context.SaveChangesAsync();
            return Ok(item);
        }

    }
}
