using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //practica 3 ejercicio 2
  public  class GeneradorDeDatosAleatorios
    {
       public int numeroAleatorio(int max)
        {
            Random rnd = new Random();
            int numRnd = rnd.Next(0, max);
            return numRnd;
        }
        public string stringAleatorio(int cant)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string stringaleatorio = "";
            for (int i = 0; i<cant; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 25);
                stringaleatorio +=alfabeto[random];
            }
            return stringaleatorio;
        }
    }
}
