﻿using System;
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
                { "грудь", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Chest) },
                { "спина", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Back) },
                { "трапеция", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Trapezium) },
                { "бицепс", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Biceps) },
                { "трицепс", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Triceps) },
                { "пресс", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Abs) },
                { "икры", new Action<ITelegramBotClient, Chat>(StartButtonsHandler.Calf) },
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
