using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class Colocataires
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

        public void Add(Colocataire coloc)
        {
           this.lesColocataires.Add(coloc);
        }

        public List<Colocataire> LesColocataires
        {
            get { return this.lesColocataires; }
            set { this.lesColocataires = value; }
        }
    }
}
