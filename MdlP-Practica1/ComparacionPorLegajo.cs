using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class ComparacionPorLegajo : EstrategiaComparacion
    {
      
        public bool sosIgual(Comparable c1, Comparable c2)
        {

            return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();

        }
        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
        }
    }
}
