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
        public static async void Chest(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "chest",
                replyMarkup: Keyboards.GetChestKeyboard()
                );
        }
        public static async void BenchPress(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "жим лежа");
        }
        public static async void Dips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "отжимания на брусьях");
        }
        public static async void Flys(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "разведение гантелей");
        }
    }
}
