using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProjekt
{
    class Program
    {

        static void Main(string[] args)
        { 

            Person georg = new Person("Georg", Person.Geschlechter.Männlich, new DateTime(1998, 2, 2));

            Console.WriteLine($"{georg.Geburtsdatum.Year},{georg.Geburtsdatum.Month}");
            Console.WriteLine(georg.Geburtsdatum.ToShortDateString());
            Console.WriteLine(georg.Alter);

            Person anna = new Person("Anna", Person.Geschlechter.Weiblich, new DateTime(2000, 2, 2));
            Person mariechen = new Person("Mariechen", Person.Geschlechter.Weiblich, new DateTime(2010, 2, 2));

            georg.Ehepartner = georg;

            //Georg heiratet Anna
            georg.Ehepartner = anna;

            //Anna verheiratet mit Mariechen
            anna.Ehepartner = mariechen;

            Console.WriteLine(georg);
            Console.WriteLine(anna);
            Console.WriteLine(mariechen);


            Console.ReadKey();
        }

        
    }
}
