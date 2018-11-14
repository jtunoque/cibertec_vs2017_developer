using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Mantenimientos.Artist
{
    public partial class frmArtistEdit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            service.AddArtist(
                new MantenimientoServices.Artist()
                {
                    Name = txtNombre.Text
                }
           );

            Response.Redirect("frmArtists.aspx");
        }
    }
}