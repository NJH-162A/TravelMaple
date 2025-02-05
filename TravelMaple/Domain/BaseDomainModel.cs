namespace TravelMaple.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
