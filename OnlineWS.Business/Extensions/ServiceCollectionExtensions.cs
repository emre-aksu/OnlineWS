using Microsoft.Extensions.DependencyInjection;
using OnlineWS.Business.Contracts;
using OnlineWS.Business.Implementations;
using OnlineWS.Business.Mapping.Automapper.Profiles;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWS.DateAccess.EF.Repositories;

namespace OnlineWS.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(ProductProfile));
            services.AddAutoMapper(typeof(ProductPhotoProfile));

            //MANAGER REGISTRATIONS
            //--REGISTRTAION işlemi aşağıdaki gibi de yazılabilir----- 
            //services.Add( new ServiceDescriptor(
            //    typeof(ICategoryManager),
            //    typeof(CategoryManager),
            //    ServiceLifetime.Scoped));
             //----------------------------------------------------------  
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IProductPhotoManager, ProductPhotoManager>();
            //REPOSİTORY REGISTRATIONS
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductPhotoRepository, ProductPhotoRepository>();
          
        } 
    }
}
