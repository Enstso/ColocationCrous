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
            
        }

        public void load(List<Depenses> depenses)
        {
            lbGererDepenses.Items.Clear();
            foreach (Depenses depense in depenses)
            {
                lbGererDepenses.Items.Add(depense);
            }
        }

        private void GererDepenses_Load(object sender, EventArgs e)
        {

        }
    }
}
