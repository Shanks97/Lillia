using Lillia.Discord;
using System;
using System.Threading.Tasks;

namespace Lillia
{
    class Program
    {
        public static DiscordClient Client = new DiscordClient(".", "NzQwMjgzODgyNzIwNzIyOTQ0.XymxFw.B2gZ6D3Gk7DX6gd9dDcHd01lRqE");
        static async Task Main(string[] args)
        {
            await Client.Run()
                .ConfigureAwait(false);
        }
    }
}
