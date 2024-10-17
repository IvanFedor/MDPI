using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{

    //Practica 3 ejercicio 3
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero");
           return int.Parse(Console.ReadLine());

        }
        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese una cadena de texto");
            return Console.ReadLine();
        }
    }
}
