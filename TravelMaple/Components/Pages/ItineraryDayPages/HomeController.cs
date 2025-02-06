using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelMaple.Data;
using TravelMaple.Domain;

namespace TravelMaple.Components.Pages.ItineraryDayPages
{
    public class ItineraryController : Controller
    {
        private readonly TravelMapleContext _context;

        public ItineraryController(TravelMapleContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var trips = from t in _context.Trip
                        select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                trips = trips.Where(s => s.Name.Contains(searchString));
            }

            return View(await trips.ToListAsync());
        }

        public async Task<IActionResult> TripItinerary(int id)
        {
            var trip = await _context.Trip
                .Include(t => t.ItineraryDays)
                .ThenInclude(d => d.Activities)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }
    }

}

