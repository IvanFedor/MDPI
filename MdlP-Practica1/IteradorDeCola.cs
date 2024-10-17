using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class IteradorDeCola :Iterador
    {
        Cola c;
        int indice;
        public IteradorDeCola(Cola cola)
        {
            this.c = cola;
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
            return (this.indice >= c.cuantos());
        }
        public Comparable actual()
        {
            return this.c.getElementos()[indice];
        }
    }
}
