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
    public partial class RepartirDepense : Form
    {
        public RepartirDepense()
        {
            InitializeComponent();
            this.loadDepenseNonReparti();
        }


        public void loadDepenseNonReparti()
        {
            List<Depense> d = new List<Depense>();
            DaoDepense dao = new DaoDepense();
            d = dao.GetDepenseNonReparti();
            foreach(Depense depense in d)
            {
                lbDepense.Items.Add(depense);
            }
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            DaoDepense daoDepense = new DaoDepense();
            DaoColocataire daoColoc = new DaoColocataire();

            decimal total = 0;
            decimal resultat = 0;

            List<Colocataire> colocataires = daoColoc.GetAll();
            List<Depense> depensesNonReparti = daoDepense.GetDepenseNonReparti();

            foreach(Depense depense in depensesNonReparti)
            {
                total += depense.Montant;
                daoDepense.UpdateReparti(depense.Id);
            }
            decimal doit = total / colocataires.Count;

            foreach(Colocataire coloc in colocataires)
            {
                resultat = doit - daoDepense.GetDepenseByColoc(coloc.Id);
                if (resultat < 0)
                {
                    resultat = 0;
                }
                lbDoitCombien.Items.Add(coloc.Afficher(coloc.Nom,resultat));
            }
        }
    }
}
