using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenacingBotNet4._6._1.Modules
{
    public class Skills : ModuleBase<SocketCommandContext>
    {
        [Command("skills")]
        public async Task SkillsAsync(string name)
        {
            Random rnd = new Random();

            EmbedBuilder builder = new EmbedBuilder();

            /*builder.AddField("\n\nField1", "test")
                .AddInlineField("Field2", "test")
                .AddInlineField("Field3", "test");
                
           
            builder.WithColor(Color.Purple);

            await ReplyAsync("", false, builder.Build()); 
            */

            builder.WithColor(Color.Purple);

            int skills = rnd.Next(0, 10);
            await ReplyAsync($"Hmmm... I'd rate {name}'s skills a {skills}/10");

        }
    }
}
