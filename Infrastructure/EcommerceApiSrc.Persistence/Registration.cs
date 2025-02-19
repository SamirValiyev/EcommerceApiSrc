using EcommerceApiSrc.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace EcommerceApiSrc.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection serviceCollection,IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConStr")));

        }
    }
}
