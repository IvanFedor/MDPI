using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class FabricaDeNumeros: FabricaDeComparables
    {
        override public Numero crearAleatorio()
        {

            return new Numero(aleatorio.numeroAleatorio(10));
        }
        override public Numero crearPorTeclado()
        {

            return new Numero(teclado.numeroPorTeclado());
        }
    }
   
       

    
    
}
