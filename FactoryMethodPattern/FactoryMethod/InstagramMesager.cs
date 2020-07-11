using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация мессенджара Instagram.
    /// </summary>
    public class InstagramMesager : MessagerBase
    {
        public InstagramMesager(string userName, string password)
            : base(userName, password)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Instagram пользователя с именем: {UserName} и паролем: {Password}");

            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TwitterMessage(text, source, target);

            return message;
        }
    }
}
