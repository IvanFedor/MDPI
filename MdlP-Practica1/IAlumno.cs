using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public interface IAlumno : Comparable
    {
        string getNombre();
        void setNombre(string n);
        string getApellido();
        void setCalificacion(int n);

        int getCalificacion();
        int getLegajo();

        string mostrarCalificacion();

        int responderPregunta(int q);
        int responderPreguntaest(int pregunta);




    }
}
