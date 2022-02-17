using ExamenProgramacion.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion.Clases
{
    class Universitario : Estudiante
    {

        string universidad;
        string carrera;
        string materiasInscritas;
        int notas;


        public Universitario()
        {
            Universidad = string.Empty;
            Carrera = string.Empty;
            MateriasInscritas = string.Empty;
            Notas = 0;
  

        }

        public Universitario(string nombreapellido, int edad, string segs, string carnet, string nivelacademico, string universidad, string carrera, string materiainscrita, int nota)
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

            

        }

        public string ImprimirUniversitario()
        {

            return "Nombre de Estudiante " + NombreYapellido + " Universidad: " + Universidad + "\r\n";
        }

        public int Promedio2()
        {
            return Notas;
        }


        public string Universidad { get => universidad; set => universidad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string MateriasInscritas { get => materiasInscritas; set => materiasInscritas = value; }
        public int Notas { get => notas; set => notas = value; }

        public Carrera CARRERA { get; set; }
    }
}
