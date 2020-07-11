namespace FactoryMethod
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовать любой тип сообщений месседжера.
    /// Для того, что бы добавить новый тип сообщения месседжера
    /// необходимо реализовать пару интерфейсов: 
    /// (IMessage - (этот) для типа сообщения.)
    /// (IMessager - для подключения к API мессенджара)
    /// </summary>
    public interface IMessage
    {
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

        void Send();
    }
}
