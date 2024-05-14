using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitstapParijs
{
    public partial class FrmKeuzeAanpassen : Form
    {
        public FrmKeuzeAanpassen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmKeuzeAanpassen_Load(object sender, EventArgs e)
        {
            VulCmbKeuze();
            VulCmbLln();
        }

        private void VulCmbLln()
        {
            // Haal de lijst op met de namen van de leerlingen 
            List<string> ontvLijst = Program.stuurLlnDoor();

            // Maak de combobox leeg
            cmbKies.Items.Clear();

            // Vul de combobox met de nieuwe items
            foreach (string s in ontvLijst)
            {
                cmbKies.Items.Add(s);
            }
        }

        private void VulCmbKeuze()
        {
            // Haal de lijst op met de namen van de leerlingen 
            List<string> ontvLijst = Program.stuurMogelijkeUitstappenDoor();

            // Maak de combobox leeg
            cmbKiesKeuze.Items.Clear();

            // Vul de combobox met de nieuwe items
            foreach (string s in ontvLijst)
            {
                cmbKiesKeuze.Items.Add(s);
            }
        }

        private void btnKeuzeAanpassen_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1 && cmbKiesKeuze.SelectedIndex != -1)
            {
                // neem de keuze van de gebruiker 
                int indexLLn = cmbKies.SelectedIndex;
                byte indexUitstap = Convert.ToByte(cmbKiesKeuze.SelectedIndex);

                // stuur door naar de business
                Program.KeuzeLln(indexLLn, indexUitstap);


                // foutmelding 
                MessageBox.Show("Deze keuze is aangepast aan de leerling", "Aangepast", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // form resetten 
                cmbKies.SelectedIndex = -1;
                cmbKiesKeuze.SelectedIndex = -1;
                cmbKies.Text = "";
                cmbKiesKeuze.Text = "";
                VulCmbLln();
                VulCmbKeuze();


            }
        }
    }
}
