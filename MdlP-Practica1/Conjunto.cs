using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //Practica 2 Ejercicio 3

    public class Conjunto : Coleccionable, Iterable, Ordenable
    {

        Diccionario diccionario;//???
        List<Comparable> lista = new List<Comparable>();
        Comparable clavePorDefecto = null;//???
        public OrdenEnAula1 ordenInicio = null;
        public OrdenEnAula1 ordenAulaLlena = null;
        public OrdenEnAula2 ordenAlumno = null;

        public List<Comparable> getElementos()
        {
            return this.lista;
        }
       
        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }


        public void agregarc(Comparable cv)
        {
            if (pertenece(cv))
            {
                //lista.Add(cv);
                diccionario.agregar((Comparable)cv);

            }
            else Console.WriteLine("elemento existente");

        }
        public bool pertenece(Comparable cv)
        {
            foreach (var x in diccionario.lista)
            {
                if (x.getClave() == cv.getClave())
                {
                    return true;
                }

            }
            return false;
        }
        public int cuantos()
        {
            return lista.Count();
        }
        public Comparable minimo()
        {
            Comparable min = lista[0].getValor();
            foreach (var x in lista)
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
            foreach (var x in lista)
            {
                if (x.getValor().sosMayor(max))
                {
                    max = x.getValor();

                }
            }
            return max;
        }

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

        public bool contiene(Comparable valor)
        {

            foreach (ClaveValor x in lista)
            {
                if (x.valor == valor)
                {
                    return true;
                }
            }
            return false;
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
