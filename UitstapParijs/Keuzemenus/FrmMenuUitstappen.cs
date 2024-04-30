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
    public partial class FrmMenuUitstappen : Form
    {
        public FrmMenuUitstappen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegenUitstap_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmUitstapBeheren nieuwForm = new FrmUitstapBeheren();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwForm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnAanpassenUitstap_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmUitstapBeheren nieuwForm = new FrmUitstapBeheren();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwForm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnUistapVerwijderen_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmUitstapBeheren nieuwForm = new FrmUitstapBeheren();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwForm.ShowDialog();

            // oud form tonen
            Show();
        }
    }
}
