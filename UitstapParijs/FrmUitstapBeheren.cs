using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace UitstapParijs
{
    public partial class FrmUitstapBeheren : Form
    {
        public FrmUitstapBeheren()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void FrmUitstapBeheren_Load(object sender, EventArgs e)
        {
            string ontvActie = FrmMenuUitstappen._actie;

            if (ontvActie == "Toevoegen")
            {
                lblKies.Visible = false;
                cmbKies.Visible = false;
                lblNaamUitstap.Visible = true;
                txtNaamUitstap.Visible = true;
                btnAanpassen.Text = ontvActie;
            }
            else if (ontvActie == "Aanpassen")
            {
                lblKies.Visible = true;
                cmbKies.Visible = true;
                lblNaamUitstap.Visible = true;
                txtNaamUitstap.Visible = true;
                btnAanpassen.Text = ontvActie;
            }
            else
            {
                lblKies.Visible = true;
                cmbKies.Visible = true;
                lblNaamUitstap.Visible = false;
                txtNaamUitstap.Visible = false;
                btnAanpassen.Text = ontvActie;
            }
            

        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if (btnAanpassen.Text == "Toevoegen")
            {
                // ga na of de gegevens zijn ingevuls
                if(txtNaamUitstap.Text != "")
                {
                    string naamUitstap = txtNaamUitstap.Text;
                    Program.BewerkenUitstap(-1, naamUitstap);

                    // form restetten
                    txtNaamUitstap.Text = "";

                    // stuur bevestiging 
                    MessageBox.Show("Deze uitstap werd toegevoegd", "Great Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // foutmelding
                    MessageBox.Show("U heeft niet alles ingevuld", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (btnAanpassen.Text == "Aanpassen")
            {
                // ga na of de gegevens zijn ingevuls
                if (txtNaamUitstap.Text != "" && cmbKies.SelectedIndex != -1)
                {

                }
                else
                {
                    // foutmelding
                }
            }
            else
            {
                // ga na of de gegevens zijn ingevuls
                if (cmbKies.SelectedIndex != -1)
                {

                }
                else
                {
                    // foutmelding
                }
            }
        }
    }
}
