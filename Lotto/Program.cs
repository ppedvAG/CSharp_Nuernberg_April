using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{

    class Program
    {

        static void Main(string[] args)
        {
            const int WERTEBEREICH = 49;
            const int ANZAHL_ZAHLEN = 6;

            while (true)
            {
                Random random = new Random();

                //Arrays müssen immer eine feste Größe haben, darf nachträglich nicht
                //verändert werden
                int[] gezogeneZahlen = new int[] { -1, -1, -1, -1, -1, -1 };
                int[] getippteZahlen = new int[ANZAHL_ZAHLEN];


                Console.WriteLine($"Bitte geben Sie {ANZAHL_ZAHLEN} Zahlen zwischen 1 und {WERTEBEREICH} ein!");
                //Zahlen einlesen, die der Nutzer tippt
                for (int i = 0; i < getippteZahlen.Length; i++)
                {
                    Console.Write($"{i + 1}. Zahl: ");
                    getippteZahlen[i] = int.Parse(Console.ReadLine());
                }

                //Zufällige Gewinnzahlen generieren
                for (int i = 0; i < gezogeneZahlen.Length; i++)
                {
                    int neueZahl;
                    //Erst wenn die neu gerierte Zahl noch nicht
                    //im Array enthalten ist, diese zum Array hinzufügen
                    do
                    {
                        neueZahl = random.Next(1, WERTEBEREICH+1);
                    } while (gezogeneZahlen.Contains(neueZahl));
                    gezogeneZahlen[i] = neueZahl; 
                    Console.WriteLine(gezogeneZahlen[i]);
                }
                
                //Auswertung
                int treffer = 0;
                for (int i = 0; i < gezogeneZahlen.Length; i++)
                {
                    if (getippteZahlen.Contains(gezogeneZahlen[i]))
                    {
                        treffer++;
                    }
                }
                
                Console.WriteLine($"Du hattest {treffer} Treffer");

                Console.WriteLine("Möchten Sie ein weiteres Spiel spielen? y/n");
                ConsoleKeyInfo gerückteTaste =  Console.ReadKey();
                Console.WriteLine();
                if(gerückteTaste.Key == ConsoleKey.N)
                {
                    break;
                }
            }
        }
    }
}
