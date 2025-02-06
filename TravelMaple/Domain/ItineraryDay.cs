namespace TravelMaple.Domain;


    public class ItineraryDay
{
    public int Id { get; set; }
    public int DayNumber { get; set; }
    public int TripId { get; set; }
    public Trip Trip { get; set; }
    public DateTime Date { get; set; }
    public List<Activity> Activities { get; set; } = new List<Activity>();
}

