using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{

    //Ejercicio 8.
    class ColeccionMultiple : Coleccionable
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        public ColeccionMultiple(Pila pi,Cola co)
        {
            this.pila = pi;
            this.cola = co;
        }
        public int cuantos()
        {
          int n1 =  this.pila.cuantos();
          int n2 = this.cola.cuantos();
            return (n1 + n2);
        }
      public  Comparable minimo()   
        {
            Comparable com1 = this.pila.minimo();
            Comparable com2 = this.cola.minimo();
            //int  n1= ((Numero)com1).getValor();
            //int n2 = ((Numero)com2).getValor();
            int n1 = ((Persona)com1).getDni();
            int n2 = ((Persona)com2).getDni();
            if (n1 < n2)
            {
                return com1;
            }
            return com2;


        }
       public Comparable maximo()
        {
            Comparable com1 = this.pila.maximo();
            Comparable com2 = this.cola.maximo();
            //int n1 = ((Numero)com1).getValor();
            //int n2 = ((Numero)com2).getValor();
            int n1 = ((Persona)com1).getDni();
            int n2 = ((Persona)com2).getDni();
            if (n1 > n2)
            {
                return com1;
            }
            return com2;
        }
      public  void agregar(Comparable com)
        {

        }
        public bool contiene(Comparable com)
        {
           if(this.pila.contiene(com))
            {
                return true;
            }
           if (this.cola.contiene(com))
            {
                this.cola.contiene(com);
                return true;
            }
            return false;
        }

        public Iterador crearIterador()
        {
            throw new NotImplementedException();
        }
    }
   
}
