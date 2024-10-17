using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   public class ComparacionPorAntiguedad : EstrategiaComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).getAntiguedad() == ((Profesor)c2).getAntiguedad();
        }

       public bool sosMayor(Comparable c1, Comparable c2)
        {
           return ((Profesor)c1).getAntiguedad() > ((Profesor)c2).getAntiguedad();
        }
       public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).getAntiguedad() < ((Profesor)c2).getAntiguedad();
        }

    }
}
