using Microsoft.Extensions.Options;
using System;
using System.ComponentModel.DataAnnotations;

namespace demoForOptions31.Services
{
    public interface IOrderService
    {
        int ShowMaxOrderCount();
    }

    public class OrderService : IOrderService
    {
        readonly IOptionsMonitor<OrderServiceOptions> _options;

        public OrderService(IOptionsMonitor<OrderServiceOptions> options)
        {
            this._options = options;

            options.OnChange((options) =>
            {
                Console.WriteLine($"Last Max Order Count:{options.MaxOrderCount}");
            });
        }

        public int ShowMaxOrderCount()
        {
            return _options.CurrentValue.MaxOrderCount;
        }
    }

    public class OrderServiceOptions
    {
        [Range(0,10)]
        public int MaxOrderCount { get; set; } = 100;
    }

    public class OrderServiceValidateOptions : IValidateOptions<OrderServiceOptions>
    {
        public ValidateOptionsResult Validate(string name, OrderServiceOptions options)
        {
            if(options.MaxOrderCount > 100)
            {
                return ValidateOptionsResult.Fail("Max Order Count 不能大于100");
            }
            else
            {
                return ValidateOptionsResult.Success;
            }
        }
    }
}
