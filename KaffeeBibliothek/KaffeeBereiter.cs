using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public abstract class Maschine
    {
        public int Preis { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}, Preis: {Preis}";
        }

        //abstrakte Methoden geben die Signatur vor, die Implementierung
        //muss in den abgeleiteten Klassen erfolgen
        public abstract void MachWas(); 
    }


    public class KaffeeBereiter : Maschine
    {

        //Events
        public delegate void StörungsEventDelegate(object sender, string störungsmeldung);

        //Am Anfang zeigt die Variable auf keine Methode, da sich noch niemand dafür registriert hat
        public event StörungsEventDelegate Störung = null;

        protected void LöseStörungsEventAus(object sender, string störungsmeldung)
        {
            Störung?.Invoke(sender, störungsmeldung);
        }

        //Properties

        /// <summary>
        /// in Millilitern
        /// </summary>
        public int Wasserkapazität { get; private set; }

        //Snippet: propfull 
        private int _wasserstand;
        public int Wasserstand
        {
            get { return _wasserstand; }
            set
            {
                if(value > Wasserkapazität || value < 0)
                {
                    //TODO: Durch Exception oder Event ersetzen!
                    Störung?.Invoke(this, "Wasser läuft über!");
                    _wasserstand = Wasserkapazität;
                    return;
                }
                _wasserstand = value;
            }
        }

        public string Produktname { get; private set; }
        
        //Konstruktor
        public KaffeeBereiter(string produktname, int wasserkapazität = 1000)
        {
            Wasserkapazität = wasserkapazität;
            Produktname = produktname;
            Wasserstand = 0;
        }

        //Sonstige Methoden
        public void WasserFüllen(int menge)
        {
            Wasserstand = Wasserstand + menge;
        }

        //virtual: Kinderklassen dürfen diese Methode überschreiben (neu definieren)
        public virtual bool MacheKaffee(int menge)
        {
            if(Wasserstand < menge)
            {
                //Event
                if(Störung != null)
                {
                    Störung(this, "Nicht genügend Wasser vorhanden!");
                }
                //Kurzversion
                //Störung?.Invoke(this, "Nicht genügend Wasser vorhanden!");
                
                return false;
            }
            Wasserstand -= menge;
            return true;
        }

        public override void MachWas()
        {
            MacheKaffee(500);
        }

        public override string ToString()
        {
            return $"{Produktname}\n\nWasserstand: {Wasserstand}/{Wasserkapazität} ml";
        }
    }
}
