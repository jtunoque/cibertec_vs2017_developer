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
            if (!Page.IsPostBack)
            {
                GetArtist();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            //Es nuevo
            if (String.IsNullOrWhiteSpace(hfID.Value))
            {
                service.AddArtist(
               new MantenimientoServices.Artist()
               {
                   Name = txtNombre.Text
               }
          );
            }
            else //Edicion
            {
                service.EditArtist(
               new MantenimientoServices.Artist()
               {
                   ArtistId = Convert.ToInt32(hfID.Value),
                   Name = txtNombre.Text
               });

            }

            Response.Redirect("frmArtists.aspx");
        }

        private void GetArtist()
        {

            if (String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                return;

            //Recuperando los parametros de la url
            //mediante el obeto Request
            var id = Convert.ToInt32(Request.QueryString["id"]);

            var cliente = 
                new MantenimientoServices.MantenimientosServicesClient();
            //Obteniendo la información completa del artista
            var artist = cliente.GetArtitsById(id);

            txtNombre.Text = artist.Name;
            hfID.Value = artist.ArtistId.ToString();

        }
    }
}