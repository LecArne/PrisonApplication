using PrisonApplication.Models.Entity.PrisonGroups;
using PrisonApplication.Models.Entity.Prisons;
using PrisonApplication.Models.Entity.Prisoners;
using PrisonApplication.Models.Entity.Cells;
using PrisonApplication.Repositories;

namespace PrisonApplication.Web;

public static class StartupExtensions
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddTransient<IRepository<PrisonGroup>,Repository<PrisonGroup>>();
        services.AddTransient<IRepository<Prison>, Repository<Prison>>();
        services.AddTransient<IRepository<Prisoner>, Repository<Prisoner>>();
        services.AddTransient<IRepository<Cell>, Repository<Cell>>();
    }
}
