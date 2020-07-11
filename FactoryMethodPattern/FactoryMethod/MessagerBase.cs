using System;

namespace FactoryMethod
/// <summary>
/// Вспомогательный абстрактный класс для муссенджера,
/// который помогает сократить кол-во кода и уменьшить его дублирование.
/// Наследовать именно его не обязательно - есть интерфейсы IMessager
/// </summary>
{
    public abstract class MessagerBase : IMessager
    {
        /// <summary>
        /// Создать номый экземпляр месседжера Твиттер
        /// </summary>
        /// <param name="userName">Имя пользователя.   </param>
        /// <param name="password">Пароль пользователя.</param>
        protected MessagerBase(string userName, string password)
        {
            //Не забываем проверять входные поля перед авторизацией 
            if (!(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password)))
            {

                UserName = userName;
                Password = password;
                Connect = Authorize();
            }
            else Connect = false;
        }

        public string UserName { get; }

        public string Password { get; }

        public bool Connect { get; }

        /// <summary>
        /// Выполнить авторизацию в мессенджере
        /// </summary>
        /// <returns></returns>
        public abstract bool Authorize();

        /// <summary>
        /// Создать сообщение готовое для отправки.
        /// Это фабричный метод
        /// </summary>
        /// <param name="text"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
