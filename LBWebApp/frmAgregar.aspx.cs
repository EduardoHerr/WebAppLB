using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using claNegocios;

namespace LBWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        tblProducto prod = new  tblProducto();  
        static bool editar = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();


            }

            lblAviso.Text = "Insercion de Productos";
            lnkInsertar.Visible = false;

        }

        void limpiar()
        {
            txtCodigo.Text = txtDescripcion.Text = txtMarca.Text = txtNombre.Text = "";
        }
        private void cargarGrid()
        {
            DataTable dat = new DataTable();
            dat = prod.cargarDatos();
            gdata1.DataSource = dat;
            gdata1.DataBind();

        }


        private  void llenarTxt(int key)
        {

            SqlDataReader dat = prod.cargarProductoxID(key);
            if (dat.Read())
            {
                txtNombre.Text = dat["prodNombre"].ToString();
                txtCodigo.Text = dat["prodCodigo"].ToString();
                txtDescripcion.Text = dat["prodDescripcion"].ToString();
                txtMarca.Text = dat["prodMarca"].ToString();

            }

            
        }


        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtMarca.Text))
            {

                lblMensaje.ForeColor = Color.Orange;
                lblMensaje.Text = "Datos Incorrectos";

            }
            else
            {
                if (editar)
                {

                }
                else
                {
                    if (prod.insertarProductos(txtNombre.Text.Trim(), txtCodigo.Text.Trim(), txtDescripcion.Text.Trim(), txtMarca.Text.Trim()))
                    {
                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Text = "Datos Guardados";

                    }
                    else
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "Datos NO Guardados";
                    }
                }

                if (!editar)
                {
                    lblAviso.Text = "Insercion de Productos";
                    lnkInsertar.Visible = false;
                }
                else
                {
                    lblAviso.Text = "Edicion de Productos";
                    lnkInsertar.Visible = true;
                }

            }
           
            limpiar();
            cargarGrid();
           
        }

        protected void gdata1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="Editar")
            {
                int fila = Convert.ToInt16( e.CommandArgument);
                llenarTxt(fila);
                editar = true;
                Response.Redirect("~/frmAgregar.aspx");
            }
        }

        protected void lnkInsertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frmAgregar.aspx");
            editar = false;
        }
    }
}