using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 o);
        void setOrdenLlegaAlumno(OrdenEnAula2 o);
        void setOrdenAulaLlena(OrdenEnAula1 o);
    }
}
