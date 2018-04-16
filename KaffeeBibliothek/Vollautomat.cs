using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class Vollautomat : MahlMaschine
    {
        public List<Milchbehälter> Milchcontainer { get; set; }

        public Vollautomat(string produktname, int bohnen = 500, int wasserkapazität = 1000) : base(produktname, bohnen, wasserkapazität)
        {
            Milchcontainer = new List<Milchbehälter>();
        }

        public void BaueMilchbehälterEin(int anzahl, int kapazität = Milchbehälter.Standardkapazität)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Milchcontainer.Add(new Milchbehälter(kapazität));
            }
        }

        public void BefülleMilchContainer(int menge)
        {
            //Prüfen ob es reinpassen würde
            int restkapazität = 0;
            bool platzreicht = false;
            foreach (var milchbehälter in Milchcontainer)
            {
                //item steht für das aktuelle Objekt innerhalb der Liste, welches gerade durchlaufen wird
                restkapazität = restkapazität + (milchbehälter.Kapazität - milchbehälter.Milchfüllstand);
                if (restkapazität >= menge)
                {
                    platzreicht = true;
                    break;
                }
            }
            if(!platzreicht)
            {
                LöseStörungsEventAus(this, "Zu viel Milch!");
                //TODO: Event       
            }
            else
            {
                int restmenge = menge;
                //Behälter tatsächlich befüllen
                foreach (var milchbehälter in Milchcontainer)
                {
                    //Ermittle zunächst wieviel in den jeweiligen Container eingefüllt werden muss
                    //Je nachdem wieviel Milch noch eingefüllt werden muss, 
                    int restkapazitätImBehälter = milchbehälter.Kapazität - milchbehälter.Milchfüllstand;
                    int einfüllmenge = Math.Min(restkapazitätImBehälter, restmenge);
                    milchbehälter.BefülleMilch(einfüllmenge);
                    restmenge -= einfüllmenge;
                    if(restmenge <= 0)
                    {
                        break;
                    }
                }
            }
        }



        public override bool MacheKaffee(int menge)
        {
            //Prüfe ob genug Milch vorhanden ist
            int vorhandeneMilch = 0;
            int benötigteMilch = menge;
            foreach (var behälter in Milchcontainer)
            {
                vorhandeneMilch += behälter.Milchfüllstand;
            }
            if(vorhandeneMilch < benötigteMilch)
            {
                LöseStörungsEventAus(this, "Zu wenig Milch!");
                return false;
            }


            if(Milchcontainer.Count == 0)
            {
                return false;
            }
            if (!base.MacheKaffee(menge))
            {
                return false;
            }

            //Milch abnehmen
            foreach (var milchbehälter in Milchcontainer)
            {
                int zuEntnehmendeMilch = Math.Min(benötigteMilch, milchbehälter.Milchfüllstand);
                milchbehälter.EntnehmeMilch(zuEntnehmendeMilch);
                benötigteMilch -= zuEntnehmendeMilch;
                if(benötigteMilch < 0)
                {
                    break;
                }
            }

            return true;
        }

        public override string ToString()
        {
            string containerstring = "\n";
            for (int i = 0; i < Milchcontainer.Count; i++)
            {
                containerstring += $"{i+1}.{Milchcontainer[i].ToString()}\n";
            }
            return base.ToString() + containerstring;
        }
    }

    //Da diese Klasse vor allem vom Vollautomat benutzt wird
    //schreiben wir sie direkt mit in die gleiche Datei.
    //Sie ist aber trotzdem von überall im Projekt aus nutzbar.
    public class Milchbehälter
    {

        public const int Standardkapazität = 1000;

        /// <summary>
        /// in Milliliter
        /// </summary>
        public int Kapazität { get; private set; }
        public int Milchfüllstand { get; private set; } = 0;

        public Milchbehälter(int kapazität = Standardkapazität)
        {
            Kapazität = kapazität;
        }

        public void BefülleMilch(int menge)
        {
            if (Milchfüllstand + menge > Kapazität)
            {
                Milchfüllstand = Kapazität;
                return;
            }
            Milchfüllstand += menge;
        }

        public void EntnehmeMilch(int menge)
        {
            if(Milchfüllstand - menge < 0)
            {
                Console.WriteLine("Zu wenig Milch!");
                return;
            }
            Milchfüllstand -= menge;
        }

        public override string ToString()
        {
            return $"Milchbehälter: {Milchfüllstand}/{Kapazität}";
        }
    }
}
