namespace TgBot
{
    static internal class HipsButtonsHandler
    {
        public static async void Hips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово! Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetHipsKeyboard()
                );
        }
        public static async void ForwardLunge(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Займите исходное положение, расставив стопы на ширину бедер\n2)Слегка наклоните корпус вперёд\n3)Сведите лопаптки, немного приподнимите грудную клетку, напрягите пресс\n4)Перенесите вес тела на одну ногу,согнув её в колене, так чтобы он пришелся на центр стопы. Должен образоваться прямой угол между коленом и голенью\n5)На выдохе подняться в исходное положение\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Выпады.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void BarbellSquat(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Поставьте ноги на ширину плеч\n2)Сведите лопатки вместе\n3)Возьмите штангу за плечи и поддерживайте ее верхней частью спины\n4)Отпустите штангу, выпрямив ноги, и сделайте шаг назад\n5)Согните колени, опуская вес, не меняя формы спины, пока бедра не окажутся ниже колен\n6)Верните штангу в исходное положение, поднимите ноги и выдохните в верхней точке\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Приседания со штангой.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void LegExtension(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Сядьте на сиденье тренажёра для экстензии ног и закрепите ноги под рамой\n2)Напрягите четырёхглавые мышцы бёдер и выпрямите ноги\n3)Зафиксируйте это положение минимум на секунду, затем согните ноги и повторите\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Разгибания ног сидя.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
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
