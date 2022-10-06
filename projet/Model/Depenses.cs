using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Depenses
    {
        private int id;
        private DateTime date;
        private string text;
        private string justificatif;
        private decimal montant;
        private bool reparti;

        public Depenses(int id,DateTime date,string text, string justificatif,decimal montant,bool reparti)
        {
            this.id = id;
            this.date = date;
            this.text = text;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = reparti;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public string Justificatif { get { return this.justificatif; } set { this.justificatif = value; } }
        public string Montant { get { return this} }




    }
}
