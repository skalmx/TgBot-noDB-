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
        public static ReplyKeyboardMarkup GetBackKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Гиперэкстензия" },
                new KeyboardButton[] { "Тяга штанги в наклоне" },
                new KeyboardButton[] { "Подтягивания" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetTrapeziumKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Становая тяга" },
                new KeyboardButton[] { "Тяга троса сидя" },
                new KeyboardButton[] { "Пожимания плечами" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetBicepsKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Концентрированный подъем" },
                new KeyboardButton[] { "Подтягивания обратным хватом" },
                new KeyboardButton[] { "Подъем штанги" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetTricepsKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Разгибания на блоке" },
                new KeyboardButton[] { "Отжимания от скамьи" },
                new KeyboardButton[] { "Разгибание над головой" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetAbsKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Подъем ног на перекладине" },
                new KeyboardButton[] { "Скручивания" },
                new KeyboardButton[] { "Русский твист" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetCalfKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Подъемы на носки" },
                new KeyboardButton[] { "Подъемы с весом на коленях" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
        public static ReplyKeyboardMarkup GetHipsKeyboard()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "Выпады" },
                new KeyboardButton[] { "Приседания со штангой" },
                new KeyboardButton[] { "Разгибания ног сидя" },
                new KeyboardButton[] { "Назад" }
            })
            {
                ResizeKeyboard = true
            };
            return replyKeyboardMarkup;
        }
    }
}
