﻿namespace TravelMaple.Domain
{
    public class TravelMapleUser : BaseDomainModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
