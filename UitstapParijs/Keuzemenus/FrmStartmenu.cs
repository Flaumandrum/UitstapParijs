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
    public partial class FrmStartmenu : Form
    {
        public FrmStartmenu()
        {
            InitializeComponent();
        }

        private void btnLeerlingBeheer_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken
            FrmMenuLeerlingen nieuwForm = new FrmMenuLeerlingen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();

        }

        private void Tonen_Click(object sender, EventArgs e)
        {

            // Nieuw form aanmaken
            FrmTonen nieuwForm = new FrmTonen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();

        }

        private void btnUitstappenBeheer_Click(object sender, EventArgs e)
        {

            // Nieuw form aanmaken
            FrmMenuUitstappen nieuwForm = new FrmMenuUitstappen();

            // Oud form hiden 
            Hide();

            // Nieuwform tonen
            nieuwForm.ShowDialog();

            // Oud form tonen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
