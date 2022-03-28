using System;
using System.Threading;
//magazin de produse electronice
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment purchase2 = Payment.GetInstance(123456);
            Console.WriteLine("Id-ul procesului inceput:");
            Console.WriteLine(purchase2.Id);

            (new Thread(() =>
            {
                Payment purchase1 = Payment.GetInstance(654321);
                Console.WriteLine("Id-ul procesului inceput dintr-un thread nou");
                Console.WriteLine(purchase1.Id);
            })).Start();
            Console.ReadLine();
        }
    }
}
