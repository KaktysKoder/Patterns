using System;

namespace NullObjectPatternImplementation.ExtreamCodeImpl
{
    internal interface IBrothelWorker
    {
        /// <summary>
        /// Событие возникающее перед выводом информации на консоль.
        /// </summary>
        event Action BiginReading;

        /// <summary>
        /// Событие, возникающие, когда вся информация вывелась на консоль.
        /// </summary>
        event Action EndReading;

        /// <summary>
        /// Выводит построчно список имён ночных бабочек.
        /// </summary>
        void ShowInfo();

        /// <summary>
        /// Добавляет имя ночной бабочки в список.
        /// </summary>
        /// <param name="whore">Имя</param>
        void AddWhore(string whore);
    }
}
