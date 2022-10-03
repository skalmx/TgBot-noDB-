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
                new KeyboardButton[] { "Пресс", "Икры", "Бедра" },
                new KeyboardButton[] { "Трицепс", "Бицепс" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static InlineKeyboardMarkup GetGithubKeyboard()
        {
            InlineKeyboardMarkup inlineKeyboardMarkup = new(new[]
            {
                InlineKeyboardButton.WithUrl(
                    text: "Мой Github",
                    url: "https://github.com/skalmx"
                    )
            });
            return inlineKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetChestKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Жим лежа" },
                new KeyboardButton[] { "Отжимания на брусьях" },
                new KeyboardButton[] { "Разведение гантелей" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
    }
}
