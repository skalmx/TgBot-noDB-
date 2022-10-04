using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.IO;

namespace TgBot
{
    internal class ButtonHandler
    {
        public static async void Chest(ITelegramBotClient botClient, Chat chat)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName + @"\videos\Выпады.mp4";
            
            await botClient.SendTextMessageAsync(chat.Id, "chestButton is pressed");
            using (var stream = System.IO.File.OpenRead(path))
            {
                
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: stream!,
                    supportsStreaming: true
                    );
            }
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "chest",
                replyMarkup: Keyboards.GetChestKeyboard()
                );

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