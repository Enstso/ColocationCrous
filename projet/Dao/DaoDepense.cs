using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace Dao
{
   public class DaoDepense
    {
        public List<Depenses> GetAll()
        {
            List<Depenses> depenses = new List<Depenses>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,ladate,texte,justificatif,montant,reparti,idColoc from depense;", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            depenses.Add(new Depenses(Convert.ToInt32(rdr["id"]), Convert.ToDateTime(rdr["ladate"]), rdr["texte"].ToString(), rdr["justificatif"].ToString(), Convert.ToDecimal(rdr["montant"]), Convert.ToBoolean(rdr["reparti"]),Convert.ToInt32(rdr["idColoc"]), State.unChanged));
                        }
                    }
                }
                cnx.Close();
            }
            return depenses;
        }
    }
}
