namespace TgBot
{
   static internal class AbsButtonsHandler
   {
        public static async void Abs(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово!Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetAbsKeyboard()
                );
        }
        public static async void HangingKneeRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "подъем ног на перекладине");
        }
        public static async void Crunches(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Ложитесь на пол и согните ноги под углом в 90 градусов. Следите за тем, чтобы ваша поясница оставалась плотно прижатой к полу во время выполнения каждого повтора.\n2)Скрестите руки на груди или заложите их за голову, не переплетая пальцы.\n3)Медленно, за счёт напряжения мышц живота оторвите плечи от пола на несколько сантиметров.\n4)Плавно опуститесь в исходное положение и повторите упражнение\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Скручивания.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void Twist(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Русский твист");
        }
   }
}
