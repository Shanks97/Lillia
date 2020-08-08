using Lillia.Discord;
using System;
using System.Threading.Tasks;

namespace Lillia
{
    class Program
    {
        public static DiscordClient Client = new DiscordClient(".", Environment.GetEnvironmentVariable("lillia"));
        static async Task Main(string[] args)
        {
            await Client.Run()
                .ConfigureAwait(false);
        }
    }
}
