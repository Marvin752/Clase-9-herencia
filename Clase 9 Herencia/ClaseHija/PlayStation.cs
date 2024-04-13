using Clase_9_Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseHija
{
    internal class PlayStation : ClsConsola
    {
        public PlayStation(string m, int an, string j) : base(m, an)
        {
            ModeloControlador = j;
        }
        public string ModeloControlador { get; set; }
        public string MOstrarDetallesPs()
        {
            MostrarDetalles();
            return $"Modelo de controlador: {ModeloControlador}";
        }
    }
}
