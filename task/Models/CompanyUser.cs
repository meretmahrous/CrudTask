using Microsoft.AspNetCore.Identity;

namespace task.Models
{
    public class CompanyUser : IdentityUser
    {
        public string FullName { get; set; }
        
    }
}
