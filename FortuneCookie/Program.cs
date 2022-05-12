using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cookies = { "Win a Jackpot", "Fall in love", "Get a love letter", "Miss the bus", "See a unicorn un the street" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, cookies.Length);


            Console.WriteLine($"Here is your prediction: {cookies[randomIndex]}!");
        }
    }
}
