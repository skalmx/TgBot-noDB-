namespace TgBot
{
    static internal class HipsButtonsHandler
    {
        public static async void Hips(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "hips",
                replyMarkup: Keyboards.GetHipsKeyboard()
                );
        }
        public static async void ForwardLunge(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "выпады");
        }
        public static async void BarbellSquat(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "приседания со штангой");
        }
        public static async void LegExtension(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "разгибания ног сидя");
        }
    }
}
