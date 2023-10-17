using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claDatos;

namespace claNegocios
{
    public class tblProducto
    {
        datConexion con = new datConexion();

        public bool insertarProductos(string nombre,string codigo,string descripcion,string marca)
        {
            string query = "INSERT INTO tblProducto (prodNombre,prodCodigo,prodDescripcion,prodMarca,prodEstado) VALUES (@nombre,@codigo,@descripcion,@marca,'A')";
            
            SqlCommand cmd = new SqlCommand(query, con.con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@marca", marca);
            try
            {
                con.abrir();
                cmd.ExecuteNonQuery();
                con.cerrar();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

            
        }


    }
}
