using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KaffeemschinenSimulator
{
    //interal ist der Standard-Modifier für Klassen
    public static class Globals
    {

        const string DATEI_NAME = "Highscore.hs";

        public static Dictionary<DateTime, int> Highscore = new Dictionary<DateTime, int>();

        //In diesem Dictionary könnten Daten aller Art abgespeichert werden
        public static Dictionary<object, object> SuperDictionary = new Dictionary<object, object>();

        public static void LadeHighscore()
        {
            //Prüfen ob die Datei überhaupt existiert
            if(File.Exists(DATEI_NAME))
            {
                StreamReader reader = new StreamReader(DATEI_NAME);
                string jsonString = reader.ReadToEnd();
                Highscore = JsonConvert.DeserializeObject<Dictionary<DateTime, int>>(jsonString);
                reader.Close();
            }
        }

        public static void ZeigeHighscore()
        {
            string ausgabe = "";

            //Liste nach Score sortieren und nur die ersten 10 Ergebnisse selektieren
            var geordneteListe = Highscore.OrderByDescending(datensatz => datensatz.Value).Take(10).ToList();

            foreach (var datensatz in geordneteListe)
            {
                //01.05.2018 15:20 => 4 Punkte
                ausgabe += $"{datensatz.Key.ToShortDateString()} => {datensatz.Value} Punkte\n";
            }

            MessageBox.Show(ausgabe);
        }

        public static void FügeHighscoreHinzu(int highscore)
        {
            Highscore.Add(DateTime.Now, highscore);

            //Highscore in eine Datei abspeichern
            //zweite Parameter steht dafür, ob der neue Inhalt ans Ende der Datei angefügt werden soll
            //d.h. bei false wird die Datei stattdessen komplett überschrieben

            StreamWriter writer = new StreamWriter(DATEI_NAME, false);

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;
            string jsonString = JsonConvert.SerializeObject(Highscore, settings);
            writer.Write(jsonString);
            writer.Close();

            //TODO: in XML umwandeln
            //var jsonAsXML = JsonConvert.DeserializeXNode(jsonString, "Highscore");

            //StreamWriter writerXml = new StreamWriter("Highscore.xml", false);
            //writerXml.Write(jsonAsXML.ToString());
            //writerXml.Close();
        }
    }
}
