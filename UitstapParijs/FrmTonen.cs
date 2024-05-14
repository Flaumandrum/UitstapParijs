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
    public partial class FrmTonen : Form
    {
        public FrmTonen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // tekstbox leegmaken 
            txtToon.Text = "";


            if(rbAlleLln.Checked)
            {

                txtToon.Text = Program.ToonLln(1);

            }
            else if (rbLlnPerUistap.Checked)
            {
                txtToon.Text = Program.ToonLln(2);

            }
            else if(rbAlleUitstappen.Checked)
            {
                txtToon.Text = Program.ToonLln(3);
            }
            else
            {
                // foutmelding 
                MessageBox.Show("U moet eerst een keuze maken ", "fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
