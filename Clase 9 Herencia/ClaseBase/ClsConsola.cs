using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseBase
{
    internal class ClsConsola
    {
        public string Marca {  get; set; }
        public int AnioLanzamiento {  get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Algo nuevo Marca: {Marca}, año lanzamiento: {AnioLanzamiento}");
        }
        public ClsConsola(string m, int an)
        {
            Marca = m;
            AnioLanzamiento = an;
        }
    }
}
