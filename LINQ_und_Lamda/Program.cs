using PersonProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_und_Lamda
{
    class Program
    {
        public delegate void DelegateTyp(int param1, int param2, ref int ergebnis);
        public delegate int DelegateMitIntRückgabe(int x);
        public delegate int DelegateMitIntRückgabeOhneParameter();


        public static DateTime Geburtsdatum = new DateTime(2000, 1, 1);

        //public static int Property { get { return DateTime.Now.Year - Geburtsdatum.Year; } }
        public static int Property => DateTime.Now.Year - Geburtsdatum.Year;


        static void Main(string[] args)
        {
            int ergebnis = 0;

            DelegateTyp delegateVariable = Addiere;

            //=> steht für Lamda-Ausdruck, Lamda-Ausdruck beschreibt eine anonyme Methode
            delegateVariable += (int x, int y, ref int erg) =>
            {
                erg +=  x * y;
            };

            DelegateMitIntRückgabe delegateVariableMitRückgabe = x => 2 * x;

            DelegateMitIntRückgabeOhneParameter delegateVariableOhneParameter = () => 5;
            Console.WriteLine(delegateVariableOhneParameter());

            Console.WriteLine(delegateVariableMitRückgabe(10));


            Action<int, int, string> generischeVariable = (x, y, wort) =>
            {
                int z = x + y;
                Console.WriteLine(wort + $" {z}");
            };

            generischeVariable(5, 5, "5 + 5 =");

            Func<int, int, double> funcVariable = (x, y) => (double)x / y;

            Console.WriteLine(funcVariable(3, 5));

            delegateVariable(2, 5, ref ergebnis);
            Console.WriteLine(ergebnis);

            List<Person> Personenliste = new List<Person>()
            {
                new Person("Alex", Person.Geschlechter.Männlich, new DateTime(2000, 2, 2)),
                new Person("Maria", Person.Geschlechter.Weiblich, new DateTime(1980, 2, 2)),
                new Person("Alex2", Person.Geschlechter.Männlich, new DateTime(2015, 2, 2)),
                new Person("Alex3", Person.Geschlechter.Männlich, new DateTime(2018, 2, 2)),
                new Person("Alex4", Person.Geschlechter.Männlich, new DateTime(1920, 2, 2)),
                new Person("Alex5", Person.Geschlechter.Männlich, new DateTime(1850, 2, 2)),
            };

            Console.WriteLine();
            List<Person> sortierteListe =  Personenliste.OrderBy((Person p) => { return p.Geburtsdatum; }).ToList();

            Console.WriteLine("Aufsteigend nach Geburtsdatum");
            sortierteListe.ForEach(p => { Console.WriteLine(p.Name); });

            Console.WriteLine("Absteigend nach Namen");
            Personenliste.OrderByDescending(p => p.Name).ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine("Filtere nach Frauen");
            Personenliste.Where(p => p.Geschlecht == Person.Geschlechter.Weiblich).ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.ReadKey();
        }

        private static void Addiere(int x, int y, ref int erg)
        {
            erg += x + y;
        }
    }
}
