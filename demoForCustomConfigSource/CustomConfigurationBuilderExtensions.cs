using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoForExtSource
{
    public static class CustomConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddCustomConfiguration(this IConfigurationBuilder builder)
        {
            builder.Add(new CustomConfigurationSource());
            return builder;
        }
    }
}
