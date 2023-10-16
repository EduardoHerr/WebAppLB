using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claDatos;
namespace claNegocios
{
    public class negLogin
    {
        datConexion conn = new datConexion();
        static string valor;
        public string loggin(string username, string password)
        {
            
            string query = "SELECT * FROM tblUsuario WHERE userCi='" + username + "' AND userClave='" + password + "'";
            conn.abrir();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["userCi"].ToString().Equals(username) && reader["userClave"].ToString().Equals(password))
                {
                    valor = reader["userNombre"].ToString();
                }
            }
            conn.cerrar();
            reader.Close();
            return valor;
        }

    }
}
