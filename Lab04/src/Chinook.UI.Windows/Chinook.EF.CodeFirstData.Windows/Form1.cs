using Chinook.EF.CodeFirstData.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.EF.CodeFirstData.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            var artistDA = new ArtistDA();
            var data = artistDA.GetArtists(txtBuscarPorNombre.Text.Trim());

            //Enlazando los datos al grid
            dgvListado.DataSource = data;
            dgvListado.Refresh();
        }
    }
}
