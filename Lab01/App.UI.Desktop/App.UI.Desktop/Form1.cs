using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            lblIGV.Text = 
                ConfigurationManager.AppSettings["IGV"];
        }

        private void btnEnviarFactura_Click(object sender, EventArgs e)
        {
            Factura documento = new Factura();
            documento.NroSerie = "F001";
            documento.NroDocumento = "000001";

            Factura documento2 = new Factura();
            documento2 = documento;
            documento2.NroSerie = "F002";
            MessageBox.Show(documento2.EnviarDocumento());

            var boleta = new Boleta();
            boleta.NroSerie = "B001";
            boleta.NroDocumento = "0000003";
            MessageBox.Show(boleta.EnviarDocumento());

            var baja = new ComunicacionBaja();
            baja.NroSerie = "B001";
            baja.NroDocumento = "0000003";
            MessageBox.Show(baja.EnviarDocumento());

            IDocumento documentoGenerico = new Boleta();
            MessageBox.Show(documentoGenerico.EnviarDocumento()); ;

            IDocumento documentoGenerico2 = new ComunicacionBaja();
            MessageBox.Show(documentoGenerico2.EnviarDocumento());

            


            /*
              documento.NroSerie es igual a F002--->

              documento2.NroSerie es igual a F002--->7
             
             */






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factura documento=null;
            //Validando el dato en tres lineas de codigo
            if (documento !=null && documento.NroDocumento != null)
            {
                string nroDoc = documento.NroDocumento;
            }

            //Con elvis operator, en una sola línea de código
            string nroDoc2 = documento?.NroDocumento;
        }
    }
}
