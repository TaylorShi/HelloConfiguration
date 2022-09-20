using Microsoft.Extensions.Configuration;
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
            builder.AddJsonFile("appsettings.json");
            // 构建配置获取配置根
            IConfigurationRoot configurationRoot = builder.Build();
            // 获取并输出配置根下的值
            Console.WriteLine(configurationRoot["car1"]);
            Console.WriteLine(configurationRoot["car2"]);
            Console.WriteLine(configurationRoot["car3"]);
            Console.WriteLine(configurationRoot["car4"]);
        }
    }
}
