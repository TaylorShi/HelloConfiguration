using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;

namespace demoForExtSource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建配置构建器
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddCustomConfiguration();
            // 构建配置获取配置根
            IConfigurationRoot configurationRoot = builder.Build();
            ChangeToken.OnChange(() => configurationRoot.GetReloadToken(), () =>
            {
                // 获取并输出配置根下的值
                Console.WriteLine(configurationRoot["lastTime"]);
            });
            Console.ReadKey();
        }
    }
}
