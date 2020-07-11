using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Твиттера.  
    /// Принимает сообщение 140 символов
    /// </summary>
    public class TwitterMessage : MessageBase
    {
        /// <summary>
        /// Создать номый экземпляр месседжера Твиттера
        /// </summary>
        public TwitterMessage(string text, string source, string target)
            : base(text, source, target)
        {
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
        }

        /// <summary>
        /// Отправить сообщение твиттера.
        /// </summary>
        public override void Send()
        {
            Console.WriteLine($"Твит от @{Source} для @{Target}: {Text}");
        }
    }
}
