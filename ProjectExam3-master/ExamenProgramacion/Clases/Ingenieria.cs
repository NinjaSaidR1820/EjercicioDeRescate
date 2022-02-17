using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion.Clases
{
    class Ingenieria : Universitario
    {

        string nombreProyecto;
        int totalHoras;
        int horasCompletadas;


        public Ingenieria()
        {
            NombreProyecto = string.Empty;
            TotalHoras = 0;
            HorasCompletadas = 0;

        }


        public Ingenieria(string nombreapellido, int edad, string segs, string carnet, string nivelacademico, string universidad, string carrera, string materiainscrita, int nota, string nombreproyecto, int horatotal, int horacompletada)
        {

            this.NombreYapellido = nombreapellido;
            this.Edad = edad;
            this.Sexo = segs;
            this.NumeroCarnet = carnet;
            this.NivelEstudio = nivelacademico;
            this.Universidad = universidad;
            this.Carrera = carrera;
            this.MateriasInscritas = materiainscrita;
            this.Notas = nota;
            
            this.NombreProyecto = nombreproyecto;
            this.TotalHoras = horatotal;
            this.HorasCompletadas = horacompletada;
            
        }


        public string ImprimirIngenieria()
        {
         
            return "Nombre de Estudiante "+ NombreYapellido + " Universidad: " + Universidad+"\r\n";
        }

        public int Promedio1()
        {
            return Notas;
        }




        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public int TotalHoras { get => totalHoras; set => totalHoras = value; }
        public int HorasCompletadas { get => horasCompletadas; set => horasCompletadas = value; }
    }
}
