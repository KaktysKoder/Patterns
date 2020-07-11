using System;
using System.IO;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Instagram.  
    /// Принимает сообщение в виде картинок
    /// </summary>
    public class InstagramMessage : MessageBase
    {
        /// <summary>
        /// Создать номый экземпляр месседжера Instagram
        /// </summary>
        public InstagramMessage(string text, string source, string target)
            : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imagebyts = File.ReadAllBytes(text);
                var base64string = Convert.ToBase64String(imagebyts);
                Text = base64string;
            }
        }

        /// <summary>
        /// Отправить сообщение Instagram.
        /// </summary>
        public override void Send()
        {
            Console.WriteLine($"Instagram photo {Source} для @{Target}: {Text}");
        }
    }
}
