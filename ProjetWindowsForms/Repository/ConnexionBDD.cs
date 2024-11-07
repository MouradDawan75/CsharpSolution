using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Repository
{
    public class ConnexionBDD
    {

        public static SqlConnection GetConnexion()
        {
            string chaine = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=csharp;Integrated Security=True";
            SqlConnection cnx = new SqlConnection(chaine);
            cnx.Open();
            return cnx;
        }
    }
}
