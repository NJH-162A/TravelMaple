namespace TravelMaple.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }


        public int TravelMapleUserId { get; set; }
        public int TripId { get; set; }
    }
}
