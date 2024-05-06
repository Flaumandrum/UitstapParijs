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
