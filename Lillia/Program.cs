using Lillia.Discord;
using System;
using System.Threading.Tasks;

namespace Lillia
{
    class Program
    {
        public static DiscordClient Client = new DiscordClient(".", "NzQwMjgzODgyNzIwNzIyOTQ0.XymxFw.7hf8cGsk5YXCeDQ0I4TRFltKSe4");
        static async Task Main(string[] args)
        {
            await Client.Run()
                .ConfigureAwait(false);
        }
    }
}
