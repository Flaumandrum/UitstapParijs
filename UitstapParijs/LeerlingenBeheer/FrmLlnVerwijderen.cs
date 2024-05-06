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
    public partial class FrmLlnVerwijderen : Form
    {
        public FrmLlnVerwijderen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void VulCmb()
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

        private void FrmLlnVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            // Check of er een leerling is gekozen 
            if(cmbKies.SelectedIndex != -1) 
            {
                // neem index van de leerling om te verwijderen 
                int index = cmbKies.SelectedIndex;

                // verwijder de leerling
                Program.BewerkenLln(index, null);

                // Bevestingen 
                MessageBox.Show("Deze leerling werd verwijderd", "Great Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset Form
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";

                VulCmb();
            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niets ingevuld", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        
    }
}
