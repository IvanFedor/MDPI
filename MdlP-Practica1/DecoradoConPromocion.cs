using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class DecoradoConPromocion : AlumnoDecorator
    {
        public DecoradoConPromocion(IAlumno ialu)
        {
            this.adicional = ialu;

        }
        public string isPromocionado(int n)
        {

            if (n < 4)
                return "DESAPROBADO";
            if (n >= 4 & n < 7)
                return "APROBADO";
            if (n >= 7)
                return "PROMOCION";
            else
                return "Sin Nota";



        }
        public override string mostrarCalificacion()
        {
            return $"{base.mostrarCalificacion()} {isPromocionado(adicional.getCalificacion())}";
        }


    }
}

