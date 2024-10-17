using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class IteradorDeConjunto :Iterador
    {

        Conjunto conj;
        int indice;
        public IteradorDeConjunto(Conjunto conjunto)
        {
            this.conj   = conjunto;
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
            return (this.indice >= conj.cuantos());
        }
        public Comparable actual()
        {
            return ((Comparable)conj.getElementos()[indice]);
        }
    }
}
