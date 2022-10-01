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
    internal class Keyboards
    {
        public static ReplyKeyboardMarkup GetStartKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Грудь", "Спина", "Трапеция" },
                new KeyboardButton[] { "Бицепс", "Трицепс", "Дельта" },
                new KeyboardButton[] { "Пресс", "Икры", "Бедра" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetTestKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "test", "Спина", "Трапеция" },
                new KeyboardButton[] { "test", "Трицепс", "Дельта" },
                new KeyboardButton[] { "test", "Икры", "Бедра" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
    }
}
