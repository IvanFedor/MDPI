using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class AlumnoMuyEstudioso: Alumno,IAlumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, float promedio, string apellido, int calificacion) : base(nombre, dni, legajo, promedio, apellido)
        {
            this.calificacion = calificacion;
        }
        public override  int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
}
