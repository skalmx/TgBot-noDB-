namespace TgBot
{
    static internal class BicepsButtonsHandler
    {
        public static async void Biceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово! Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetBicepsKeyboard()
                );
        }
        public static async void ConcentrationCurl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Возьмите гантель хватом снизу и сядьте на край скамьи. Поставьте ноги гораздо шире плеч. Ступни плотно прижаты к полу\n2)Исходное положение: наклонитесь вперед и упритесь нижней частью правого трицепса во внутреннюю часть бедра. Рука чуть согнута в локте.\n3)Сделайте вдох и задержите дыхание. Напрягите бицепс и поднимите гантель к грудной клетке. Преодолев самый сложный участок подъема, слегка выдохните.\n4)Когда гантель почти коснется груди, сделайте паузу, еще сильнее напрягите бицепс. Плавно опустите гантель, одновременно делая выдох\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Концентрированный подъем.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void ChinUps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Возьмитесь за перекладину, держа кисти на ширине плеч. Пальцы должны быть развернуты к вам\n2)Выталкивайте тело наверх, напрягая двуглавые мышцы и спину. Двигайтесь на выдохе\n3)Подтягиваясь к перекладине, старайтесь соединять лопатки друг с другом\n4)Таким образом двигайтесь до верхней точки, то есть до того момента, пока подбородок не окажется чуть выше перекладины\n5)На секунду задержавшись в верхней точке, медленно и плавно опускайтесь вниз\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Подтягивания обратным хватом.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void Curl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Исходное положение: стоя ровно, возьмите штангу хватом по ширине плеч\n2)Слегка согните ноги в коленях и немного подкрутите таз — это выпрямит позвоночник и снизит нагрузку на поясницу. Лопатки сведены вместе, плечи опущены вниз, грудь выставлена вперед, пресс напряжен\n3)Медленно поднимите вес за счет силы бицепса. Траектория движения штанги должна напоминать полуокружность. В верхней точке вы должны осознанно чувствовать напряжение бицепса\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Подъем штанги.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
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

