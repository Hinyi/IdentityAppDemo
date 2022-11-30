using Microsoft.AspNetCore.Identity;

namespace IdentityAppDemo.Models
{
    public class AppUser : IdentityUser
    {
        public string? Nickname { get; set; }
    }
}
