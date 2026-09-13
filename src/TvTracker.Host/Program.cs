using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using TvTracker.Discord;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
	.AddDiscordGateway(options =>
	{
		options.Token = builder.Configuration["Discord:Token"];
	})
	.AddApplicationCommands();

var host = builder.Build();

host.AddModules(typeof(IAssemblyMarker).Assembly);

await host.RunAsync();
