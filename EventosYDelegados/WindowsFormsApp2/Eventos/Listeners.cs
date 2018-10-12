using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Eventos
{
    public class Listeners
    {
        public delegate void AfterSelectedItemHandler(Object obj);
        public delegate void AfterSavedItemHandler(Object obj);
    }
}
