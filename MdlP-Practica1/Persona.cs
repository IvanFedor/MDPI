using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //Ejercicio 11.
    public class Persona : Comparable
    {
        string nombre;
        string apellido;       
        int dni;
        EstrategiaComparacion estrategia;
        public Persona(string n, int d, string a)
        {
            this.nombre = n;
            this.apellido = a;
            this.dni = d;
            this.estrategia = new ComparacionPorDni();
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string n)
        {
            this.nombre = n;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getDni()
        {
            return this.dni;
        }
       public virtual bool sosIgual(Comparable com)
        {
           
            return this.dni == ((Persona)com).getDni();
        }
        public virtual bool sosMenor(Comparable com)
        {
           
            return this.dni < ((Persona)com).getDni();
        }
        public virtual bool sosMayor(Comparable com)
        {
            
            return this.dni > ((Persona)com).getDni();
        }

       

        public void setEstrategia(EstrategiaComparacion est)
        {
            this.estrategia = est;
        }
        public override string ToString()
        {
            return nombre+" "+ dni;
        }

        public Comparable getValor()
        {
            throw new NotImplementedException();
        }

        public Comparable getClave()
        {
            throw new NotImplementedException();
        }
    }
}
