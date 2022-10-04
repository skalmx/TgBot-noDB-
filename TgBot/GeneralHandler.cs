using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Reflection;
using System.IO;

namespace TgBot
{
    internal class GeneralHandler
    {
        
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            
            if (update.Message!.Type != MessageType.Text)
            {
                CustomCommands.Help(botClient, update.Message!.Chat);
            }
           
            if (update.Message is not { } message) // is not null message 
                return;

            if (message.Text is not { } messageText) // is not null message Text
                return;

            Console.WriteLine($"{message.Chat.Username ?? message.Chat.FirstName} wrote {messageText}"); // message.Chat.Username ?? message.Chat.FirstName - имя собеседника

            Dictionary<string,Action<ITelegramBotClient,Chat>> commands = new Dictionary<string, Action<ITelegramBotClient, Chat>>()
            {
                { "/start", new Action<ITelegramBotClient, Chat>(CustomCommands.Start) },
                { "/refresh", new Action<ITelegramBotClient, Chat>(CustomCommands.Refresh) },
                { "/help", new Action<ITelegramBotClient, Chat>(CustomCommands.Help) },
                { "/github", new Action<ITelegramBotClient, Chat>(CustomCommands.Github) },
                { "назад", new Action<ITelegramBotClient, Chat>(CustomCommands.GetBack) },
                { "грудь", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Chest) },
                { "спина", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.Back) },
                { "трапеция", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Trapezium) },
                { "бицепс", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.Biceps) },
                { "трицепс", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Triceps) },
                { "пресс", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Abs) },
                { "икры", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Calf) },
                { "жим лежа", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.BenchPress) },
                { "отжимания на брусьях", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Dips) },
                { "разведение гантелей", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Flys) },
                { "гиперэкстензия", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.Hyperextension) },
                { "тяга штанги в наклоне", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.BentOverRows) },
                { "подтягивания", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.PullUps) },
                { "cтановая тяга", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Deadlift) },
                { "тяга троса сидя", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.SeatedCableRow) },
                { "пожимания плечами", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Shrug) },
                { "концентрированный подъем", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.ConcentrationCurl) },
                { "подтягивания обратным хватом", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.ChinUps) },
                { "подъем штанги", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.Curl) },

            };

            if (commands.ContainsKey(messageText.ToLower()))
                commands[messageText.ToLower()].Invoke(botClient, message.Chat);
            else
            {
               await Task.Run(()=> CustomCommands.Help(botClient, message.Chat));
            }
        }
      
    }
}
