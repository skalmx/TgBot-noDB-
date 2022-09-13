using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Exceptions;

ITelegramBotClient botClient = new TelegramBotClient("5521913177:AAFrPUb0CMxHB0zxXWnsr77WlueIh-tlBXw");

using var cts = new CancellationTokenSource();

var receiverOptions = new Telegram.Bot.Extensions.Polling.ReceiverOptions
{
    AllowedUpdates = {} // receive all update types
};
botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    cancellationToken: cts.Token
    );

var me = await botClient.GetMeAsync();

Console.WriteLine($"Start listening for @{me.Username}");
Console.ReadLine();

cts.Cancel();

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    if (update.Message is not { } msg)
       return;
  
    if (msg.Text is not { } messageText)
       return;

    var message = update.Message;
    if (message.Text != null)
    {
        if (message.Text.ToLower() == "/start")
        {
            await botClient.SendTextMessageAsync(message.Chat.Id, "Привет я нахожусь в разработке)");
            return;
        }
        await botClient.SendTextMessageAsync(message.Chat.Id, "Да я до сих пор в разработке");
    }
    return;
}

Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
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

