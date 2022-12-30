using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;
namespace Colocation_CROUS
{
    public partial class FgererColocataire : Form
    {
        public FgererColocataire()
        {
            InitializeComponent();
            btnajouter.Click += this.Btnajouter_Click;
            btnmodifier.Click += Btnmodifier_Click;
            btnsupprimer.Click += Btnsupprimer_Click;
            btnsave.Click += Btnsave_Click;
            this.btnReinitialiser.Click += BtnReinitialiser_Click;
            this.load(new DaoColocataire().GetAll());
        }

        private void BtnReinitialiser_Click(object sender, EventArgs e)
        {
            try
            {
                DaoColocataire daoColocataire = new DaoColocataire();
                daoColocataire.ReinitialiserColocataires();
                lbColocataire.Items.Clear();
                MessageBox.Show("Les colocataires de l'application ont été supprimés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Colocataire> colocataires = new List<Colocataire>();
                foreach (object o in lbColocataire.Items)
                {
                    colocataires.Add((Colocataire)o);
                }
                new DaoColocataire().SaveChanges(colocataires);
                this.load(colocataires);
                MessageBox.Show("Enregistrement Valide");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbColocataire.SelectedIndex;
                ((Colocataire)lbColocataire.Items[position]).Remove();
                lbColocataire.Items[position] = lbColocataire.Items[position];
                MessageBox.Show("Un colocataire a été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btnmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                int position = lbColocataire.SelectedIndex;
                FnouveauColocataire fedit = new FnouveauColocataire(State.modified, lbColocataire.Items, position);
                fedit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                FnouveauColocataire fedit = new FnouveauColocataire(State.added, lbColocataire.Items, 0);
                fedit.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load(List<Colocataire> colocataires)
        {
            try
            {
                lbColocataire.Items.Clear();
                foreach (Colocataire coloc in colocataires)
                {
                    lbColocataire.Items.Add(coloc);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
    }
}
