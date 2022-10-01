using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    internal class ButtonHandler
    {
        public static async void Chest(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "chestButton is pressed");
        }
        public static async void Back(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "backButton is pressed");
        }
        public static async void Hips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "hipsButton is pressed");
        }
        public static async void Biceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "bicepsButton is pressed");
        }
        public static async void Triceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "tricepsButton is pressed");
        }
        public static async void Deltoid(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "deltoidButton is pressed");
        }
        public static async void Abs(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "absButton is pressed");
        }
        public static async void Calf(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "calfButton is pressed");
        }
        public static async void Trapezium(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "trapeziumButton is pressed");
        }
    }
}
