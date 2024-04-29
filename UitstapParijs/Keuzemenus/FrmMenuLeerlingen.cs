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
    public partial class FrmMenuLeerlingen : Form
    {
        public FrmMenuLeerlingen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLeerlingToevoegen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmLlnToevoegen nieuwForm = new FrmLlnToevoegen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }

       
        private void btnLeerlingenAanpassen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmLlnAanpassen nieuwForm = new FrmLlnAanpassen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }

        private void btnLeerlingenVerwijderen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmLlnVerwijderen nieuwForm = new FrmLlnVerwijderen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }

        private void btnKeuzeToevoegen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmKeuzeToevoegen nieuwForm = new FrmKeuzeToevoegen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }

        private void btnKeuzeAanpassen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmKeuzeAanpassen nieuwForm = new FrmKeuzeAanpassen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }
    }
}
