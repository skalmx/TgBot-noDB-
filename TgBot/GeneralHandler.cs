using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TgBot
{
    internal class GeneralHandler
    {
        
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // https://win10tweaker.ru/forum/topic/как-это-работает
            if (update.Message is not { } message) // is not null message 
                return;

            if (message.Text is not { } messageText) // is not null message Text
                return;
            
            Console.WriteLine($"{message.Chat.Username ?? message.Chat.FirstName} wrote {message.Text}"); // message.Chat.Username ?? message.Chat.FirstName - имя собеседника 

            if (message.Text.ToLower() == "/start")
            {
                BotComands.StartComand(botClient, message.Chat);
            }
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                {
                    new KeyboardButton[] { "Help me", "Call me ☎️" },
                    
                })
                {
                    ResizeKeyboard = true
                };

            await botClient.SendTextMessageAsync(message.Chat.Id, "Да я до сих пор в разработке");

        }
    }
}
