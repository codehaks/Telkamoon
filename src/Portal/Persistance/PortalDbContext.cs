using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portal.Domain.Models;

namespace Portal.Persistance
{
    public class PortalDbContext : IdentityDbContext<ApplicationUser>
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }


    }
}
