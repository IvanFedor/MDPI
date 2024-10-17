using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public class DecoradoConLegajo : AlumnoDecorator
    {
        public DecoradoConLegajo(IAlumno ialu)
        {
            this.adicional = ialu;

        }
        public override string mostrarCalificacion()
        {
            return $"{ adicional.getApellido()} {adicional.getNombre()} { adicional.getLegajo()} {adicional.getCalificacion()}";
        }
        

        }

    }

