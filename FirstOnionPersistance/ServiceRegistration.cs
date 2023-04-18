using FirstOnionApplication.Abstracts.Interfaces;
using FirstOnionPersistance.Concretes;
using FirstOnionPersistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FirstOnionPersistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection service)
        {
            service.AddScoped<IProductService,ProductService>();
            service.AddDbContext<AppDbContext> (opt => opt.UseSqlServer("Server=.;Database=OnionDB;Trusted_Connection=True;TrustServerCertificate=True"));
        }
    }
}
