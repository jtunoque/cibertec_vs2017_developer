﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Base
{
    public class Boleta: DocumentoBase, IDocumento
    {
        /*Constructor*/
        public Boleta()
        {
            this.TipoDocumento = "Boleta";
        }

    }

}
