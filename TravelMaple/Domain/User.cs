using Microsoft.AspNetCore.Identity;

namespace TravelMaple.Domain

{
    public class TravelMapleUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
