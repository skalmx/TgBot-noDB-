using Telegram.Bot;
using Telegram.Bot.Polling;
using TgBot;
using Telegram.Bot.Types;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.ReplyMarkups;



    /*ITelegramBotClient botClient = new TelegramBotClient(BotCongiguration.botToken);

    using var cancellationTokenSource = new CancellationTokenSource();

    var receiverOptions = new Telegram.Bot.Extensions.Polling.ReceiverOptions
    {
        AllowedUpdates = {} 
    };
    botClient.StartReceiving(
        updateHandler: HandleUpdateAsync,
        pollingErrorHandler: HandlePollingErrorAsync,
        cancellationToken: cancellationTokenSource.Token
        );

    var me = await botClient.GetMeAsync();

    Console.WriteLine($"Start listening for @{me.Username}");
    Console.ReadLine();

    cancellationTokenSource.Cancel();

    async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
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
                cancellationToken: cancellationTokenSource.Token
                ) ;
             return;
        }
        await botClient.SendTextMessageAsync(message.Chat.Id, "Да я до сих пор в разработке");
    
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
    */