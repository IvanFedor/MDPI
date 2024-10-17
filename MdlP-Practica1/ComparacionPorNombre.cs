using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   public  class ComparacionPorNombre : EstrategiaComparacion
    {
      
        public bool sosIgual(Comparable c1, Comparable c2)
        {

            return (0 == ((Alumno)c1).getNombre().CompareTo(((Alumno)c2).getNombre()));
            
        }
        public bool sosMayor(Comparable c1 , Comparable c2)
        {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }
    }
}
