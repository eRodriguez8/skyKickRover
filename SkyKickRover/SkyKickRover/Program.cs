using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SkyKickRover.Services;
using SkyKickRover.Services.Interfaces;

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

hostBuilder.ConfigureServices(
    services => services
        .AddTransient<IRotationService, RotationService>());

using IHost host = hostBuilder.Build();

await host.RunAsync();