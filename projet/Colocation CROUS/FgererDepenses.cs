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
    public partial class FgererDepenses : Form
    {
        public FgererDepenses()
        {
            InitializeComponent();
            this.btnSaisirDepense.Click += BtnSaisirDepense_Click;
            this.btnModifierDepense.Click += BtnModifierDepense_Click;
            this.btnSupprimerDepense.Click += BtnSupprimerDepense_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnReinitialiser.Click += BtnReinitialiser_Click;
            this.cbTri.SelectedIndexChanged += CbTri_SelectedIndexChanged;
            Prix();
            ComboBox.ObjectCollection items = this.cbTri.Items;
            items.Add("id");
            items.Add("ladate");
            items.Add("texte");
            items.Add("justificatif");
            items.Add("montant");
            items.Add("reparti");
            items.Add("idColoc");
            this.load(new DaoDepense().GetAll());
        }

        private void Prix()
        {
            string montant = new DaoDepense().GetMontantTotal().ToString("0.00") + " €";
            this.lblMontant.Text = montant;
        }

        private void CbTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbGererDepenses.Items.Clear();
            this.load(new DaoDepense().GetAll(this.cbTri.SelectedItem.ToString()));
        }

        private void BtnReinitialiser_Click(object sender, EventArgs e)
        {
            try
            {
                DaoDepense daoDepense = new DaoDepense();
                daoDepense.ReinitialiserDepenses();
                lbGererDepenses.Items.Clear();
                MessageBox.Show("Les dépenses de l'application ont été supprimées", "Confirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Depense> depenses = new List<Depense>();
                foreach (object o in lbGererDepenses.Items)
                {
                    depenses.Add((Depense)o);
                }
                new DaoDepense().SaveChanges(depenses);
                this.load(depenses);
                MessageBox.Show("Enregistrement Valide");
                load(new DaoDepense().GetAll());
                Prix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSupprimerDepense_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbGererDepenses.SelectedIndex;
                ((Depense)lbGererDepenses.Items[position]).Remove();
                lbGererDepenses.Items[position] = lbGererDepenses.Items[position];
                MessageBox.Show("Une dépense a été supprimée", "Confirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnModifierDepense_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbGererDepenses.SelectedIndex;
                FnouvelleDepense fNouvelleDepense = new FnouvelleDepense(State.modified, lbGererDepenses.Items, position);
                fNouvelleDepense.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSaisirDepense_Click(object sender, EventArgs e)
        {
            try
            {
                FnouvelleDepense fNouvelleDepense = new FnouvelleDepense(State.added, lbGererDepenses.Items, 0);
                fNouvelleDepense.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load(List<Depense> depenses)
        {
            try
            {
                lbGererDepenses.Items.Clear();
                foreach (Depense depense in depenses)
                {
                    lbGererDepenses.Items.Add(depense);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
