using System;
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
        public static ITelegramBotClient botClient = new TelegramBotClient(ConfigurationManager.AppSettings["token"]!);
        public static CancellationTokenSource cancellationToken = new CancellationTokenSource();
        public static Telegram.Bot.Polling.ReceiverOptions receiverOptions = new Telegram.Bot.Polling.ReceiverOptions()
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };
        public static async Task Main()
        {
            botClient.StartReceiving(
              updateHandler: HandleUpdateAsync,
              pollingErrorHandler: HandlePollingErrorAsync,
              cancellationToken: cancellationToken.Token
            );

            var me = await botClient.GetMeAsync();

            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();

            cancellationToken.Cancel();
        }
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            //https://win10tweaker.ru/forum/topic/как-это-работает
            if (update.Message is not { } message) // is not null message 
                return;

            if (message.Text is not { } messageText) // is not null message Text
                return;
            

            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Exapmple1", "Exapmple2" }
            })
                {
                    ResizeKeyboard = true
                };

            if (message.Text.ToLower() == "/start")
            {
                await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Привет, рад тебя видеть! Как я могу тебе помочь?",
                    disableNotification: true,
                    replyMarkup: replyKeyboardMarkup,
                    cancellationToken: cancellationToken
                    );
                return;
            }
            await botClient.SendTextMessageAsync(message.Chat.Id, "Да я до сих пор в разработке");

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
