﻿using System;
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
            try
            {
                List<Depense> depensesNonReparti = new List<Depense>();
                DaoDepense dao = new DaoDepense();
                depensesNonReparti = dao.GetDepenseNonReparti();
                foreach (Depense depense in depensesNonReparti)
                {
                    lbDepense.Items.Add(depense);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            try
            {
                DaoDepense daoDepense = new DaoDepense();
                DaoColocataire daoColoc = new DaoColocataire();

                decimal total = 0;
                decimal resultat = 0;

                List<Colocataire> colocataires = daoColoc.GetAll();
                List<Depense> depensesNonReparti = daoDepense.GetDepenseNonReparti();

                foreach (Depense depense in depensesNonReparti)
                {
                    total += depense.Montant;

                }
                decimal doit = total / colocataires.Count;

                foreach (Colocataire coloc in colocataires)
                {
                    resultat = doit - daoDepense.GetDepenseByColoc(coloc.Id);
                    if (resultat < 0)
                    {
                        resultat = 0;
                    }
                    lbDoitCombien.Items.Add(coloc.Afficher(coloc.Nom, resultat));
                }

                foreach (Depense depense in depensesNonReparti)
                {

                    daoDepense.UpdateReparti(depense.Id);
                }
                this.btnRepartir.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
