using Nikonov_Viktor_KT_41_20.Interfaces.TeachersInterfaces;
namespace Nikonov_Viktor_KT_41_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<ITeachersService, TeachersService>();
            return services;         
        }

    }
}
