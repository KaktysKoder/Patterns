using System;
using System.Threading;

namespace NullObjectPatternImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            BrothelWorkerTest();
        }

        private static void BrothelWorkerTest()
        {
            BrothelWorker VIPBrothel = new BrothelWorker();

            VIPBrothel.AddWhore("ExtremeCode");
            VIPBrothel.AddWhore("Ларри Уол");
            VIPBrothel.AddWhore("ExtremeCode");
            VIPBrothel.AddWhore("Деннис Ритчи");
            VIPBrothel.AddWhore("ExtremeCode");
            VIPBrothel.AddWhore("Гвидо ван Россум");
            VIPBrothel.AddWhore("ExtremeCode");
            VIPBrothel.AddWhore("Билл Джой");
            VIPBrothel.AddWhore("ExtremeCode");
            
            VIPBrothel.ShowInfo();

            Console.Write("\nМатериал для обучения был позаимствован ");
            Console.WriteLine("с канала: https://youtu.be/ocozoCVox-c?list=LLoGXO_oQIAt7dwehic8WEvw");

            VeryVell();
        }

        private static void VeryVell()
        {
            Thread.Sleep(5000);
            Console.Clear();
            throw new StackOverflowException();
        }
    }
}
