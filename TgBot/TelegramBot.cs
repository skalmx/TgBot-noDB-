﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading;
using System.Configuration;

namespace TgBot
{
    public class TelegramBot
    {
        public static ITelegramBotClient botClient = new TelegramBotClient(ConfigurationManager.AppSettings["token"]!);// токен берется с конфигурационного файла 
        public static CancellationTokenSource cancellationToken = new CancellationTokenSource(); 
        public static Telegram.Bot.Polling.ReceiverOptions receiverOptions = new Telegram.Bot.Polling.ReceiverOptions() 
        {
            AllowedUpdates = Array.Empty<UpdateType>() // позволяет получать все типы updates
        };
        public static async Task Main()
        {
            botClient.StartReceiving(
              updateHandler: GeneralHandler.HandleUpdateAsync,
              pollingErrorHandler: HandlePollingErrorAsync,
              cancellationToken: cancellationToken.Token
            );

            var me = await botClient.GetMeAsync();

            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();

            cancellationToken.Cancel();
        }
        
        public static Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}
