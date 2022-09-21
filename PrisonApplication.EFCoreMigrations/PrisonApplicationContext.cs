using Microsoft.EntityFrameworkCore;
using PrisonApplication.EFCoreMigrations.Extensions;
using PrisonApplication.Models.Entity.Cells;
using PrisonApplication.Models.Entity.Prisoners;
using PrisonApplication.Models.Entity.PrisonGroups;
using PrisonApplication.Models.Entity.Prisons;

namespace PrisonApplication.EFCoreMigrations;

public class PrisonApplicationContext : DbContext
{
    public PrisonApplicationContext(DbContextOptions<PrisonApplicationContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    public override int SaveChanges()
    {
        this.AddAuditInfo();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        this.AddAuditInfo();
        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<PrisonGroup> PrisonGroups { get; set; } = null!;
    public DbSet<Prison> Prisons { get; set; } = null!;

    public DbSet<Prisoner> Prisoners { get; set; } = null!;

    public DbSet<Cell> Cells { get; set; } = null!;
}