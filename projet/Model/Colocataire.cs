using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Colocataire
    {
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string telephone;
        private State state;
        public Colocataire(int id, string nom, string prenom, string mail, string telephone,State state)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
            this.state = state;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.nom, this.prenom, this.mail, this.telephone);
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }
            set
            {
                this.telephone = value;
            }
        }

        public State State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        public double aPaye()
        {
            double d= 0.0;
            return d;
        }

        public void Doit(decimal montantDu)
        {

        }

        public void Remove()
        {
            this.state = State.deleted;
        }

        
    }
}
