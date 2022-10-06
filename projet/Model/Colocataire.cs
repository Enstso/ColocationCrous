using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    class Colocataire
    {
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string telephone;

        public Colocataire(int id, string nom, string prenom, string mail, string telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
        }

        public int Id
        {
            get
            {
                return this.id;
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

        public double aPaye()
        {
            double d= 0.0;
            return d;
        }

        public void Doit(decimal montantDu)
        {

        }
    }
}
