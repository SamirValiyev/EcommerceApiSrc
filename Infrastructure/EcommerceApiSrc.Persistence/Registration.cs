using EcommerceApiSrc.Application.Interfaces.Repositories;
using EcommerceApiSrc.Persistence.Context;
using EcommerceApiSrc.Persistence.Repositories;
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
            serviceCollection.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            serviceCollection.AddScoped(typeof(IWriteRepository<>),typeof(WriteRepository<>));  

        }
    }
}
