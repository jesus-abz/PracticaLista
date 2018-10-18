using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVista
{
    class Materia
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public int CalPriPar { get; set; }
        public int CalSegPar { get; set; }
        public int CalTerPar { get; set; }
        public int CalFinal { get; set; }

        public Materia(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;

            CalPriPar = 0;
            CalSegPar = 0;
            CalTerPar = 0;
            CalFinal = 0;
        }

        public Materia(string clave, string nombre, int calPriPar, int calSegPar, int calTerPar, int calFinal)
        {
            Clave = clave;
            Nombre = nombre;

            CalPriPar = calPriPar;
            CalSegPar = calSegPar;
            CalTerPar = calTerPar;
            CalFinal = calFinal;
        }
    }
}
