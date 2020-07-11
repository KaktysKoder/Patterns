namespace FactoryMethod
{
    /// <summary>
    /// Базовый интерфейс который должен реализовать любой месанджер.
    /// Для того что бы добавить новый мессееджер необхадимо реализовать два интерфейа:
    /// IMessager - для месседжера и IMessager для сообщения этого месседжера.
    /// </summary>
    public interface IMessager
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Пароль пользователя.
        /// P.S Никогда не храните пароли пользователя в открытом виде.
        /// Используйте алгоритм хеширование и сравнивайте хэши.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Успешность подключения и авторизация
        /// </summary>
        public bool Connect { get; }

        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }

}
