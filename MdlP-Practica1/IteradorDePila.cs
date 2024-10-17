using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class IteradorDePila : Iterador
    {
        Pila p;
        int indice;
        public IteradorDePila(Pila p)
        {
            this.p = p;
            primero();
        }

        public void primero()
        {
            this.indice = 0;
        }
        public void siguiente()
        {
            this.indice++;
        }
        public bool fin()
        {
            return (this.indice >= p.cuantos());
        }
        public Comparable actual()
        {
            return this.p.getElementos()[indice];
        }
    }
}
