using Microsoft.AspNetCore.Identity;

namespace Timesheet.Models.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public byte IsAdmin { get; set; }
    }
}
