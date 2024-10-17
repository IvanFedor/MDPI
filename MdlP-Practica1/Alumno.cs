using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    //Ejercicio 15.
   public class Alumno : Persona, Observador, IAlumno
    {
       public int legajo;
       public float promedio;
       public int calificacion;

       
       
        public Alumno(string nombre, int dni, int legajo,float promedio, string apellido) : base(nombre, dni, apellido)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.setEstrategia(new ComparacionPorDni());
        }
      
        public int getCalificacion()
        {
            return this.calificacion;
        }
        public void setCalificacion(int n)
        {
            this.calificacion = n;
        }

        public virtual int responderPregunta(int pregunta)
        {
            Random r = new Random();
            return r.Next(1,3);
        }
        public string mostrarCalificacion()
        {
            return $"{this.getNombre()} {this.getCalificacion()}  ";
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public float getPromedio()
        {
            return this.promedio;
        }
    
        
        //Ejercicio 18
        public override bool sosIgual(Comparable com)
        {

            return this.legajo == ((Alumno)com).getLegajo();
        }
        public override bool sosMenor(Comparable com)
        {
          
            return this.legajo > ((Alumno)com).getLegajo();
        }
        public override bool sosMayor(Comparable com)
        {
           
            return this.legajo < ((Alumno)com).getLegajo();
        }
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atencion");
        }
        public void distraerse()
        {
            List<string> lista = new List<string> { "mirando el ceular", "dibujando en el margen de la hoja", "Tirando aviones de papel" };
            Random rnd = new Random();
            int alea = rnd.Next(0, 2);
            Console.WriteLine(lista[alea]); 
        }
        public void actualizar(Observado o)
        {
            if (((Profesor)o).isHablando())
            {
                prestarAtencion();
            }
            else distraerse();
        }

        public int responderPreguntaest(int pregunta)
        {
            throw new NotImplementedException();
        }

        public void setNombre(string n)
        {
            base.setNombre(n);
        }
    }
        //public override bool sosIgual(Comparable com)
        //{
        //    return this.estrategia.sosIgual((Alumno)com);
        //}

    }

