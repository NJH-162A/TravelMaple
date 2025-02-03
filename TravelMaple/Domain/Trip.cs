namespace TravelMaple.Domain
{
    public class Trip : BaseDomainModel
    {
        public int Duration { get; set; }
        public int MakeId { get; set; }
        public int DestinationId { get; set; }
        public int TransportModeId { get; set; }

    }
}
