using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    internal class TricepsButtonsHandler
    {
        public static async void Triceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "triceps",
                replyMarkup: Keyboards.GetTricepsKeyboard()
                );
        }
        public static async void CablePushdown(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "разгибания на блоке");
        }
        public static async void Dips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Отжимания от скамьи");
        }
        public static async void OverheadExtension(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Разгибание над головой");
        }
    }
}
