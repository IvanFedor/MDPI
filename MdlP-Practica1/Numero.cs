using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //Ejercicio 2.
    public class Numero : Comparable
    {
        private int valor;
        public Numero(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        {
            return this.valor;
        }
        //Ejercicio 2 p2
      public  bool sosIgual(Comparable com)
        {
            if (this.valor == ((Numero)com).getValor())
            {
                return true;

            }
            return false;
        }
     public   bool sosMenor(Comparable com)
        {
            if (this.valor < ((Numero)com).getValor())
            {
                return true;
            }
            return false;
        }
     public   bool sosMayor(Comparable com)
        {
            if (this.valor > ((Numero)com).getValor())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return valor.ToString();

            
        }
        public void setEstrategia(EstrategiaComparacion e)
        {

        }

        Comparable Comparable.getValor()
        {
            throw new NotImplementedException();
        }

        public Comparable getClave()
        {
            throw new NotImplementedException();
        }
    }
}
