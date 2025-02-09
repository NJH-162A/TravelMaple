namespace TravelMaple.Domain
{
    public class Trip : BaseDomainModel
    {
        public string? Name { get; set; }
        public int EstBudget { get; set; }
        public int Duration { get; set; }
        public string? Destination { get; set; }
        public string? Aim { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }



        public List<ItineraryDay> ItineraryDays { get; set; } = new List<ItineraryDay>();

    }
}
