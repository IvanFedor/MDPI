using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        override public AlumnoMuyEstudioso crearAleatorio()
        {

            return new AlumnoMuyEstudioso(aleatorio.stringAleatorio(5), aleatorio.numeroAleatorio(100000),
                aleatorio.numeroAleatorio(5000), aleatorio.numeroAleatorio(10), aleatorio.stringAleatorio(8), 10);
        }
        override public AlumnoMuyEstudioso crearPorTeclado()
        {

            return new AlumnoMuyEstudioso(teclado.stringPorTeclado(), teclado.numeroPorTeclado(),
                teclado.numeroPorTeclado(), teclado.numeroPorTeclado(), teclado.stringPorTeclado(),10);
        }
    }
}

