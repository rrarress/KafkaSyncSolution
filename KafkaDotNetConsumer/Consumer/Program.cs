// See https://aka.ms/new-console-template for more information
using Consumer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
            services.AddSingleton<IHostedService, ApacheKafkaConsumerService>())
    .Build();


await host.RunAsync();