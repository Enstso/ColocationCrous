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
using System.Media;

namespace Colocation_CROUS
{
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
            this.btnGererColoc.Click += BtnGererColoc_Click;
            this.btnGererDepense.Click += BtnGererDepense_Click;
            this.btnSolderPeriode.Click += BtnSolderPeriode_Click;
            this.btnReinitialiser.Click += BtnReinitialiser_Click;
            SoundPlayer sound = new SoundPlayer(@"wi.WAV");
            sound.Play();
            DaoConnectionSingleton.SetStringConnection("root", "", "localhost", "dbcrous");
        }

        private void BtnReinitialiser_Click(object sender, EventArgs e)
        {
            try
            {
                DaoDepense daoDepense = new DaoDepense();
                daoDepense.ReinitialiserDepenses();
                DaoColocataire daoColocataire = new DaoColocataire();
                daoColocataire.ReinitialiserColocataires();
                MessageBox.Show("L'application a été réinitilisée", "Confirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSolderPeriode_Click(object sender, EventArgs e)
        {
            try
            {
                FsolderPeriode fsolderPeriode = new FsolderPeriode();
                fsolderPeriode.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnGererDepense_Click(object sender, EventArgs e)
        {
            try
            {
                FgererDepenses fgererDepenses = new FgererDepenses();
                fgererDepenses.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGererColoc_Click(object sender, EventArgs e)
        {
            try
            {
                FgererColocataire gererColocataire = new FgererColocataire();
                gererColocataire.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
