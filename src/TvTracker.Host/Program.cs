using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services.ApplicationCommands;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
	.AddDiscordGateway(options =>
	{
		options.Token = builder.Configuration["Discord:Token"];
	})
	.AddApplicationCommands();

var host = builder.Build();

host.AddSlashCommand("square", "Square!", (int a) => $"{a}² = {a * a}");

await host.RunAsync();
