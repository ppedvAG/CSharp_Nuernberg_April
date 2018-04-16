using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProjekt
{
    public class Person
    {
        public enum Geschlechter { Männlich, Weiblich }


        public string Name { get; set; }
        public int Alter
        {
            get
            {
                //Alter berechnen
                TimeSpan span = DateTime.Now - Geburtsdatum;
                int year = span.Days / 365;
                return year;
            }
        }

        private Person _ehepartner;
        public Person Ehepartner
        {
            get
            {
                return _ehepartner;
            }
            set
            {

                //Scheidung prüfen
                if(value == null)
                {
                    if(this._ehepartner != null)
                    {
                        value._ehepartner = null;
                    }
                    _ehepartner = null;
                    return;
                }

                //Stand 2016: Volljährigkeit, keine Ich-Ehe, Nicht Gleichgeschlechtlich, Unverheiratet
                if(this.Alter < 18 || value.Alter < 18)
                {
                    Console.WriteLine("Personen sind nicht beide volljährig!");
                    return;
                }
                if (this == value)
                {
                    Console.WriteLine("Person darf sich nicht selbst heiraten!");
                    return;
                }
                if (this.Geschlecht == value.Geschlecht)
                {
                    Console.WriteLine("Homo-Ehe (noch) verboten!");
                    return;
                }
                
                if(this.Ehepartner != null || value.Ehepartner != null )
                {
                    Console.WriteLine("Viel-Ehe!!");
                    return;
                }

                _ehepartner = value;
                value._ehepartner = this;

            }
        }

        public Geschlechter Geschlecht { get; private set; }
        //darf nur 1 Mal gesetzt werden
        public DateTime Geburtsdatum { get; private set; }

        //public string Password { private get; set; }

        public Person(string name, Geschlechter geschlecht, DateTime geburtsdatum)
        {
            Name = name;
            Geschlecht = geschlecht;
            Geburtsdatum = geburtsdatum;
        }

        public override string ToString()
        {
            string ehestand = "ledig";
            if(Ehepartner != null)
            {
                ehestand = $" verheiratet mit {Ehepartner?.Name}";
            }
            return $"{Name}, {Geschlecht} ({Alter}) {ehestand}";
        }
    }
}
