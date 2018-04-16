using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class PadMaschine : KaffeeBereiter
    {
        //Properties
        public bool PadVorhanden { get; set; } = false;

        public PadMaschine(string produktname, int wasserkapazität = 500) : base(produktname, wasserkapazität)
        {
            
        }

        public override bool MacheKaffee(int menge)
        {
            if (!PadVorhanden)
            {
                //Event
                LöseStörungsEventAus(this, "Kein Pad vorhanden!");
                return false;
            }
            if (!base.MacheKaffee(menge))
            {
                return false;
            }
            
            PadVorhanden = false;
            return true;
        }

        public override string ToString()
        {
            string padString = "kein Pad!";
            if(PadVorhanden)
            {
                padString = "Pad vorhanden";
            }
            return $"{base.ToString()}\n{padString}";
        }
    }
}
