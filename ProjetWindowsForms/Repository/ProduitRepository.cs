using ProjetWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetWindowsForms.Repository
{
    public class ProduitRepository
    {
        //CRUD: Create - Read - Update - Delete

        public static void Insert(Produit p)
        {
            //Connexion à la BD

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            //Commande SQL

            string sql = "Insert into produits(description,prix,quantite) values(@description,@prix,@quantite)";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            
            cmd.Parameters.AddWithValue("@description",p.Description);
            cmd.Parameters.AddWithValue("@prix",p.Prix);
            cmd.Parameters.AddWithValue("@quantite",p.Quantite);

            cmd.ExecuteNonQuery();


            //Déconnexion
            cnx.Close();
        }

        public static void Update(Produit p)
        {
            //Connexion à la BD

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            //Commande SQL
            

            string sql = "Update produits set description=@description,prix=@prix,quantite=@quantite where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);


            cmd.Parameters.AddWithValue("@description", p.Description);
            cmd.Parameters.AddWithValue("@prix", p.Prix);
            cmd.Parameters.AddWithValue("@quantite", p.Quantite);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();


            //Déconnexion
            cnx.Close();
        }

        public static void Delete(int id)
        {
            //Connexion à la BD

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            //Commande SQL

            string sql = "delete from produits where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();


            //Déconnexion
            cnx.Close();
        }

        public static List<Produit> GetAll()
        {
            List<Produit> prods = new List<Produit>();

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            string sql = "select * from produits"; // *: pour prendre toutes les colonnes
            //string sql = "select description,prix from produits"; // pour selectionner certaines colonnes

            SqlCommand cmd = new SqlCommand(sql, cnx);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Convertir ligne en cours en produit
                Produit p = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));

                //Insérer ce produit dans la liste
                prods.Add(p);
            }

            reader.Close();
            cnx.Close();   


            return prods;
        }

        public static Produit GetById(int id)
        {
            Produit p = null;

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            string sql = "select * from produits where id=@id";

            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                p = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));
            }

            reader.Close();
            cnx.Close();

            return p;
        }

        public static List<Produit> FindByKey(string key) 
        {
            List<Produit> prods = new List<Produit>();

            SqlConnection cnx = ConnexionBDD.GetConnexion();

            string sql = "select * from produits where description like @key"; 

            SqlCommand cmd = new SqlCommand(sql, cnx); // %p%

            cmd.Parameters.AddWithValue("@key", "%" + key + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Convertir ligne en cours en produit
                Produit p = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));

                //Insérer ce produit dans la liste
                prods.Add(p);
            }

            reader.Close();
            cnx.Close();


            return prods;
        }
    }
}
