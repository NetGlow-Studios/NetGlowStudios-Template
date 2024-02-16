using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ngs.Common.AspNetCore.Infrastructure.Context.Base;

public class BaseIdentityDbContext<TDbContext, TUser, TRole>(DbContextOptions<TDbContext> options) : IdentityDbContext<TUser, TRole, Guid>(options) 
    where TDbContext : DbContext where TUser : IdentityUser<Guid> where TRole : IdentityRole<Guid>
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}  