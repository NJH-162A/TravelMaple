using Microsoft.AspNetCore.Identity;

namespace TravelMaple.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class TravelMapleUserReal : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
