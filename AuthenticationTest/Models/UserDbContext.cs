using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationTest.Models
{
    public class UserDbContext : IdentityDbContext<Microsoft.AspNetCore.Identity.IdentityUser>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }
}