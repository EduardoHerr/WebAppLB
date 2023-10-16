using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using claNegocios;

namespace LBWebApp
{
    public partial class frmLogin : System.Web.UI.Page
    {
        negLogin log = new negLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            lblMensaje.Visible = false;
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)||string.IsNullOrEmpty(txtClave.Text))
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor= System.Drawing.Color.Red;
                lblMensaje.Text = "Espacio Vacio";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    lblMensaje.Visible = true;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "Espacio en Blanco";
                }
                else
                {
                    if (log.loggin(txtUser.Text.Trim(),txtClave.Text.Trim())!=null)
                    {
                        lblMensaje.Visible = false;
                        Session["usuario"] = log.loggin(txtUser.Text.Trim(), txtClave.Text.Trim());
                        Response.Redirect("~/frmInicio.aspx");
                    }
                    else
                    {
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        lblMensaje.Text = "Datos Erroneos";
                    }
                }
            }
        }
    }
}