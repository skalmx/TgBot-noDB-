namespace TgBot
{
   static internal class AbsButtonsHandler
   {
        public static async void Abs(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово! Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetAbsKeyboard()
                );
        }
        public static async void HangingKneeRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Исходное положение — держитесь за перекладину хватом чуть шире плеч.\n2)Живот должен быть втянут, а колени слегка согнуты.\n3)Напрягите мышцы пресса и на вдохе подтяните колени к груди.Движение должно происходить за счет скручивания тазом\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Подъем ног на перекладине.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
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
            await botClient.SendTextMessageAsync(chat.Id, "Сядьте на коврик и согните ноги в коленях, слегка отклонитесь назад. Ваш корпус должен образовывать букву «V» с бедрами. Спина в пояснице немного скруглена, пресс напряжен.\n2)Поднимите ноги от пола и начинайте выполнять скрутки корпуса и рук вправо-влево. Колени, в свою очередь, остаются на месте или слегка поворачиваются в противовес корпусу\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Русский твист.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
   }
}
