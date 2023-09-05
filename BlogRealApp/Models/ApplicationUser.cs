using Microsoft.AspNetCore.Identity;

namespace BlogRealApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String? FirstName { get; set; }
        public String? LastName { get; set; }

        // relation
        public List<Post>? Posts { get; set; }
    }
}
