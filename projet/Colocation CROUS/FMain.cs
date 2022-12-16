using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;

namespace Colocation_CROUS
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            this.btnGererColoc.Click += BtnGererColoc_Click;
            this.btnGererDepense.Click += BtnGererDepense_Click;
            this.btnSolderPeriode.Click += BtnSolderPeriode_Click;
            DaoConnectionSingleton.SetStringConnection("root", "", "localhost", "dbcrous");
        }

        private void BtnSolderPeriode_Click(object sender, EventArgs e)
        {
            FsolderPeriode fsolderPeriode = new FsolderPeriode();
            fsolderPeriode.Show();

        }

        private void BtnGererDepense_Click(object sender, EventArgs e)
        {
            GererDepenses gererDepenses = new GererDepenses();
            gererDepenses.Show();
        }

        private void BtnGererColoc_Click(object sender, EventArgs e)
        {
            GererColocataire gererColocataire = new GererColocataire();
            gererColocataire.Show();

        }
    }
}
