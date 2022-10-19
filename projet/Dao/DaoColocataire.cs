using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
namespace Dao
{
    public class DaoColocataire
    {
        public void SaveChanges(List<Colocataire> colocataires)
        {
            for (int i = 0; i < colocataires.Count; i++)
            {
                Colocataire colocataire = colocataires[i];
                switch (colocataire.State)
                {
                    case State.added:
                        this.insert(colocataire);
                        break;
                    case State.modified:
                        this.update(colocataire);
                        break;
                    case State.deleted:
                        this.delete(colocataire);
                        colocataires.Remove(colocataire);
                        break;
                }
            }

        }

        private void delete(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Colocataire where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = colocataire.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void update(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Colocataire set nom=@nom,prenom=@prenom,mail=@mail,telephone=@telephone  where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@mail", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@telephone", MySqlDbType.VarChar));
                    cmd.Parameters["@id"].Value = colocataire.Id;
                    cmd.Parameters["@nom"].Value = colocataire.Nom;
                    cmd.Parameters["@prenom"].Value = colocataire.Prenom;
                    cmd.Parameters["@mail"].Value = colocataire.Mail;
                    cmd.Parameters["@telephone"].Value = colocataire.Telephone;
                    cmd.ExecuteNonQuery();
                }
            }
            colocataire.State = State.unChanged;
        }
        private void insert(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Colocataire(nom,prenom,mail,telephone) values(@nom,@prenom,@mail,@telephone)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@mail", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@telephone", MySqlDbType.VarChar));
                    cmd.Parameters["@nom"].Value = colocataire.Nom;
                    cmd.Parameters["@prenom"].Value = colocataire.Prenom;
                    cmd.Parameters["@mail"].Value = colocataire.Mail;
                    cmd.Parameters["@telephone"].Value = colocataire.Telephone;
                    cmd.ExecuteNonQuery();
                    // Todo coder la récupération de LastId                     
                }
            }
            colocataire.State = State.unChanged;
        }

        public List<Colocataire> GetAll()
        {
            List<Colocataire> colocataires = new List<Colocataire>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mail,telephone from Colocataire", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            colocataires.Add(new Colocataire(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mail"].ToString(), rdr["telephone"].ToString(), State.unChanged)); 
                        }
                    }
                }
            }
            return colocataires;
        }

        public Colocataire GetById(int id)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mail,telephone from Colocataire where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = id;
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return new  Colocataire(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mail"].ToString(), rdr["telephone"].ToString(), State.unChanged);
                        }
                    }
                }
            }
            throw new Exception("id non défini pour la table Colocataire");
        }
    }
}

