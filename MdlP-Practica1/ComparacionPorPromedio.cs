using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public class ComparacionPorPromedio: EstrategiaComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {

            return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio();

        }
        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() < ((Alumno)c2).getPromedio();
        }
    }
}
