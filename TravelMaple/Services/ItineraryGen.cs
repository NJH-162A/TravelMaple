using Microsoft.EntityFrameworkCore;
using TravelMaple.Domain;
using TravelMaple.Data;

namespace TravelMaple.Services
{
    public class ItineraryGen : ItineraryImple
    {
        private readonly TravelMapleContext _context;

        public ItineraryGen(TravelMapleContext context)
        {
            _context = context;
        }

        public async Task GenerateItineraryDaysAsync(Trip trip)
        {
            for (int i = 1; i <= trip.Duration; i++)
            {
                var itineraryDay = new ItineraryDay
                {
                    DayNumber = i,
                    TripId = trip.Id
                };
                _context.ItineraryDay.Add(itineraryDay);
            }
            await _context.SaveChangesAsync();
        }
    }
}
