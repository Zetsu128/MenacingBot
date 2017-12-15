using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenacingBotNet4._6._1.Modules
{
    public class Ban : ModuleBase<SocketCommandContext>
    {
        String[] reason = new String[] {"Sorry, we only allow people who know ***string theory***!", "It's nothing personnel, kiddo.", "Bye bye, bourgeoisie.", "Those who stay on this server have a /n great sense of pride /n and accomplishment" };

        [Command("Ban")]
        [Summary("Ban @Username")]
        [RequireUserPermission(GuildPermission.BanMembers)] ///Needed User Permissions ///
        [RequireBotPermission(GuildPermission.BanMembers)] ///Needed Bot Permissions ///
        public async Task BanAsync(SocketGuildUser user = null)
        {



            Random rnd = new Random();

            if (user == null) throw new ArgumentException("You must mention a user");

            int skills = rnd.Next(0, 2);

            var gld = Context.Guild as SocketGuild;
            var embed = new EmbedBuilder(); ///starts embed///
            embed.WithColor(new Color(0x8A2BE2)); ///hexacode colours ///
            embed.Title = $"Uh oh, looks like **{user.Username}** was banned!";///Who was banned///
            embed.Description = $"**Username: **{user.Username}\n**Banned by: **{Context.User.Mention}!\n**Reason: **{reason[skills]}"; ///Embed values///

            await gld.AddBanAsync(user);///bans selected user///
            await Context.Channel.SendMessageAsync("", false, embed);///sends embed///
        }
    }
}
