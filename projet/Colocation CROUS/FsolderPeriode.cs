using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colocation_CROUS
{
    public partial class FsolderPeriode : Form
    {
        public FsolderPeriode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepartirDepense FrepartirDepense = new RepartirDepense();
            FrepartirDepense.Show();
        }
    }
}
