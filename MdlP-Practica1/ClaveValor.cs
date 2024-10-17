using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   public class ClaveValor : Comparable
    {
        public Comparable clave; // Int??
        public Comparable valor;

        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Comparable getClave()
        {
            return this.clave;
        }
        public Comparable getValor()
        {
            return this.valor;
        }

        public void setEstrategia(EstrategiaComparacion est)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool sosMayor(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool sosMenor(Comparable com)
        {
            throw new NotImplementedException();
        }
    }
}
