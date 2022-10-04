using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    internal class CalfButtonsHandler
    {
        public static async void Calf(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "calf",
                replyMarkup: Keyboards.GetCalfKeyboard()
                );
        }
        public static async void CalfRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подъемы на носки");
        }
        public static async void SeatedCalfRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подъемы с весом на коленях");
        }
    }
}
