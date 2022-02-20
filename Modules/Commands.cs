using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace botTesting.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("cHelp")]
        public async Task cHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.tutorialspoint.com/cprogramming/index.htm");
        }
        [Command("jsHelp")]
        public async Task jsHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.w3schools.com/Js/");
        }
        [Command("pyHelp")]
        public async Task pyHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.geeksforgeeks.org/python-programming-language/");
        }
        [Command("jHelp")]
        public async Task jHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.w3schools.com/java/java_intro.asp");
        }
        [Command("csHelp")]
        public async Task csHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.w3schools.com/cs/index.php");
        }
        [Command("cppHelp")]
        public async Task cppHelp()
        {
            await ReplyAsync("\n Hope this helps! https://www.geeksforgeeks.org/c-plus-plus/");
        }
        [Command("Help")]
        public async Task Help()
        {
            await ReplyAsync("\n List of Commands:\n~cHelp\n~jsHelp\n~pyHelp\n~jHelp\n~csHelp\n~cppHelp\n~CampusFood\n~Stocks\n~Music\n~cLinkedList\n~cStructs");
        }
        [Command("CampusFood")]
        public async Task CampusFood()
        {
            await ReplyAsync("\n Hope this helps! https://dining.wsu.edu/dining-options/");
        }
        [Command("Stocks")]
        public async Task Stocks()
        {
            await ReplyAsync("\n Buy low, sell lower. https://www.msn.com/en-us/money/markets?duration=1D");
        }
        [Command("Music")]
        public async Task Music()
        {
            await ReplyAsync("\n Hope this helps! \n https://www.spotify.com/us/ \n https://soundcloud.com/");
        }
        [Command("cLinkedList")]
        public async Task cLL()
        {
            await ReplyAsync("\n Hope this helps! \n https://www.geeksforgeeks.org/linked-list-set-1-introduction/");
        }
        [Command("cStructs")]
        public async Task cSrcts()
        {
            await ReplyAsync("\n Hope this helps! \n https://www.geeksforgeeks.org/structures-c/");
        }
    }
}