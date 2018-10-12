using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Base
{
    public class DocumentoBase
    {
        protected string TipoDocumento = "";

        public string NroSerie { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public Double MontoTotal { get; set; }

        public DateTime? FechaPago { get; set; }


        public virtual string EnviarDocumento()
        {
            //Aplicando String Interpolation
            //Sintaxis: $ y {}
            return $"Se han enviado la {TipoDocumento} con Nro: {NroSerie}-{NroDocumento}";
        }
    }
}
