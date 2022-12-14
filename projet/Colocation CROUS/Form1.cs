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
namespace Colocation_CROUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DaoConnectionSingleton.SetStringConnection("root", "", "localhost", "dbCrous");
        }

        private void btnGererColoc_Click(object sender, EventArgs e)
        {
            GererColocataire gererColocataire = new GererColocataire();
            gererColocataire.Show();
        }

        private void btnGererDepenses_Click(object sender, EventArgs e)
        {
            GererDepenses n = new GererDepenses();
            n.Show();
        }

        

        private void btnSolderPeriode_Click(object sender, EventArgs e)
        {
            FsolderPeriode fsolderPeriode = new FsolderPeriode();
            fsolderPeriode.Show();
        }
    }
}
