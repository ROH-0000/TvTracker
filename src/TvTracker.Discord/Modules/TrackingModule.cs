using NetCord.Services.ApplicationCommands;

namespace TvTracker.Discord.Modules;

public class TrackingModule : ApplicationCommandModule<ApplicationCommandContext>
{
	[SlashCommand("track", "Track a TV show!")]
	public string Track(string show) => $"searching for \"{show}\"...";
}