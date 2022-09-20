using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace demoForConsole31
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //// 创建配置构建器
    //        //IConfigurationBuilder builder = new ConfigurationBuilder();
    //        //// 添加环境变量数据源
    //        //builder.AddEnvironmentVariables();
    //        //// 构建配置获取配置根
    //        //IConfigurationRoot configurationRoot = builder.Build();
    //        //// 获取并输出配置根下的值
    //        //Console.WriteLine(configurationRoot["car1"]);
    //        //Console.WriteLine(configurationRoot["car2"]);
    //        //// 单级分层
    //        //Console.WriteLine(configurationRoot.GetSection("car")["car3"]);
    //        //// 多级分层
    //        //Console.WriteLine(configurationRoot.GetSection("car4:car5")["car6"]);

    //        // 创建配置构建器
    //        IConfigurationBuilder builder = new ConfigurationBuilder();
    //        // 添加环境变量数据源并且过滤前缀
    //        builder.AddEnvironmentVariables("car_");
    //        // 构建配置获取配置根
    //        IConfigurationRoot configurationRoot = builder.Build();
    //        // 获取并输出配置根下的值
    //        Console.WriteLine(configurationRoot["car_xxx"]);
    //    }
    //}
}
