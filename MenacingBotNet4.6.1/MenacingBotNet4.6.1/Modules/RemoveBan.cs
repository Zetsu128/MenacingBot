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
    public class RemoveBan : ModuleBase<SocketCommandContext>
    {

        [Command("unban")]
        [Summary("Unbans @Username")]
        [RequireUserPermission(GuildPermission.BanMembers)] ///Needed User Permissions ///
        [RequireBotPermission(GuildPermission.BanMembers)] ///Needed Bot Permissions ///
        public async Task BanAsync(SocketGuildUser user = null, [Remainder] string reason = null)
        {
            var dmChannel = await Context.User.GetOrCreateDMChannelAsync();

            if (user == null) throw new ArgumentException("You must mention a user");
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("You must provide a reason");

            var gld = Context.Guild as SocketGuild;
            var embed = new EmbedBuilder(); ///starts embed///
            
            //Embed for server
            embed.WithColor(new Color(0x8A2BE2)); ///hexacode colours ///
            embed.Title = $"It seems **{user.Username}** was unbanned.";///Who was banned///
            embed.Description = $"**Username: **{user.Username}\n**Unbanned by: **{Context.User.Mention}!\n**Reason: **{reason}"; ///Embed values///

            //Embed for user
            var embedDM = new EmbedBuilder();
            embed.WithColor(new Color(0x8A2BE2)); ///hexacode colours ///
            embed.Title = $"It seems were you unbanned!";///Who was banned///
            embed.Description = $"**Unbanned by: **{Context.User.Mention}!\n**Reason: **{reason}\n**Server: **{gld}"; ///Embed values///

            await gld.RemoveBanAsync(user);


            await gld.RemoveBanAsync(user);///unbans selected user///
            await dmChannel.SendMessageAsync("", false, embed);///sends embed///

        }
    }
}
