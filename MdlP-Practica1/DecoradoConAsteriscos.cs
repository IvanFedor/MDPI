using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class DecoradoConAsteriscos :AlumnoDecorator

    {
        public DecoradoConAsteriscos(IAlumno ialu)
        {
            this.adicional = ialu;

        }
        public override string mostrarCalificacion()
        {
            
            return $"************************************\n*{base.mostrarCalificacion()}*\n************************************";
            

        }


    }
}

