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
            List<Depense> d = new List<Depense>();

            Dictionary<string, decimal> dict= new Dictionary<string, decimal>();

            List<Colocataire> c = new List<Colocataire>();
            List<decimal> montants = new List<decimal>();
            decimal total = 0;
            decimal doit = 0;
            DaoDepense dao = new DaoDepense();
            DaoColocataire daoC = new DaoColocataire();
            c = daoC.GetAll();
            d = dao.GetDepenseNonReparti();
            //for (int i = 0;i<)
            foreach (Depense depense in d)
            {
                montants.Add(depense.Montant);
                total += depense.Montant;
                //dict.Add()
            }
            doit = total / c.Count();
        }
    }
}
