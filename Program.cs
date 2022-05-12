using Microsoft.Extensions.Hosting;
using Specky6;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => services.AddSpecks())
    .Build();

((StartUp)host.Services.GetService(typeof(StartUp))!).Start();