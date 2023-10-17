using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using claNegocios;
namespace LBWebApp
{
    public partial class frmAgregar : System.Web.UI.Page
    {
        tblProducto prod = new tblProducto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text)|| string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtMarca.Text))
            {
                lblMensaje.Text = "ERROR";
            }
            else
            {
                if (prod.insertarProductos(txtNombre.Text.Trim(),txtCodigo.Text.Trim(),txtDescripcion.Text.Trim(),txtMarca.Text.Trim()))
                {
                    lblMensaje.Text = "Agregado Correctamente";
                }
                else {
                    lblMensaje.Text = "No agregado";
                }
            }
        }
    }
}