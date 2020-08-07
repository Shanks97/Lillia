using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;

namespace Lillia.Discord
{
    public class DiscordClient
    {
        private bool _initialized;

        public string Prefix { get; set; }
        private string Token { get; set; }
        public DiscordSocketClient Client { get; set; }
        public CommandService Commands { get; set; }
        private IServiceProvider Services { get; set; }




        public DiscordClient(string prefix, string token)
        {
            Client = new DiscordSocketClient();
            Commands = new CommandService();
            Services = new ServiceCollection().AddSingleton(Client).AddSingleton(Commands).BuildServiceProvider();
            Prefix = prefix;
            Token = token;
            Client.Log += Log;
            Client.Ready += OnReady;
        }

        public async Task Run()
        {
            Client.MessageReceived += HandleCommandAsync;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), Services).ConfigureAwait(false);
            await Client.LoginAsync(TokenType.Bot, Token).ConfigureAwait(false);
            await Client.StartAsync().ConfigureAwait(false);
            await Task.Delay(-1).ConfigureAwait(false);
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message is null || message.Author.IsBot || message.Author.IsWebhook)
                return;
            int argPos = 0;
            if (message.HasStringPrefix(Prefix, ref argPos) || message.HasMentionPrefix(Client.CurrentUser, ref argPos))
            {
                var context = new SocketCommandContext(Client, message);
                await Commands.ExecuteAsync(context, argPos, Services).ConfigureAwait(false);
                return;
            }
        }

        private async Task OnReady()
        {

            Console.WriteLine(Client.CurrentUser.Username + "#" + Client.CurrentUser.Discriminator + " Is ready!");
            await Client.SetGameAsync($"{Prefix} waiting 🕙", type: ActivityType.Watching).ConfigureAwait(false);


            if (!_initialized)
            {
                _initialized = true;
            }
        }

        private async Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            await Task.CompletedTask.ConfigureAwait(false);
        }
    }
}
