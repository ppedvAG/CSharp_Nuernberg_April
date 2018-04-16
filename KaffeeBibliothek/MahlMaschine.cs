using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class MahlMaschine : KaffeeBereiter, IMahlgutBefüllbar
    {
        /// <summary>
        /// in Gramm
        /// </summary>
        public int Bohnenkapazität { get; private set; }
        public int Bohnenfüllstand { get; private set; } = 0;

        public int Füllstand
        {
            get
            {
                return Bohnenfüllstand;
            }
        }

        public MahlMaschine(string produktname, int bohnen = 500, int wasserkapazität = 1000) : base(produktname, wasserkapazität)
        {
            Bohnenkapazität = bohnen;
        }

        public void BohnenBefüllen(int menge)
        {
            if (Bohnenfüllstand + menge > Bohnenkapazität)
            {
                Bohnenfüllstand = Bohnenkapazität;
                LöseStörungsEventAus(this, "Zu viele Bohnen!");
                return;
            }
            Bohnenfüllstand += menge;
        }

        public override bool MacheKaffee(int menge)
        {
            if (Bohnenfüllstand < menge)
            {
                LöseStörungsEventAus(this, "Zu wenig Bohnen!");
                return false;
            }
            if (!base.MacheKaffee(menge))
            {
                return false;
            }

            Bohnenfüllstand -= menge;
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nBohnen: {Bohnenfüllstand}/{Bohnenkapazität} Gramm";
        }

        public int Nachfüllen(int menge)
        {
            BohnenBefüllen(menge);
            return Bohnenfüllstand;
        }
    }
}
