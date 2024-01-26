using Microsoft.AspNetCore.Identity;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        
    }
}