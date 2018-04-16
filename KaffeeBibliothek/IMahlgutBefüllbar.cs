using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public interface IMahlgutBefüllbar
    {
        /// <summary>
        /// In ein Behälter etwas einfüllen
        /// </summary>
        /// <param name="menge">Die Menge des zu Befüllenden Mahlguts</param>
        /// <returns>Der Füllstand nach der Befüllung</returns>
        int Nachfüllen(int menge);

        int Füllstand { get; }
    }
}
