using Clase_9_Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseHija
{
    internal class XBOX : ClsConsola
    {
        public XBOX(string m, int an) : base(m, an)
        {
        }
        public bool gamepass { get; set; }
        public string MostrarDetallesXbox()
        {
            MostrarDetalles();
            return $"Estado del GamePass: {gamepass}";
        }
    }
}
