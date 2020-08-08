using Discord;
using Lillia;
using LoLAPI.Classes;

namespace System
{

    public static class APIExtensions
    {
        public static Color _color = Color.DarkPurple;

        public static Embed ToEmbed(this Summoner summoner)
        {
            var eb = new EmbedBuilder()
            .WithAuthor(Program.Client.Client.CurrentUser)
            .WithColor(_color)
            .AddField("Name", summoner.Name, true)
            .AddField("Level", summoner.SummonerLevel, true)
            .WithTimestamp(DateTimeOffset.FromUnixTimeMilliseconds(summoner.RevisionDate))
            .WithFooter("Last Activity")
            .WithThumbnailUrl(summoner.IconUrl())
            .Build();
            return eb;
        }

    }
}