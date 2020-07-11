using System;

namespace FactoryMethod
{
    /// <summary>
    /// Пакет сообщения.
    /// Содержит всю необходимую информацию для отправки.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Создать новый экземпляр сообщения.
        /// </summary>
        /// <param name="text">   Текст сообщения.      </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <param name="source"> Отправитесь сообщения.</param>
        public Message(string text, string target, string source)
        {
            #region Проверяем входные аргументы на корректнось
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Текст сообщения не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Имя отправителя не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "Имя получателя не может быть пустым.");
            }
            #endregion

            //Колл-во символов сообщения в твиттере ограничено 140.
            //Всё что больше просто игнорится
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            
            Target = target;
            Source = source;
        }

        /// <summary>
        /// Текст сообщения.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Получатель сообщения.
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// Отправитесь сообщения.
        /// </summary>
        public string Source { get; }

    }
}
