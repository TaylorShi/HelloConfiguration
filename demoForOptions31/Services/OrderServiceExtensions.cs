using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace demoForOptions31.Services
{
    public static class OrderServiceExtensions
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<OrderServiceOptions>().Configure(options =>
            {
                configuration.Bind(options);
            }).Services.AddSingleton<IValidateOptions<OrderServiceOptions>, OrderServiceValidateOptions>();

            services.AddSingleton<IOrderService, OrderService>();
            return services;
        }
    }

    //services.Configure<OrderServiceOptions>(configuration);
    //services.PostConfigure<OrderServiceOptions>(options =>
    //{
    //    options.MaxOrderCount += 1000;
    //});
}
