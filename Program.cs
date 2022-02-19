using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;


namespace botTest { 
public class Program
{
	public static Task Main(string[] args) => new Program().MainAsync();
		private DiscordSocketClient _client;
		public async Task MainAsync()
        {
			_client = new DiscordSocketClient();

			_client.Log += Log;

			//  You can assign your bot token to a string, and pass that in to connect.
			//  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
			var token = "OTQ0NjcxMTI2MzAxMzMxNDk2.YhE_iw.hr5EwC0cxKFai-Xqm75ijoTcI04";

			// Some alternative options would be to keep your token in an Environment Variable or a standalone file.
			// var token = Environment.GetEnvironmentVariable("NameOfYourEnvironmentVariable");
			// var token = File.ReadAllText("token.txt");
			// var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			// Block this task until the program is closed.
			await Task.Delay(-1);
		}
		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}
	}
}

public class LoggingService
{
	public LoggingService(DiscordSocketClient client, CommandService command)
	{
		client.Log += LogAsync;
		command.Log += LogAsync;
	}
	private Task LogAsync(LogMessage message)
	{
		if (message.Exception is CommandException cmdException)
		{
			Console.WriteLine($"[Command/{message.Severity}] {cmdException.Command.Aliases.First()}"
				+ $" failed to execute in {cmdException.Context.Channel}.");
			Console.WriteLine(cmdException);
		}
		else 
			Console.WriteLine($"[General/{message.Severity}] {message}");

		return Task.CompletedTask;
	}
}
