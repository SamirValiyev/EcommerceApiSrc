using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection serviceCollection)
        {
            var assembly=Assembly.GetExecutingAssembly();

            serviceCollection.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly(assembly));
        }
    }
}
