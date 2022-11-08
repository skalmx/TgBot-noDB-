namespace TgBot
{
   static internal class AbsButtonsHandler
   {
        public static async void Abs(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "abs",
                replyMarkup: Keyboards.GetAbsKeyboard()
                );
        }
        public static async void HangingKneeRaise(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "подъем ног на перекладине");
        }
        public static async void Crunches(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Скручивания");
        }
        public static async void Twist(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Русский твист");
        }
   }
}
