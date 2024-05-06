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
    public partial class FrmLlnToevoegen : Form
    {
        public FrmLlnToevoegen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Check of er iets ingevuld is 
            if(txtNaamLeerling.Text != "")
            {
                // stuur de naam door naar de functie
                string naam = txtNaamLeerling.Text;

                Program.BewerkenLln(-1,naam);

                // stuur bevestiging 
                MessageBox.Show("Deze leerling werd toegevoegd", "Great Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset Form
                txtNaamLeerling.Text = "";
                txtNaamLeerling.Focus();

            }
            else
            {
                // foutmelding 
                MessageBox.Show("U heeft niets ingevuld", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
