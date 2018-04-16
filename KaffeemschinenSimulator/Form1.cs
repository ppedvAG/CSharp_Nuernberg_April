using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaffeeBibliothek;

namespace KaffeemschinenSimulator
{
    public partial class Form1 : Form
    {
        enum Kaffeearten { Espresso, Cappuccino, Filterkaffee }

        PadMaschine espressoMaschine;
        Vollautomat cappuccinoMaschine;
        MahlMaschine filterkaffeeMaschine;
        KaffeeBereiter aktuelleMaschine;

        const int COUNTDOWN_START = 60;
        int countdown = 60;
        int score = 0;
        int gewünschteMengeFürBestellung = 0;
        Kaffeearten gewünschteKaffeeartFürBestellung;
        Random random;

        //Konstruktor
        public Form1()
        {
            InitializeComponent();

            random = new Random();
            listboxKaffeemaschine.Items.Add(Kaffeearten.Filterkaffee);
            listboxKaffeemaschine.Items.Add(Kaffeearten.Espresso);
            listboxKaffeemaschine.Items.Add(Kaffeearten.Cappuccino);

            espressoMaschine = new PadMaschine("Nespresso");
            cappuccinoMaschine = new Vollautomat("Cappu-Deluxe");
            cappuccinoMaschine.BaueMilchbehälterEin(3, 300);
            filterkaffeeMaschine = new MahlMaschine("Melitta");

            //Event-Registrierung
            espressoMaschine.Störung += StörungsBehandlung;
            cappuccinoMaschine.Störung += StörungsBehandlung;
            filterkaffeeMaschine.Störung += StörungsBehandlung;

            labelCountdown.Text = COUNTDOWN_START.ToString();

            //Erste Bestellung erstellen
            NeueBestellungErstellen();
        }

        private void NeueBestellungErstellen()
        {
            //Zufällige Kaffeeart auswählen
            gewünschteKaffeeartFürBestellung = (Kaffeearten)random.Next(3);
            //Zufällige Menge
            gewünschteMengeFürBestellung = random.Next(1, 5) * 100;
            labelBestellung.Text = $"{gewünschteMengeFürBestellung} ml {gewünschteKaffeeartFürBestellung} bitte!";
        }

        private void StörungsBehandlung(object sender, string störungsmeldung)
        {
            timerStörung.Stop();
            labelStörung.Text = $"{störungsmeldung}\nbei {((KaffeeBereiter)sender).Produktname}";
            if(score > 0)
            {
                score--;
                labelScore.Text = $"Score: {score}";
            }
            timerStörung.Start();
        }



        //Event-Handler, Ergeinisbehandlungsmethode
        private void listboxKaffeemaschine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxKaffeemaschine.SelectedItem == null)
                return;

            Kaffeearten art = (Kaffeearten)listboxKaffeemaschine.SelectedItem;
            switch (art)
            {
                case Kaffeearten.Espresso:
                    aktuelleMaschine = espressoMaschine;
                    break;
                case Kaffeearten.Cappuccino:
                    aktuelleMaschine = cappuccinoMaschine;
                    break;
                case Kaffeearten.Filterkaffee:
                    aktuelleMaschine = filterkaffeeMaschine;
                    break;
            }
            //Beschreibung der aktuellen Maschine anzeigen
            labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
        }

        private void button1Wasser_Click(object sender, EventArgs e)
        {
            if (aktuelleMaschine == null)
                return;

            int zubefüllendeMenge = 0;
            try
            {
                zubefüllendeMenge = int.Parse(textBoxWassermenge.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Bist du verrückt? Möchtest du die Küche fluten???!");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Deine eingebene Wassermenge ist keine gültige ganze Zahl!");
                return;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            //Wird sogar dann ausgeführt, wenn die Methode im Try-Catch-Block abgebrochen wird
            finally
            {
                textBoxWassermenge.Focus();
                textBoxWassermenge.SelectAll();
            }
            aktuelleMaschine.WasserFüllen(zubefüllendeMenge);
            labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
        }

        private void textBoxWassermenge_KeyUp_1(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                button1Wasser_Click(this, EventArgs.Empty);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktuelleMaschine is PadMaschine)
            {
                //as hat den gleichen Effekt wie (PadMaschine)aktuelleMaschine
                //Einziger Unterschied: Wenn das Casting fehlschlägt, stürzt
                //das Programm nicht ab, sondern es wird null zurückgegeben
                PadMaschine padmaschine = aktuelleMaschine as PadMaschine;

                if (padmaschine.PadVorhanden)
                {
                    MessageBox.Show("Da liegt schon ein Pad drin!");
                }
                else
                {
                    padmaschine.PadVorhanden = true;
                    labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
                }
            }
            else
            {
                MessageBox.Show("Das ist keine PadMaschine!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aktuelleMaschine != null && aktuelleMaschine.MacheKaffee(gewünschteMengeFürBestellung))
            {
                if(gewünschteKaffeeartFürBestellung != (Kaffeearten)listboxKaffeemaschine.SelectedItem)
                {
                    StörungsBehandlung(this, "Falsche Kaffeeart!");
                    return;
                }
                //100 ml Kaffee ergeben 1 Punkt
                score += gewünschteMengeFürBestellung / 100;
                labelScore.Text = $"Score: {score}";
                NeueBestellungErstellen();
                timerCountdown.Start();
                labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
            }
        }

        private void button4Bohnen_Click(object sender, EventArgs e)
        {

            if (!(aktuelleMaschine is IMahlgutBefüllbar))
                return;

            int zubefüllendeMenge = 0;
            try
            {
                zubefüllendeMenge = int.Parse(textBoxBohnen.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Hast du eine Kaffeeplantage überfallen??!");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Deine eingegebene Bohnenmenge ist keine gültige ganze Zahl!");
                return;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            //Wird sogar dann ausgeführt, wenn die Methode im Try-Catch-Block abgebrochen wird
            finally
            {
                textBoxBohnen.Focus();
                textBoxBohnen.SelectAll();
            }

            IMahlgutBefüllbar befüllbaresObjekt = (IMahlgutBefüllbar)aktuelleMaschine;
            befüllbaresObjekt.Nachfüllen(zubefüllendeMenge);
            labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
        }

        //Wird ausgeführt, sobald 3000 Millisekunden vergangen sind
        private void timerStörung_Tick(object sender, EventArgs e)
        {
            labelStörung.Text = string.Empty; //entspricht ""
            timerStörung.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerStörung.Stop();
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            countdown--;
            labelCountdown.Text = $"{countdown} Sekunden";
            if (countdown == 0)
            {
                timerCountdown.Stop();
                MessageBox.Show($"Game Over!\nScore: {score}!");
                Globals.FügeHighscoreHinzu(score);
                countdown = 10;
                score = 0;
                labelCountdown.Text = $"{COUNTDOWN_START} Sekunden";
                labelScore.Text = "Score: 0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 neuesFormular = new Form1();
            neuesFormular.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Globals.ZeigeHighscore();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7Milch_Click(object sender, EventArgs e)
        {
            //nur Vollautomaten können Milch befüllen
            if (!(aktuelleMaschine is Vollautomat))
                return;

            int zubefüllendeMenge = 0;
            try
            {
                zubefüllendeMenge = int.Parse(textBoxMilch.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("So viel Milch braucht kein Mensch!");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Deine eingegebene Milchmenge ist keine gültige ganze Zahl!");
                return;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            //Wird sogar dann ausgeführt, wenn die Methode im Try-Catch-Block abgebrochen wird
            finally
            {
                textBoxBohnen.Focus();
                textBoxBohnen.SelectAll();
            }

            Vollautomat vollautomat = (Vollautomat)aktuelleMaschine;
            vollautomat.BefülleMilchContainer(zubefüllendeMenge);
            labelMaschinenBeschreibung.Text = aktuelleMaschine.ToString();
        }
    }
}
