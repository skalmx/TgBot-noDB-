namespace TgBot
{
    static internal class CustomCommands
    {
        public static async void Start(ITelegramBotClient botClient, Chat chat)
        {

            await botClient.SendTextMessageAsync(
                chatId : chat.Id,
                text: "Привет! Используй клавиатуру ниже, чтобы выбрать нужные тебе группы мышц и упражнения👇",
                replyMarkup: Keyboards.GetStartKeyboard()
                );
        }
        public static async void Help(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "Такой команды не найдено! Проверьте правильность вашего запроса.\n Если проблема не решилась попробуйте использовать команду /start или /refresh");
        }
        public static async void Github(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Держи ссылку на мой GitHub профиль👇",
                replyMarkup: Keyboards.GetGithubKeyboard()
                );
        }
        public static async void Refresh(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Ваша клавиатура перезагружена🤗👇",
                replyMarkup: Keyboards.GetStartKeyboard()
                );
        }
        public static async void GetBack(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Выбирай раздел 👇",
                replyMarkup: Keyboards.GetStartKeyboard()
                );
        }
    }
}   
