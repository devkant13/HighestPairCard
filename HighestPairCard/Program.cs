using System;

namespace HighestPairCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] inp = { "A", "A", "Q", "Q", "6" };

            string[] inp2 = { "K", "7", "3", "9", "3" };
            IHighestCard obj = new HighestCard();
            var   output = obj.highestPair(inp);
            //Test project created to test the Functionalities.
            Console.ReadLine();
        }
    }
}
