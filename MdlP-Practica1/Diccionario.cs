using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{

    //Practica 2 Ejercicio 4
    public class Diccionario : Coleccionable, Iterable, Ordenable
    {

        public List<Comparable> lista = new List<Comparable>(); //???? 
        Conjunto conj = new Conjunto();
        Comparable clavePorDefecto;  // int?
        public OrdenEnAula1 ordenInicio = null;
        public OrdenEnAula1 ordenAulaLlena = null;
        public OrdenEnAula2 ordenAlumno = null;

        public List<Comparable> getElementos()
        {
            return this.lista;
        }
        public Iterador crearIterador()
        {
            return new IteradorDeDiccionario(this);
        }

        public int cuantos()
        {
            return lista.Count;
        }
        public Comparable minimo()
        {
            Comparable min = lista[0].getValor();
            foreach (Comparable x in lista)
            {
                if (x.getValor().sosMenor(min))
                {
                    min = x.getValor();
                }
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = lista[0].getValor();
            foreach (ClaveValor x in lista)
            {
                if (x.valor.sosMayor(max))
                {
                    max = x.valor;
                }
            }
            return max;
        }
        //public void agregar(Comparable cv)
        // {
        //     foreach(var x in lista)
        //     {
        //         if (x.getClave().sosIgual(((ClaveValor)cv).getClave()))
        //         {
        //             x.valor = ((ClaveValor)cv).valor;
        //         }

        //     }

        //     lista.Add((ClaveValor)cv);
        // }
        public void agregar(Comparable valor)
        {
            Comparable nuevocv = new ClaveValor(clavePorDefecto, valor);

            this.lista.Add(nuevocv);

            if (lista.Count == 1)
            {
                if (ordenInicio != null)
                {
                    ordenInicio.ejecutar();
                }
            }
            if (ordenAlumno != null)
            {
                ordenAlumno.ejecutar(valor);
            }
            if (lista.Count == 40)
            {
                if (ordenAulaLlena != null)
                {
                    ordenAulaLlena.ejecutar();
                }
            }
        }

        public bool contiene(Comparable com)
        {

            foreach (ClaveValor x in lista)
            {
                if (x.valor == com)
                {
                    return true;
                }
            }
            return false;
        }





        public Comparable valorDe(Comparable clave)
        {
            foreach (ClaveValor x in lista)
            {
                if (x.clave == clave)
                {
                    return x.valor;
                }


            }
            return null;
        }

        public void setOrdenInicio(OrdenEnAula1 o)
        {
            this.ordenInicio = o;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 o)
        {
            this.ordenAlumno = o;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 o)
        {
            this.ordenAulaLlena = o;
        }
    }
}
