using System;
using System.Threading.Tasks;

namespace DiscordExampleBot
{
    class Program
    {
        public static async Task Main(string[] args)
           => await Bot.RunAsync(args);
    }
}
