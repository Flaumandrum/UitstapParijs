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
    public partial class FrmLlnAanpassen : Form
    {
        public FrmLlnAanpassen()
        {
            InitializeComponent();
        }

        


        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLlnAanpassen_Load(object sender, EventArgs e)
        {
            // vul de combobox
            VulCmb();
        }

        private void VulCmb()
        {
            // Haal de lijst op met de namen van de leerlingen 
            List<string> ontvLijst = Program.stuurLlnDoor();

            // Maak de combobox leeg
            cmbKies.Items.Clear();

            // Vul de combobox met de nieuwe items
            foreach(string s in ontvLijst)
            {
                cmbKies.Items.Add(s);
            }
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Check of er een leerling is gekozen 
            if (cmbKies.SelectedIndex != -1 && txtNaamLeerling.Text !=  "")
            {
                // neem index + nieuwe naam van de leerling om aan te passen  
                int index = cmbKies.SelectedIndex;
                string naam = txtNaamLeerling.Text;

                // verwijder de leerling
                Program.BewerkenLln(index, naam);

                // Bevestingen 
                MessageBox.Show("Deze leerling werd aangepast", "Great Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset Form
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";
                VulCmb();
                txtNaamLeerling.Text = "";
            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niets ingevuld", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKies_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNaamLeerling.Text = cmbKies.Text;
        }
    }
}
