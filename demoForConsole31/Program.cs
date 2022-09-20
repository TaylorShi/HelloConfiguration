using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace demoForConsole31
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // 创建配置构建器
    //        IConfigurationBuilder builder = new ConfigurationBuilder();
    //        // 添加内存数据源
    //        builder.AddInMemoryCollection(new Dictionary<string, string>
    //        {
    //            { "car1", "tesla"},
    //            { "car2", "benci"},
    //            { "group:car3", "byd"}
    //        });
    //        // 构建配置获取配置根
    //        IConfigurationRoot configurationRoot = builder.Build();
    //        // 获取并输出配置根下的值
    //        Console.WriteLine(configurationRoot["car1"]);
    //        Console.WriteLine(configurationRoot["car2"]);
    //        // 获取并输出配置节点下的值
    //        IConfigurationSection configurationSection = configurationRoot.GetSection("group");
    //        Console.WriteLine($"car3:{configurationSection["car3"]}");
    //        Console.WriteLine($"car4:{configurationSection["car4"]}");
    //    }
    //}
}
