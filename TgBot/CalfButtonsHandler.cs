namespace TgBot
{
    static internal class CalfButtonsHandler
    {
        public static async void Calf(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово! Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetCalfKeyboard()
                );
        }
        public static async void CalfRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Встаньте на носки\n2)Зафиксируйтесь в крайней точке на пару секунд\n3)Вернитесь в исходное положение\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Подъемы на носки.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void SeatedCalfRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Поместите голени под мягкий рычаг.Поместите пальцы ног и подушечки стоп на опоры для ног\n2)Чтобы вес не соскальзывал вперед, возьмитесь за рукоятки и отпустите предохранительную планку.Опускайте вес до тех пор, пока ваши икры не вытянутся\n3)Поднимите пятки вверх, чтобы поднять мягкий рычаг и зафиксируйте его в сокращенном положении, затем медленно опуститесь в исходное положение\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Подъемы с весом на коленях.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
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
