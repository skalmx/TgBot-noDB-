﻿namespace TgBot
{
    static internal class CustomCommands
    {
        public static async void Start(ITelegramBotClient botClient, Chat chat)
        {

            await botClient.SendTextMessageAsync(
                chatId : chat.Id,
                text: "StartCommand",
                replyMarkup: Keyboards.GetStartKeyboard()
                );
        }
        public static async void Help(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "HelpCommand");
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
