using TravelMaple.Domain;

namespace TravelMaple.Services
{
    public interface ItineraryImple
    {
        Task GenerateItineraryDaysAsync(Trip trip);
    }
}

