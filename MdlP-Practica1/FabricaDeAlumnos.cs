using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   public  class FabricaDeAlumnos : FabricaDeComparables
    {
        
        override public Alumno crearAleatorio()
        {

            return new Alumno(aleatorio.stringAleatorio(5), aleatorio.numeroAleatorio(100000),
                aleatorio.numeroAleatorio(5000), aleatorio.numeroAleatorio(10), aleatorio.stringAleatorio(8));
        }
        override public Alumno crearPorTeclado()
        {

            return new Alumno(teclado.stringPorTeclado(), teclado.numeroPorTeclado(),
                teclado.numeroPorTeclado(), teclado.numeroPorTeclado(), teclado.stringPorTeclado());
        }
    }
}
