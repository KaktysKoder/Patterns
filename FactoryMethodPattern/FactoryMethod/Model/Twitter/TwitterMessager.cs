using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация мессенджара Твиттера.
    /// </summary>
    public class TwitterMessager : MessagerBase
    {
        public TwitterMessager(string userName, string password)
            : base(userName, password)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Твиттере пользователя с именем: {UserName} и паролем: {Password}");

            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TwitterMessage(text, source, target);

            return message;
        }
    }
}
