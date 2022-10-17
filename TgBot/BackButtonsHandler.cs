using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    static internal class BackButtonsHandler
    {
        public static async void Back(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "back",
                replyMarkup: Keyboards.GetBackKeyboard()
                );
        }
        public static async void Hyperextension(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "hyperextension");
        }
        public static async void PullUps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "подтягивания");
        }
        public static async void BentOverRows(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "тяга в наклоне");
        }
    }
}
