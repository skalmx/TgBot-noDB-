using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    static internal class TrapeziumButtonsHandler
    {
        public static async void Trapezium(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "traps",
                replyMarkup: Keyboards.GetTrapeziumKeyboard()
                );
        }
        public static async void Deadlift(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Cтановая тяга ");
        }
        public static async void SeatedCableRow(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "тяга троса сидя");
        }
        public static async void Shrug(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "пожимания плечами");
        }
    }
}
