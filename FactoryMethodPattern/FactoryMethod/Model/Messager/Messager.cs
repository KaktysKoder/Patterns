using System;

namespace FactoryMethod
{
    /// <summary>
    /// Класс эмулирующий работу с Твиттером
    /// Позволяет авторизоваться и отправлять сообщения
    /// </summary>
    public class Messager
    {
        /// <summary>
        /// Создать номый экземпляр месседжера Твиттер
        /// </summary>
        /// <param name="userName">Имя пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        public Messager(string userName, string password)
        {
            //Не забываем проверять входные поля перед авторизацией 
            if (!(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password)))
            {

                UserName = userName;
                Password = password;
                Connect = ConnecttoTwitter();
            }
            else Connect = false;
        }

        /// <summary>
        /// Отправить сообщение пользователю
        /// </summary>
        /// <param name="text">    Текст сообщения.      </param>
        /// <param name="source">  Отправитесь сообщения.</param>
        /// <param name="target">  Получатель сообщения. </param>
        public void SendMessage(string text, string source, string target)
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

            if (text.Length > 140)
            {
                throw new ArgumentNullException("Текст сообщения не может быть больше 10 символов.", nameof(text));
            }
            #endregion

            var message = new Message(text, source, target);
            SendMessageToTwitter(message);
        }

        /// <summary>
        /// Отправить сообщение в Твиттер.
        /// </summary>
        /// <param name="message">Отправляемое сообщение true - авторизовано false - отказано</param>
        private void SendMessageToTwitter(Message message)
        {
            //TODO: Обращение к API Twittera для отправки сообщения
            //Здесь должен быть код для обращения к серверам Twitter

            //Нижe упращённая версия просто для наглядности

            Console.WriteLine($"Twitter: {message.Text}");
        }

        /// <summary>
        /// Авторизация пользователя в Твиттере
        /// </summary>
        /// <returns></returns>
        private bool ConnecttoTwitter()
        {
            //TODO: Обращение к API Twittera для автроризации
            //Здесь должен быть код для обращения к серверам Twitter

            //Нижe упращённая версия просто для наглядности

            Console.WriteLine($"Авторизация в Твиттере пользователя с именем: {UserName} и паролем: {Password}");

            return true;
        }

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
    }
}
