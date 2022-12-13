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
    public partial class GererDepenses : Form
    {
        public GererDepenses()
        {
            InitializeComponent();
            this.btnSaisirDepense.Click += BtnSaisirDepense_Click;
            this.btnModifierDepense.Click += BtnModifierDepense_Click;
            this.btnSupprimerDepense.Click += BtnSupprimerDepense_Click;
            this.btnSave.Click += BtnSave_Click;
            this.load(new DaoDepense().GetAll());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<Depense> depenses = new List<Depense>();
            foreach (object o in lbGererDepenses.Items)
            {
                depenses.Add((Depense)o);
            }
            new DaoDepense().SaveChanges(depenses);
            this.load(depenses);
        }

        private void BtnSupprimerDepense_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbGererDepenses.SelectedIndex;
                ((Depense)lbGererDepenses.Items[position]).Remove();
                lbGererDepenses.Items[position] = lbGererDepenses.Items[position];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModifierDepense_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbGererDepenses.SelectedIndex;
                FNouvelleDepense fNouvelleDepense = new FNouvelleDepense(State.modified, lbGererDepenses.Items,position);
                fNouvelleDepense.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSaisirDepense_Click(object sender, EventArgs e)
        {
            try
            {
                FNouvelleDepense fNouvelleDepense = new FNouvelleDepense(State.added,lbGererDepenses.Items,0);
                fNouvelleDepense.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load(List<Depense> depenses)
        {
            lbGererDepenses.Items.Clear();
            foreach (Depense depense in depenses)
            {
                lbGererDepenses.Items.Add(depense);
            }
        }

        private void GererDepenses_Load(object sender, EventArgs e)
        {

        }
    }
}
