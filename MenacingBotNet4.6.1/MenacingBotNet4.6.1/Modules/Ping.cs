using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenacingBotNet4._6._1.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync(string name)
        {
            EmbedBuilder builder = new EmbedBuilder();

            /*builder.AddField("\n\nField1", "test")
                .AddInlineField("Field2", "test")
                .AddInlineField("Field3", "test");

            
            builder.WithColor(Color.Purple);

            Context.User;
            Context.Client;
            Context.Guild;

            

            await ReplyAsync("", false, builder.Build()); 
            */

            await ReplyAsync($"{name} is a noob");
        }
    }
}
