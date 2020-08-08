using Discord;
using Discord.Commands;
using LoLAPI.EndPoints;
using System;
using System.Threading.Tasks;

namespace Lillia.Commands
{
    [Summary("ignore")]
    public class BaseCommand : ModuleBase<SocketCommandContext>
    {
        public const string mew_face = "(= 'w'=)";

        [Command("get")]
        public async Task GetSummoner(params string[] name)
        {
            var summ = await SummonerManager.GetByName(string.Join(' ', name));
            await ReplyAsync(embed: summ.ToEmbed());
        }

        public async Task Check()
        {
            await Context.Message.AddReactionAsync(new Emoji("✅")).ConfigureAwait(false);
        }

        public async Task Deny()
        {
            await Context.Message.AddReactionAsync(new Emoji("❌")).ConfigureAwait(false);
        }

    }
}
