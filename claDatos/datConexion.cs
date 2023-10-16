using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace claDatos
{
    public class datConexion
    {
        public SqlConnection con = new SqlConnection("Data Source=DbinventoryLB.mssql.somee.com;Initial Catalog=DbinventoryLB;Persist Security Info=True;User ID=Barbas_SQLLogin_1;Password=xhuilpj8aq");

        #region apertura y cerrado de Base de Datos
        //abrir
        public SqlConnection abrir()
        {
            if (con.State == ConnectionState.Closed )
            {
                con.Open();
            }
            return con;
        }
        //cerrar
        public SqlConnection cerrar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
        #endregion

    }
}
