using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Depense : Component
    {
        public Depense()
        {
            InitializeComponent();
        }

        public Depense(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
