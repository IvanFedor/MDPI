using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class FabricaDeProfesores : FabricaDeComparables
    {
        public override Profesor crearAleatorio()
        {
            return new Profesor(aleatorio.stringAleatorio(5), aleatorio.numeroAleatorio(100000), aleatorio.numeroAleatorio(80),aleatorio.stringAleatorio(8));
        }
        override public Profesor crearPorTeclado()
        {

            return new Profesor(teclado.stringPorTeclado(), teclado.numeroPorTeclado(),
                teclado.numeroPorTeclado(),teclado.stringPorTeclado());
        }
    }
}
