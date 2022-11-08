namespace TgBot
{
    static internal class BicepsButtonsHandler
    {
        public static async void Biceps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "biceps",
                replyMarkup: Keyboards.GetBicepsKeyboard()
                );
        }
        public static async void ConcentrationCurl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Концентрированный подъем");
            /*await botClient.SendTextMessageAsync(chat.Id, "chestButton is pressed");
            string path = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName + @"\videos\Выпады.mp4";
            using (var stream = System.IO.File.OpenRead(path))
            {

                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: stream!,
                    supportsStreaming: true
                    );
            }*/
        }
        public static async void ChinUps(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подтягивания обратным хватом");
        }
        public static async void Curl(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Подъем штанги");
        }



    }
}

