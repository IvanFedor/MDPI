using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public class OrdenInicio : OrdenEnAula1
    {
        private Aula aula;
        public OrdenInicio(Aula a)
        {
            this.aula = a;
        }
        public void ejecutar()
        {
            aula.comenzar();
        }
    }
}
