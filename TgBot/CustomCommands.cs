using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TgBot
{
    internal class CustomCommands
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
    }
}   
