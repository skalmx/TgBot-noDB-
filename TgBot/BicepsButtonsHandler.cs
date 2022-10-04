using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot
{
    internal class BicepsButtonsHandler
    {
        public static async void Biceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "biceps",
                replyMarkup: Keyboards.GetBicepsKeyboard()
                );
        }
        public static async void ConcentrationCurl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Концентрированный подъем");
        }
        public static async void ChinUps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подтягивания обратным хватом");
        }
        public static async void Curl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подъем штанги");
        }

        /*string path = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName + @"\videos\Выпады.mp4";

        await botClient.SendTextMessageAsync(chat.Id, "chestButton is pressed");
        /* using (var stream = System.IO.File.OpenRead(path))
         {

             await botClient.SendVideoAsync(
                 chatId: chat.Id,
                 video: stream!,
                 supportsStreaming: true
                 );
         }*/
    }
}
