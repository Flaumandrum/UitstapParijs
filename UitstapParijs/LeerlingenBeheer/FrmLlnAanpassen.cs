﻿using System;
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

        }
    }
}
