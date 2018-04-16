using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ohne Using-Anweisungen muss man den vollständigen Namespace-Pfad,
            //zu der eine Klasse gehört, immer dazuschreiben
            System.Console.Write("Hello World!\n");
            Console.WriteLine("Bitte geben Sie Ihren Namen ein: ");

            string name = Console.ReadLine();
            
            Console.Write("Alter: ");
            int alter = int.Parse(Console.ReadLine());

            int alter2 = 10;

            Console.Write("Größe: ");
            double größe = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n{name} ist {alter} Jahre alt und {größe:00.00} Meter groß!");
            //Erwartete Ausgabe: Durchschnitt von 20 und 10 ergibt 15
            double durchschnittsalter = (alter + alter2) / (double)2;
            Console.WriteLine($"Durchschnittsalter von {alter2} und {alter}: {durchschnittsalter}");

            //Snippets anzeigen: Strg+Leertaste
            //Console.WriteLine: cw + Tab + Tab
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}