using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public abstract class AlumnoDecorator : IAlumno
    {
        protected IAlumno adicional;

        public virtual string getApellido()
        {
            return adicional.getApellido();
        }

        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public virtual int getCalificacion()
        {
            return adicional.getCalificacion();
        }

        public string getNombre()
        {
          return  adicional.getNombre();
        }
        public int getLegajo()
        {
            return adicional.getLegajo();
        }

        public void setEstrategia(EstrategiaComparacion est)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool sosMayor(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool sosMenor(Comparable com)
        {
            throw new NotImplementedException();
        }

        public int responderPregunta(int q)
        {
          return  adicional.responderPregunta(q);
        }

        public void setCalificacion(int n)
        {
            adicional.setCalificacion(n);
        }

        public int responderPreguntaest(int pregunta)
        {
          return  adicional.responderPreguntaest(pregunta);
        }

        public void setNombre(string n)
        {
            throw new NotImplementedException();
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
