using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion.Clases
{
    class Estudiante : Persona
    {

        string numeroCarnet;
        string nivelEstudio;

        public Estudiante()
        {

            NumeroCarnet = string.Empty;
            NivelEstudio = string.Empty;
        }

        public string NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }
        public string NivelEstudio { get => nivelEstudio; set => nivelEstudio = value; }
    }
}
