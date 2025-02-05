namespace TravelMaple.Domain
{
    public class Trip : BaseDomainModel
    {
        public int Duration { get; set; }
        public int MakeId { get; set; }
        public int DestinationId { get; set; }
        public int TransportModeId { get; set; }
        public string? Destination { get; set; }
        public string? Aim { get; set; }
        public int EstBudget { get; set; }

    }
}
