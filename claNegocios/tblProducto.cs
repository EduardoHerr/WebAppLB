using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claDatos;

namespace claNegocios
{
    public class tblProducto
    {
        datConexion con = new datConexion();
        static SqlDataAdapter sda;
        public  DataTable cargarDatos()
        {
            string query = "SELECT * FROM tblProducto";
            SqlCommand cmd = new SqlCommand(query, con.con);
             sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.abrir();
            sda.Fill(dt);
            con.cerrar();
            return dt;
            
        }
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

        public DataSet cargarProducto()
        {
            string query = "SELECT * FROM tblProducto";
            SqlCommand cmd = new SqlCommand (query, con.con);
            con.abrir();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            con.cerrar();
            return dt;
                
        }

        public SqlDataReader cargarProductoxID(int key)
        {
            string query = "SELECT * FROM tblProducto WHERE idProducto="+key;
            SqlCommand cmd = new SqlCommand(query, con.con);
            con.abrir();
            SqlDataReader sdr = cmd.ExecuteReader();
            
            return sdr;
        }

    }
}
