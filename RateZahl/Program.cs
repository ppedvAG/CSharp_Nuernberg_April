using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int zufallszahl = random.Next(1, 11);

            int gerateneZahl = -1;

            Console.WriteLine("Rate Zahl zwischen 1 und 11");
            while (gerateneZahl != zufallszahl)
            {
                gerateneZahl = int.Parse(Console.ReadLine());

                if (gerateneZahl > zufallszahl)
                {
                    Console.WriteLine("Zu groß!");
                }
                else if (gerateneZahl < zufallszahl)
                {
                    Console.WriteLine("Zu klein!");
                }
            }

            Console.WriteLine("Richtig geraten!");

            Console.ReadKey();
        }
    }
}
