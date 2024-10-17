using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class IteradorDeDiccionario : Iterador
    {
        Diccionario dic;
        int indice;
        public IteradorDeDiccionario(Diccionario diccionario)
        {
            this.dic = diccionario;
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
            return (this.indice >= dic.cuantos());
        }
        public Comparable actual()
        {
            return ((Comparable)this.dic.getElementos()[indice]);
        }
    }
}
