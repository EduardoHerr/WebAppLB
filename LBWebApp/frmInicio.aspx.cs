using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LBWebApp
{
    public partial class frmInicio : System.Web.UI.Page
    {
        static string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"]!=null)
                {
                    nombre = Session["usuario"].ToString();
                }
            }
            calculoHora(nombre);

        }

        private void calculoHora(string nombre)
        {
            int hora = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (hora >= 06 && hora <= 11)
            {
                lblInicio.Text = "Buenos días "+nombre;
            }
            if (hora >= 12 && hora <= 18)
            {
                lblInicio.Text = "Buenas Tardes " + nombre;
            }
            else
            {
                lblInicio.Text = "Buenas Noches " + nombre;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frmAgregar.aspx");
        }
    }
}