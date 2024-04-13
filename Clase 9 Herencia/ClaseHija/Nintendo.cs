using Clase_9_Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseHija
{
    internal class Nintendo : ClsConsola
    {
        public Nintendo(string m, int an) : base(m, an)
        {
        }

        public bool EsPortatil { get; set; }
        public string MostratDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
