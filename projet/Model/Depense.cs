using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Depense
    {

        private int id;
        private DateTime date;
        private string texte;
        private string justificatif;
        private decimal montant;
        private bool reparti;
        private State state;
        private int idColoc;

        public Depense(int id, DateTime date, string texte, string justificatif, decimal montant, bool reparti, int idColoc, State state)
        {
            this.id = id;
            this.date = date;
            this.texte = texte;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = reparti;
            this.state = state;
            this.idColoc = idColoc;
        }
        public Depense( DateTime date, string texte, string justificatif, decimal montant, bool reparti, int idColoc, State state)
        {
            this.date = date;
            this.texte = texte;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = reparti;
            this.state = state;
            this.idColoc = idColoc;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public string Texte { get { return this.texte; } set { this.texte = value; } }
        public string Justificatif { get { return this.justificatif; } set { this.justificatif = value; } }
        public decimal Montant { get { return this.montant; } set { this.montant = value; } }
        public bool Reparti { get { return this.reparti; } set { this.reparti = value; } }
        public State State { get { return this.state; } set { this.state = value; } }
        public int IdColoc { get { return this.idColoc; } set { this.idColoc = value; } }

        public void Remove()
        {
            this.state = State.deleted;
        }



    }
}

