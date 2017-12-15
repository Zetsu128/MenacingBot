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
    public class Kick : ModuleBase<SocketCommandContext>
    {
        String[] reason = new String[] { "Sorry, we only allow people who know ***string theory***!", "It's nothing personal, kiddo.", "Bye bye, bourgeoisie." };

        [Command("Kick")]
        [RequireBotPermission(GuildPermission.KickMembers)] ///Needed BotPerms///
        [RequireUserPermission(GuildPermission.KickMembers)] ///Needed User Perms///
        public async Task KickAsync(SocketGuildUser user = null)
        {



            Random rnd = new Random();

            if (user == null) throw new ArgumentException("You must mention a user");

            int skills = rnd.Next(0, 2);

            var gld = Context.Guild as SocketGuild;
            var embed = new EmbedBuilder(); ///starts embed///
            embed.WithColor(new Color(0x8A2BE2)); ///hexacode colours ///
            embed.Title = $"Uh oh, looks like **{user.Username}** was kicked!";///Who was banned///
            embed.Description = $"**Username: **{user.Username}\n**Kicked by: **{Context.User.Mention}!\n**Reason: **{reason[skills]}"; ///Embed values///

            await user.KickAsync();///bans selected user///
            await Context.Channel.SendMessageAsync("", false, embed);///sends embed///
        }
    }
}
