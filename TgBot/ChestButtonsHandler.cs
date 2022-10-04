using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    internal class ChestButtonsHandler
    {
        Dictionary<string, Action<ITelegramBotClient, Chat>> commands = new Dictionary<string, Action<ITelegramBotClient, Chat>>()
        {
            { "" }
        };
    }
}
