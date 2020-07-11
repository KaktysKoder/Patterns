using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Telegram.  
    /// </summary>
    public class TelegramMessage : MessageBase
    {
        /// <summary>
        /// Создать номый экземпляр месседжера Telegram
        /// </summary>
        public TelegramMessage(string text, string source, string target)
            : base(text, source, target)
        {

        }

        /// <summary>
        /// Отправить сообщение Telegram.
        /// </summary>
        public override void Send()
        {
            Console.WriteLine($"Telegram текст  от @{Source} для @{Target}: {Text}");
        }
    }
}
