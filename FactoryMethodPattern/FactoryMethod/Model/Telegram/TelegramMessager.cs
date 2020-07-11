using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация мессенджара Telegram.
    /// </summary>
    public class TelegramMessager : MessagerBase
    {
        public TelegramMessager(string userName, string password)
            : base(userName, password)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Telegram пользователя с именем: {UserName} и паролем: {Password}");

            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TelegramMessage(text, source, target);

            return message;
        }
    }
}
