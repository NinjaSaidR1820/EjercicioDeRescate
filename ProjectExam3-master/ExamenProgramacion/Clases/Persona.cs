using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion.Clases
{
    class Persona
    {

         string nombreYapellido;
         string sexo;
         int edad;


        public Persona()
        {
            NombreYapellido = string.Empty;
            Edad = 0;
            Sexo = string.Empty;

        }

        public string NombreYapellido { get => nombreYapellido; set => nombreYapellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
