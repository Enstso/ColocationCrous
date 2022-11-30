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
    public partial class FNouvelleDepense : Form
    {
        public FNouvelleDepense()
        {
            InitializeComponent();
            IdColoc();
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbidColoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FNouvelleDepense_Load(object sender, EventArgs e)
        {

        }

        private void IdColoc()
        {
            Colocataires colocataires = new Colocataires();

            foreach (Colocataire coloc in new DaoColocataire().GetAll())
            {
                colocataires.Add(coloc);
            }

            foreach (object colocs in colocataires.LesColocataires)
            {
                this.cbidColoc.Items.Add(colocs);
            }
        }
    }
}
