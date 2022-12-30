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
    public partial class FsolderPeriode : Form
    {
        public FsolderPeriode()
        {
            InitializeComponent();
            DaoDepense dao = new DaoDepense();
            if (dao.toutEstReparti())
            {
                this.btnLancerRepartition.Enabled = false;
                this.lblRepartirDepense.Text = "Aucune dépense est à répartir";
            }
            this.btnLancerRepartition.Click += BtnLancerRepartition_Click;
        }

        private void BtnLancerRepartition_Click(object sender, EventArgs e)
        {
            try
            {
                RepartirDepense FrepartirDepense = new RepartirDepense();
                FrepartirDepense.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
