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
    public partial class FrmKeuzeToevoegen : Form
    {
        public FrmKeuzeToevoegen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKeuzeToevoegen_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1 && cmbKiesKeuze.SelectedIndex != -1)
            {
                // neem de keuze van de gebruiker 
                int indexLLn = cmbKies.SelectedIndex;
                byte indexUitstap = Convert.ToByte(cmbKiesKeuze.SelectedIndex);

                // Vraag de lijst met de keuzes van de leerlingen op
                List<byte> keuzes = Program.stuurKeuzeLlnDoor();

                if (keuzes[indexLLn] == 0)
                {
                    // stuur door naar de business
                    Program.KeuzeLln(indexLLn, indexUitstap);


                    // foutmelding 
                    MessageBox.Show("Deze keuze werd toegevoegd aan de leerling", "Toegevoegd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // form resetten 
                    cmbKies.SelectedIndex = -1;
                    cmbKiesKeuze.SelectedIndex = -1;
                    cmbKies.Text = "";
                    cmbKiesKeuze.Text = "";
                    VulCmbLln();
                    VulCmbKeuze();
                }
                else
                {
                    // foutmelding 
                    MessageBox.Show("Deze leerling heeft reeds een keuze", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niet alle gegevens geselecteerd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void FrmKeuzeToevoegen_Load(object sender, EventArgs e)
        {
            VulCmbKeuze();
            VulCmbLln();
        }
    }
}
