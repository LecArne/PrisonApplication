using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PrisonApplication.Application.Dxos.Cells;
using PrisonApplication.Application.Dxos.Prisoners;
using PrisonApplication.Application.Dxos.PrisonGroups;
using PrisonApplication.Application.Dxos.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Application
{
    public static class ApplicationRegistrations
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ApplicationRegistrations)));
            services.AddMediatR(Assembly.GetAssembly(typeof(ApplicationRegistrations)));

            services.AddTransient<IPrisonGroupsDxos, PrisonGroupsDxos>();
            services.AddTransient<IPrisonsDxos, PrisonsDxos>();
            services.AddTransient<ICellsDxos, CellsDxos>();
            services.AddTransient<IPrisonersDxos, PrisonersDxos>();
        }
    }
}
