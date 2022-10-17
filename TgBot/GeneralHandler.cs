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
    static internal class GeneralHandler
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

            Dictionary<string, Action<ITelegramBotClient, Chat>> commands = new Dictionary<string, Action<ITelegramBotClient, Chat>>()
            {
                { "/start", new Action<ITelegramBotClient, Chat>(CustomCommands.Start)},
                { "/refresh", new Action<ITelegramBotClient, Chat>(CustomCommands.Refresh)},
                { "/help", new Action<ITelegramBotClient, Chat>(CustomCommands.Help)},
                { "/github", new Action<ITelegramBotClient, Chat>(CustomCommands.Github)},
                { "назад", new Action<ITelegramBotClient, Chat>(CustomCommands.GetBack)},
                { "грудь", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Chest)},
                { "спина", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.Back)},
                { "трапеция", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Trapezium)},
                { "бицепс", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.Biceps)},
                { "трицепс", new Action<ITelegramBotClient, Chat>(TricepsButtonsHandler.Triceps)},
                { "пресс", new Action<ITelegramBotClient, Chat>(AbsButtonsHandler.Abs)},
                { "икры", new Action<ITelegramBotClient, Chat>(CalfButtonsHandler.Calf)},
                { "бедра", new Action<ITelegramBotClient, Chat>(HipsButtonsHandler.Hips)},
                { "жим лежа", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.BenchPress)},
                { "отжимания на брусьях", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Dips)},
                { "разведение гантелей", new Action<ITelegramBotClient, Chat>(ChestButtonsHandler.Flys)},
                { "гиперэкстензия", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.Hyperextension)},
                { "тяга штанги в наклоне", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.BentOverRows)},
                { "подтягивания", new Action<ITelegramBotClient, Chat>(BackButtonsHandler.PullUps)},
                { "cтановая тяга", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Deadlift)},
                { "тяга троса сидя", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.SeatedCableRow)},
                { "пожимания плечами", new Action<ITelegramBotClient, Chat>(TrapeziumButtonsHandler.Shrug)},
                { "концентрированный подъем", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.ConcentrationCurl)},
                { "подтягивания обратным хватом", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.ChinUps)},
                { "подъем штанги", new Action<ITelegramBotClient, Chat>(BicepsButtonsHandler.Curl)},
                { "разгибания на блоке", new Action<ITelegramBotClient, Chat>(TricepsButtonsHandler.CablePushdown)},
                { "отжимания от скамьи", new Action<ITelegramBotClient, Chat>(TricepsButtonsHandler.Dips)},
                { "разгибание над головой", new Action<ITelegramBotClient, Chat>(TricepsButtonsHandler.OverheadExtension)},
                { "подъем ног на перекладине", new Action<ITelegramBotClient, Chat>(AbsButtonsHandler.HangingKneeRaise)},
                { "скручивания", new Action<ITelegramBotClient, Chat>(AbsButtonsHandler.Crunches)},
                { "русский твист", new Action<ITelegramBotClient, Chat>(AbsButtonsHandler.Twist)},
                { "подъемы на носки", new Action<ITelegramBotClient, Chat>(CalfButtonsHandler.CalfRaise)},
                { "подъемы с весом на коленях", new Action<ITelegramBotClient, Chat>(CalfButtonsHandler.SeatedCalfRaise)},             
                { "выпады", new Action<ITelegramBotClient, Chat>(HipsButtonsHandler.ForwardLunge)},
                { "приседания со штангой", new Action<ITelegramBotClient, Chat>(HipsButtonsHandler.BarbellSquat)},
                { "разгибания ног сидя", new Action<ITelegramBotClient, Chat>(HipsButtonsHandler.LegExtension)}
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
