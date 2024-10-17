using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   public class Profesor : Persona, Observado
    {
        private int antiguedad;
        
        private List<Observador> observadores;
        private bool hablando;

        public Profesor(string nombre, int dni, int antiguedad,string apellido) : base(nombre,dni,apellido)
        {
            this.antiguedad = antiguedad;
            observadores = new List<Observador>();
            this.hablando = false;
            this.setEstrategia(new ComparacionPorAntiguedad());
        }
        public bool isHablando()
        {
            return this.hablando;
        }
        public int getAntiguedad()
        {
            return this.antiguedad;
        }
        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algun tema");
            this.hablando = true;
            notificar();
        }
        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron");
            this.hablando = false;
            notificar();
        }
        public override bool sosIgual(Comparable com)
        {

            return this.antiguedad == ((Profesor)com).getAntiguedad();
        }
        public override bool sosMenor(Comparable com)
        {

            return this.antiguedad > ((Profesor)com).getAntiguedad();
        }
        public override bool sosMayor(Comparable com)
        {

            return this.antiguedad < ((Profesor)com).getAntiguedad();
        }

        // implemento interface observado
       public void agregarObservador(Observador o)
        {
            observadores.Add(o);
        }
       public void quitarObservador(Observador o)
        {
            observadores.Remove(o);
        }
       public  void notificar()
        {
            foreach (Observador obs in observadores)
            {
                obs.actualizar(this);
            }
        }
    }
}
