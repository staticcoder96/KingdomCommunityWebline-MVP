using KingdomCommunityWebline.Areas.Identity.Data;
using KingdomCommunityWebline.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KingdomCommunityWebline.Data;

public class KingdomDbContext : IdentityDbContext<ApplicationUser>
{
    public KingdomDbContext(DbContextOptions<KingdomDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApprovedMember> ApprovedMembers { get; set; }
    public DbSet<StorehouseItem> StorehouseItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
