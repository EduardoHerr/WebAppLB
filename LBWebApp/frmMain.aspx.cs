using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using claNegocios;

namespace LBWebApp
{
    public partial class frmMain : System.Web.UI.Page
    {
        tblProducto prod = new tblProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            DataSet ds = new DataSet();
            ds = prod.cargarProducto();
            if (ds!=null)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            
        }
    }
}