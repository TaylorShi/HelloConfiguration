using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;

namespace demoForConsoler31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建配置构建器
            IConfigurationBuilder builder = new ConfigurationBuilder();
            // 添加Json文件数据源
            builder.AddJsonFile("appsettings.json",optional: false, reloadOnChange: true);
            // 构建配置获取配置根
            IConfigurationRoot configurationRoot = builder.Build();
            var customConfig = new CustomConfig
            {
                Car1 = "xxx",
                Car2 = "xxx",
                Car3 = "xxx",
                Car4 = -1,
            };
            //configurationRoot.Bind(customConfig);
            configurationRoot.GetSection("model").Bind(customConfig, 
                configureOptions => { configureOptions.BindNonPublicProperties = true; });

            // 获取并输出配置根下的值
            Console.WriteLine(customConfig.Car1);
            Console.WriteLine(customConfig.Car2);
            Console.WriteLine(customConfig.Car3);
            Console.WriteLine(customConfig.Car4);
            Console.WriteLine(customConfig.Car5);
            Console.ReadKey();
        }
    }
}
