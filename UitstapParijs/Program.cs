using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitstapParijs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStartmenu());
        }

        // Velden
        static List<String> _leerlingen = new List<string>();
        static List<Byte> _keuzeUitstap = new List<Byte>();
        static List<String> _mogelijkeUitstappen = new List<string>();



        // Functies
        /// <summary>
        /// Voeg leerlingen toe (index = -1), pas ze aan of verwijder (naam = null)ze.
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        static public void BewerkenLln(int ontvIndex, string ontvNaam)
        {
            // leerling toevoegen onder aan de lijst.
            if (ontvIndex == -1)
            {
                _leerlingen.Add(ontvNaam);
                _keuzeUitstap.Add(0);
            }
            // Verwijderen van een leerling op een specifieke index
            else if (ontvNaam == null)
            {
                _leerlingen.RemoveAt(ontvIndex);
                _keuzeUitstap.RemoveAt(ontvIndex);
            }
            // aanpassen van een leerling op een specifieke index
            else
            {
                _leerlingen[ontvIndex]= ontvNaam;

            }
        }

        /// <summary>
        /// Slaat de juiste keuze op bij de leerling 
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvKeuze"></param>
        static public void KeuzeLln(int ontvIndex, byte ontvKeuze)
        {
            _keuzeUitstap[ontvIndex] = ontvKeuze;
        }

        static public void BewerkenUitstap(int ontvIndex, string ontvUitstap)
        {
            // uitstap toevoegen onder aan de lijst.
            if (ontvIndex == -1)
            {
                _mogelijkeUitstappen.Add(ontvUitstap);
            }
            // Verwijderen van een uitstap op een specifieke index
            else if (ontvUitstap == null)
            {
                _mogelijkeUitstappen.RemoveAt(ontvIndex);
               
            }
            // aanpassen van een uitstap op een specifieke index
            else
            {
                _mogelijkeUitstappen[ontvIndex] = ontvUitstap;

            }
        }

        /// <summary>
        /// Stuurt een lijst van gegevens terug afhankelijk van de code
        /// </summary>
        /// <param name="ontvCode"></param>
        /// <returns>
        /// code 1: Alle leerlingen
        /// code 2: leerlingen per uitstap
        /// code 3: alle uitstappen
        /// </returns>
        static public String ToonLln(int ontvCode)
        {
            string antwoord = null;

            // code 1: Alle leerlingen 
            if (ontvCode == 1)
            {
                for (int i = 0; i < _leerlingen.Count(); i++)
                {
                    antwoord += _leerlingen[i] +Environment.NewLine;
                }
            }
            // Toon de leerlingen per uitstap
            else if (ontvCode == 2)
            {
                // Overloop de uitstappen
                for (int i = 0; i < _mogelijkeUitstappen.Count(); i++)
                {
                    antwoord += $"Voor uitstap: {_mogelijkeUitstappen[i]} " + Environment.NewLine;

                    // overloop de leerlingen 
                    for (int t = 0; t < _leerlingen.Count(); t++)
                    {
                        if (_keuzeUitstap[t] == i)
                        {
                            antwoord += $"   {_leerlingen[t]}" + Environment.NewLine;
                        }
                    }
                }
            }
            // toon alle uitstappen 
            else if (ontvCode == 3)
            {
                for (int i = 0; i < _mogelijkeUitstappen.Count(); i++)
                {
                    antwoord += $"{(i+1).ToString()}) {_mogelijkeUitstappen[i]} " + Environment.NewLine;

                }
            }
            // toon foutmelding 
            else
            {
                antwoord = "voor de juiste codes in:" + Environment.NewLine
                    + " code 1: Alle leerlingen" + Environment.NewLine 
                    + " code 2: leerlingen per uitstap" + Environment.NewLine 
                    + " code 3: alle uitstappen";
            }
                return antwoord;
        }

       

    }
}
