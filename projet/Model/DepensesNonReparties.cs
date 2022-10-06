using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DepensesNonReparties:Depenses
    {
        public DepensesNonReparties(int id, DateTime date, string text, string justificatif, decimal montant, bool reparti) : base(id, date, text, justificatif, montant, reparti)
        {

        }
    }
}
