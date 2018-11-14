using Chinook.UI.WebForm.MantenimientoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm
{
    public partial class frmArtists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                Consultar();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Session["artists"] = null;
            Consultar();
        }

        private void Consultar()
        {
            dynamic data=null;

            if (Session["artists"] == null)
            {
                var service =
                    new MantenimientoServices.MantenimientosServicesClient();

                data = service.GetArtitsByname(txtFiltroByName.Text);

                Session["artists"] = data;
            }
            else
            {
                data = Session["artists"] as Artist[];
            }

            grdListado.DataSource = data;
            grdListado.DataBind();

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmArtistEdit.aspx");
        }

        protected void grdListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListado.PageIndex = e.NewPageIndex;
            Consultar();
        }
    }
}