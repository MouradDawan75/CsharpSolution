using ProjetWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Repository
{
    public class UtilisateurRepository
    {

        public static void Insert(Utilisateur u)
        {
            SqlConnection cnx = ConnexionBDD.GetConnexion();
            string sql = "insert into utilisateurs(email,password,photo,admin) values (@email,@password,@photo,@admin)";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@photo", u.Photo);
            cmd.Parameters.AddWithValue("@admin", u.Admin);

            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        public static Utilisateur FindByEmail(string email)
        {
            Utilisateur u = null;

            SqlConnection cnx = ConnexionBDD.GetConnexion();
            string sql = "select * from utilisateurs where email=@email";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@email", email);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                u = new Utilisateur(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
            }

            reader.Close();
            cnx.Close();

            return u;
        }
    }
}
