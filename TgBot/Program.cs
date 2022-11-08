namespace TgBot
{
    public class Program
    {
        public static TelegramBotClient botClient = new TelegramBotClient(ConfigurationManager.AppSettings["token"]!);// токен берется с конфигурационного файла 
        public static CancellationTokenSource cancellationToken = new CancellationTokenSource(); 
        public static Telegram.Bot.Polling.ReceiverOptions receiverOptions = new Telegram.Bot.Polling.ReceiverOptions() 
        {
            AllowedUpdates = Array.Empty<UpdateType>() // позволяет получать все типы updates
        };
        public static async Task Main()
        {
            botClient.StartReceiving(
              updateHandler: GeneralHandler.HandleUpdateAsync,
              pollingErrorHandler: ErrorHandler.HandlePollingErrorAsync,
              cancellationToken: cancellationToken.Token
            );

            var me = await botClient.GetMeAsync();

            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();

            cancellationToken.Cancel();
        }
        
    }
}
