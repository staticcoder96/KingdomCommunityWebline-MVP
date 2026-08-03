using KingdomCommunityWebline.Data;
using KingdomCommunityWebline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace KingdomCommunityWebline.Controllers
{
    [Authorize]
    public class BarterCentreController : Controller
    {
        private readonly KingdomDbContext _context;

        public BarterCentreController(KingdomDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetBarterCentreItems(
            DateTime? startDate,
            DateTime? endDate,
            string? status)
        {
            var query = _context.BarterCentreItems.AsQueryable();

            //Date Filter
            if (startDate.HasValue)
            {
                query = query.Where(x => x.DateAdded >= startDate);
            }
            if (endDate.HasValue) {
                query = query.Where(x => x.DateAdded <= endDate);
            }

            //Status Filter
            if (!string.IsNullOrEmpty(status)) {
                query = query.Where(x => x.Status == status);
            }

            var data = await query
                .OrderByDescending(x => x.DateAdded)
                .ToListAsync();

            return Json(data);
        }

        //Create Item (Modal POST)
        [HttpPost]
        public async Task<IActionResult> Create(BarterCentreItem model)
        {
            //If a required field is empy, return error
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            model.DateAdded = DateTime.Now;
            model.Status = "Open";

            _context.BarterCentreItems.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        //Edit item (POST)
        [HttpPost]
        public async Task<IActionResult> Update(BarterCentreItem model)
        {
            //look up the existing record by ID.
            var item = await _context.BarterCentreItems.FindAsync(model.Id);
            if (item == null) return NotFound();

            item.Item = model.Item;
            item.Description = model.Description;
            item.RequestorName = model.RequestorName;
            item.RequestorPhoneNumber = model.RequestorPhoneNumber;
            item.RequestorChurch = model.RequestorChurch;
            item.RequestorChurchAddress = model.RequestorChurchAddress;
            item.RespondentName = model.RespondentName;
            item.RespondentPhoneNumber = model.RespondentPhoneNumber;
            item.RespondentChurch = model.RespondentChurch;
            item.RespondentChurchAddress = model.RespondentChurchAddress;
            item.CounterOffer = model.CounterOffer;
            item.CounterOfferStatus = model.CounterOfferStatus;
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
