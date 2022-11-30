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
    public partial class GererColocataire : Form
    {
        public GererColocataire()
        {
            InitializeComponent();
            btnajouter.Click += this.Btnajouter_Click;
            btnmodifier.Click += Btnmodifier_Click;
            btnsupprimer.Click += Btnsupprimer_Click;
            btnsave.Click += Btnsave_Click;
            this.load(new DaoColocataire().GetAll());
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            List<Colocataire> colocataires = new List<Colocataire>();
            foreach (object o in lbColocataire.Items)
            {
                colocataires.Add((Colocataire)o);
            }
            new DaoColocataire().SaveChanges(colocataires);
            this.load(colocataires);
        }

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            if (lbColocataire.SelectedIndex == -1)
                return;
            int position = lbColocataire.SelectedIndex;
            ((Colocataire)lbColocataire.Items[position]).Remove();
            lbColocataire.Items[position] = lbColocataire.Items[position];
        }

        private void Btnmodifier_Click(object sender, EventArgs e)
        {
            if (lbColocataire.SelectedIndex == -1)
                return;
            else
            {
                int position = lbColocataire.SelectedIndex;
                FnouveauColocataire fedit = new FnouveauColocataire(State.modified, lbColocataire.Items, position);
                fedit.Show();
            }
        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            FnouveauColocataire fedit = new FnouveauColocataire(State.added, lbColocataire.Items, 0);
            fedit.Show();
        }

        private void load(List<Colocataire> colocataires)
        {
            lbColocataire.Items.Clear();
            foreach (Colocataire coloc in colocataires)
            {
                lbColocataire.Items.Add(coloc);
            }
        }

        private void GererColocataire_Load(object sender, EventArgs e)
        {

        }
    }
}
