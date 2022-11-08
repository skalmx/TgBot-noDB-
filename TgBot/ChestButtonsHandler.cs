namespace TgBot
{
   static internal class ChestButtonsHandler
   {
        public static async void Chest(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово!Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetChestKeyboard()
                );
        }
        public static async void BenchPress(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Лягте на горизонтальную скамью для жима лежа и положите руки на штангу. Расстояние между руками должно быть примерно 55-60 см.\n2)Отведите лопатки назад, грудь расправьте вперед.\n3)Снимите штангу со стойки, зафиксировав локти.\n4)Вдохните, опуская штангу к груди, до линии сосков или чуть ниже. Следите за тем, чтобы лопатки были сведены.\n5)Выдохните, нажимая на гриф над грудью, выпрямляйте руки.\n6)Повторите нужное вам количество раз\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Жим лежа.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void Dips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Установить руки на брусья.\n2)Выпрямить спину и установить ноги в стартовую позицию, а именно поставить прямо, вытянув носки вниз.\n3)становить локти в удобную и устойчивую позицию, при которой они не будут испытывать дискомфорта.\n4)Отжиматься внизу амплитуды, не выравнивая руки полностью. Нужно оставлять в локтях небольшой угол, который нужен в целях безопасности.\n5)Выпрямлять руки тоже нужно не полностью, чтобы упражнение не превратилось в шлифовку локтевых суставов и чтобы атлет не нагружал трицепс больше, чем грудные\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Отжимания на брусьях.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void Flys(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Лягте на скамью и поставьте ноги на землю.\n2)Начните упражнение, держа гантели над грудью, слегка согнув локти.\n3)Одновременно опустите гантели в обе стороны.\n4)Сделайте паузу, когда гантели окажутся параллельны скамье, затем поднимите руки в исходное положение\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Разведение гантелей.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
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
