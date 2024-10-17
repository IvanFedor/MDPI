using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //Ejercicio 4.
    public class Pila : Coleccionable, Iterable, Ordenable
    {
        List<Comparable> elementos;
        // public OrdenInicio oi = null;
        public OrdenEnAula1 ordenInicio = null;
        public OrdenEnAula1 ordenAulaLlena = null;
        public OrdenEnAula2 ordenAlumno = null;
        //public OrdenAulaLlena oaf = null;

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }
        public List<Comparable> getElementos()
        {
            return this.elementos;
        }
        public Pila()
        {
            this.elementos = new List<Comparable>();

        }
        public void apilar(Comparable com)
        {
            this.elementos.Add(com);
            if (elementos.Count == 1)
            {
                if (ordenInicio != null)
                {
                    ordenInicio.ejecutar();
                }
            }
            if (ordenAlumno != null)
            {
                ordenAlumno.ejecutar(com);
            }
            if (elementos.Count == 40)
            {
                if (ordenAulaLlena != null)
                {
                    ordenAulaLlena.ejecutar();
                }
            }
        }
        public Comparable desapilar()
        {
            Comparable aux = elementos.Last();
            elementos.RemoveAt(elementos.Count - 1);
            return aux;
        }
        public int cuantos()
        {
            return this.elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable minimo = this.elementos[0];

            foreach (var x in elementos)
            {
                if (x.sosMenor(minimo))
                {
                    minimo = x;
                }
            }
            return minimo;
        }
        public Comparable maximo()
        {
            Comparable maximo = this.elementos[0];

            foreach (var x in elementos)
            {
                if (x.sosMayor(maximo))
                {
                    maximo = x;
                }
            }
            return maximo;

        }
        public void agregar(Comparable com)
        {
            this.apilar(com);
        }
        public bool contiene(Comparable com)
        {
            foreach (var x in elementos)
            {
                if (x.sosIgual(com))
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

