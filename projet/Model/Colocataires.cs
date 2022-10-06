using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Colocataires : Colocataire
    {
        public Colocataires(int id, string nom, string prenom, string mail, string telephone):base( id,  nom,  prenom,  mail,  telephone)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mail = mail;
            this.Telephone = telephone;
        }

        public void Count()
        {

        }
    }
}
