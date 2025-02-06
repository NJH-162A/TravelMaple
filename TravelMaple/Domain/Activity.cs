namespace TravelMaple.Domain
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int ItineraryDayId { get; set; }
        public ItineraryDay ItineraryDay { get; set; }
    }
}
