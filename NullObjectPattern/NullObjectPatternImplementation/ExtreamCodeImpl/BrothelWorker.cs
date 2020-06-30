using System;
using System.Collections.Generic;
using NullObjectPatternImplementation.ExtreamCodeImpl;

namespace NullObjectPatternImplementation
{
    /// <summary>
    /// Класс для учёта работниц борделя.
    /// </summary>
    internal sealed class BrothelWorker : IBrothelWorker
    {
        /// <summary>
        /// Здесь хранится список имён ветренных девиц.
        /// </summary>
        private readonly List<string> whores = new List<string>();

        public event Action BiginReading = () => { };
        //Этот код был да того который исп. выше:
        //public event Action BiginReading;
        //При компиляции появлялась искл. ситуация null ref. exception


        public event Action EndReading = () => { };
        //Этот код был да того который исп. выше:
        //public event Action EndReading;
        //При компиляции появлялась искл. ситуация null ref. exception

        public void ShowInfo()
        {
            //Как вариант вместо паттерна null obj - провека на null:
            //if(BiginReading != null) 
            this.BiginReading();

            foreach (string whore in this.whores)
            {
                Console.WriteLine(whore);
            }

            //Как вариант вместо паттерна null obj - провека на null:
            //if(EndReading != null)
            this.EndReading();
        }

        public void AddWhore(string whore)
        {
            this.whores.Add(whore);
        }
    }
}
