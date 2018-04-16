using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        //man kann als Index für die Enumerator-Werte auch Chars verwenden, da diese intern ebenfalls
        //als Zahl abgespeichert werden (ASCII)
        enum Operatoren { Addition = '+', Subtraktion = '-', Multiplikation = '*', Division = '/' }

        static void Main(string[] args)
        {

            double ergebnis = 5;
            if(CalculateMitPrüfung(5, 0, Operatoren.Division, out ergebnis))
            {
                Console.WriteLine("Ergebnis: " + ergebnis);
            }
            else
            {
                Console.WriteLine("Fehler!");
            }


            double zahl1, zahl2;
            Operatoren rechenoperation;

            do
            {
                Console.Write("\nZahl1: ");
                zahl1 = double.Parse(Console.ReadLine());
                Console.Write("Zahl2: ");
                zahl2 = double.Parse(Console.ReadLine());

                Console.WriteLine("+: Addition");
                Console.WriteLine("-: Subtraktion");
                Console.WriteLine("*: Multiplikation");
                Console.WriteLine("/: Division");
                Console.Write("Geben Sie eine Rechenoperation ein: ");

                rechenoperation = (Operatoren)Console.ReadKey().KeyChar;
            } while (!CalculateMitPrüfung(zahl1, zahl2, rechenoperation, out ergebnis));

           
            Console.WriteLine($"\nErgebnis: {ergebnis}");


            int index;
            int erg;

            while (!int.TryParse(Console.ReadLine(), out erg))
            {
                Console.WriteLine("Bitte gebe eine korrekte Zahl ein: ");
            }
            index = erg;

            Console.WriteLine(erg);

            Console.ReadKey();
        }


        static double Calculate(double zahl1, double zahl2, Operatoren op)
        {
            switch (op)
            {
                case Operatoren.Addition:
                    return zahl1 + zahl2;
                case Operatoren.Subtraktion:
                    return zahl1 - zahl2;
                case Operatoren.Multiplikation:
                    return zahl1 * zahl2;
                case Operatoren.Division:
                    return zahl1 / zahl2;
                default:
                    return 0;
            }
        }


        static bool CalculateMitPrüfung(double zahl1, double zahl2, Operatoren op, out double erg)
        {
            erg = 4;

            switch (op)
            {
                case Operatoren.Addition:
                    erg = zahl1 + zahl2;
                    break;
                case Operatoren.Subtraktion:
                    erg = zahl1 - zahl2;
                    break;
                case Operatoren.Multiplikation:
                    erg = zahl1 * zahl2;
                    break;
                case Operatoren.Division:
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("\nDivision durch Null verboten!");
                        return false;
                    }
                    erg = zahl1 / zahl2;
                    break;
                default:
                    return false;
            }
            return true;
        }


    }
}
