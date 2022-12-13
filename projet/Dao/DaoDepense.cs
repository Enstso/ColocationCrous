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
        public void SaveChanges(List<Depense> depenses)
        {
            for (int i = 0; i < depenses.Count; i++)
            {
                Depense depense = depenses[i];
                switch (depense.State)
                {
                    case State.added:
                        this.insert(depense);
                        break;
                    case State.modified:
                        this.update(depense);
                        break;
                    case State.deleted:
                        this.delete(depense);
                       depenses.Remove(depense);
                        break;
                }
            }

        }
        public List<Depense> GetAll()
        {
            List<Depense> depenses = new List<Depense>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,ladate,texte,justificatif,montant,reparti,idColoc from depense;", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            depenses.Add(new Depense(Convert.ToInt32(rdr["id"]), Convert.ToDateTime(rdr["ladate"]), rdr["texte"].ToString(), rdr["justificatif"].ToString(), Convert.ToDecimal(rdr["montant"]), Convert.ToBoolean(rdr["reparti"]), Convert.ToInt32(rdr["idColoc"]), State.unChanged));
                        }
                    }
                }
                cnx.Close();
            }
            return depenses;
        }

        public List<Depense> GetAllByIdColoc(int idColoc)
        {
            List<Depense> depenses = new List<Depense>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,ladate,texte,justificatif,montant,reparti,idColoc from depense where idColoc = @idColoc;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idColoc", idColoc));
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            depenses.Add(new Depense(Convert.ToInt32(rdr["id"]), Convert.ToDateTime(rdr["ladate"]), rdr["texte"].ToString(), rdr["justificatif"].ToString(), Convert.ToDecimal(rdr["montant"]), Convert.ToBoolean(rdr["reparti"]), Convert.ToInt32(rdr["idColoc"]), State.unChanged));
                        }
                    }
                }
                cnx.Close();
            }
            return depenses;
        }


        private void delete(Depense depense)
            {
                using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
                {
                    cnx.Open();
                    using (MySqlCommand cmd = new MySqlCommand("delete from Depense where id=@id", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@id", depense.Id));
                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            private void update(Depense depense)
            {
                using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
                {
                    cnx.Open();
                    using (MySqlCommand cmd = new MySqlCommand("Update Depense set texte=@texte ladate=@ladate,justificatif=@justificatif,montant=@montant,reparti=@reparti,idColoc=@idcoloc  where id=@id", cnx))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@id",depense.Id));
                        cmd.Parameters.Add(new MySqlParameter("@texte", depense.Texte));
                        cmd.Parameters.Add(new MySqlParameter("@ladate", depense.Date));
                        cmd.Parameters.Add(new MySqlParameter("@justificatif", depense.Justificatif));
                        cmd.Parameters.Add(new MySqlParameter("@montant", depense.Montant));
                        cmd.Parameters.Add(new MySqlParameter("@reparti", depense.Reparti));
                        cmd.Parameters.Add(new MySqlParameter("@idColoc", depense.IdColoc));

                    cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                depense.State = State.unChanged;
            }
            private void insert(Depense depense)
            {
                using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
                {
                    cnx.Open();
                    using (MySqlCommand cmd = new MySqlCommand("insert into Depense(ladate,texte,justificatif,montant,reparti,idColoc) values(@ladate,@texte,@justificatif,@montant,@reparti,@idColoc)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@texte", depense.Texte));
                    cmd.Parameters.Add(new MySqlParameter("@ladate", depense.Date));
                    cmd.Parameters.Add(new MySqlParameter("@justificatif", depense.Justificatif));
                    cmd.Parameters.Add(new MySqlParameter("@montant", depense.Montant));
                    cmd.Parameters.Add(new MySqlParameter("@reparti", depense.Reparti));
                    cmd.Parameters.Add(new MySqlParameter("@idColoc", depense.IdColoc));
                    cmd.ExecuteNonQuery();
                        // Todo coder la récupération de LastId                     
                    }
                }
                depense.State = State.unChanged;
            }
        }
    }

