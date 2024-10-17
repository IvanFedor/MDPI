using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{//Ejercicio 1
    public interface Comparable
    {

        
        bool sosIgual(Comparable com);
        bool sosMenor(Comparable com);
        bool sosMayor(Comparable com);

        void setEstrategia(EstrategiaComparacion est);
        Comparable getValor();
        Comparable getClave();
    }
}
