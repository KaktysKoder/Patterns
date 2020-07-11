using System;

namespace FactoryMethod
{
    internal sealed class Start
    {
        private static void Main()
        {
            Messager messager = new Messager("Rimuru", "143190304");
            messager.SendMessage("Hi!", "Rimuru", "Microsoft");

            Console.WriteLine();

            TwitterMessager twitter = new TwitterMessager("Rimuru", "143190304");
            IMessage twit = twitter.CreateMessage("Hello!", "BLIZZARD", "Rimuru");
            twit.Send();

            Console.WriteLine();

            var instargam = new InstagramMesager("Rimuru", "1431905345454304");
            var photo = instargam.CreateMessage("DeadUbisoft.jpeg", "Rimuru", "Ubisoft");
 

            Console.WriteLine();

            var telegam = new TelegramMessager("Rimuru", "1431905345454304");
            var telega = telegam.CreateMessage("Ho ho hello!", "Rimuru", "Ubisoft");
        }
    }
}
