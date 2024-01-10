using System;
using System.Collections.Generic;
using System.Data;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }
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
            txtNombre.Text = gdata1.Rows[key].Cells[0].ToString();
            txtCodigo.Text = gdata1.Rows[key].Cells[1].ToString();
            txtDescripcion.Text = gdata1.Rows[key].Cells[2].ToString();
            txtMarca.Text = gdata1.Rows[key].Cells[3].ToString();
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
                if (prod.insertarProductos(txtNombre.Text.Trim(), txtCodigo.Text.Trim(), txtDescripcion.Text.Trim(), txtMarca.Text.Trim()))
                {
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Datos Guardados";
                    
                }
                else
                {
                    lblMensaje.ForeColor= Color.Red;
                    lblMensaje.Text = "Datos NO Guardados";
                }
            }
           
            limpiar();
            cargarGrid();
           
        }

        protected void gdata1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="Editar")
            {
                int fila = ((GridViewRow)((LinkButton)e.CommandSource).Parent.Parent).RowIndex;
                llenarTxt(fila);
            }
        }
    }
}