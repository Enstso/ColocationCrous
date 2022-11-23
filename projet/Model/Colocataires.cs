using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Colocataires
    {
       private List<Colocataire> lesColocataires;
        public Colocataires()
        {
            this.lesColocataires = new List<Colocataire>();
        }

        public int Count
        {
            get{
                return this.lesColocataires.Count;
               }
        }
    }
}
