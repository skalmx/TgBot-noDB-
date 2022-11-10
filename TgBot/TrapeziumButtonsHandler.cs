namespace TgBot
{
    static internal class TrapeziumButtonsHandler
    {
        public static async void Trapezium(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(
                chatId: chat.Id,
                text: "Готово! Выбирай упражнение ниже👇",
                replyMarkup: Keyboards.GetTrapeziumKeyboard()
                );
        }
        public static async void Deadlift(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Плечи и лопатки отведите немного назад. Ноги расставьте уже уровня плеч (примерно на уровне бедер), коснитесь голенями грифа. Положение стоп – параллельно друг другу. Гриф проходит над центром стопы\n2)Присядьте – отведите таз назад и выпрямите спину, но не выводите колени за линию носков\n3)Возьмитесь руками за гриф хватом на ширине плеч. Руки – прямые, локти зафиксированы. При классическом хвате ладони повернуты вниз\n4)Выставьте грудь и плечи немного вперед за линию штанги. Взгляд направлен строго вниз. Не раскачиваясь и не перенося вес тела на носки, сорвите штангу движением мышц ног – квадрицепсов и ягодиц."
+ "После того как штанга прошла 20 - 30 % амплитуды, выпрямите поясницу, выталкивая таз вперед, и зафиксируйте позицию.В точке подъема веса можно выставить грудь вперед(но не сводить лопатки)\n5)Перед тем как опустить штангу, отведите бедра назад так, чтобы не задеть грифом колени.При движении вниз держите позвоночник в нейтральном положении – не выгибайте и не прогибайте.Только после того, как гриф достигнет уровня колен, их можно согнуть\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Становая тяга.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void SeatedCableRow(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Примите изначальную позицию: выберите необходимый вам вес, сядьте на скамью тренажера, слегка согнув ноги в коленном суставе и уперевшись стопами в специальные опоры. Возьмитесь за рукоятку блока. Прогнитесь в пояснице и выпрямите свою спину по вертикали\n2)Делая выдох, потяните рукоять к поясу, максимально сокращая широчайшие мышцы. Тянуть рукоятку необходимо до того момента, пока она не коснется туловища, а локти не окажутся дальше линии корпуса. Находясь в таком положении, задержитесь на 1-2 секунды\n3)Вдыхая, медленно вернитесь в исходную позицию\n4)Повторите движение столько раз, сколько вам надо\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Тяга троса сидя.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
            {
                await botClient.SendVideoAsync(
                    chatId: chat.Id,
                    video: resourceStream!,
                    supportsStreaming: true
                    );
            }
        }
        public static async void Shrug(ITelegramBotClient botClient, Chat chat)
        {
            await botClient.SendTextMessageAsync(chat.Id, "1)Встаньте прямо с двумя гантелями\n2)Подтяните лопатки вверх\n3)Зафиксируйте положение в верхней точке на пару секунд\nДля лучшего понимания смотри видео 👇🤗");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"TgBot.videos.Пожимания плечами.mp4")!) // получить текущую строку и запустить "stream" для воспроизведения видео
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
