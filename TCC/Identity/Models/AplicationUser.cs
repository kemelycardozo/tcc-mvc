using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AplicationUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }
}
