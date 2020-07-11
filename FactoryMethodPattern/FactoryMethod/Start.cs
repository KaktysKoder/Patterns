using System;

namespace FactoryMethod
{
    internal sealed class Start
    {
        private static void Main()
        {
            Messager messager = new Messager("Rimuru", "143190304");

            messager.SendMessage("H!", "Rimuru", "Microsoft");
        }
    }
}
