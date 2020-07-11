using System;

namespace FactoryMethod
{
    /// <summary>
    /// Вспомогательный абстрактный класс для сообщения,
    /// который помогает сократить кол-во кода и уменьшить его дублирование.
    /// НАследовать именно его не обязательно - есть интерфейсы IMessage
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        protected MessageBase(string text, string source, string target)
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

            Text    = text;
            Source = source;
            Target = target;
        }

        public string Text { get; protected set; }

        public string Target { get; }

        public string Source { get; }


        public abstract void Send();
    }
}
