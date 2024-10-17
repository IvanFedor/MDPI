using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
   
        public class AlumnoProxy : IAlumno, Comparable
        {
            private IAlumno alumnoReal = null;
            private string nombre;
            private int queCrear;
            public AlumnoProxy(string n, int quecrear)
            {
                this.nombre = n;
            this.queCrear = quecrear;
            }

            public string getApellido()
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                    alumnoReal.setNombre(nombre);
                }
                return alumnoReal.getApellido();
            }

            public int getCalificacion()
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                    alumnoReal.setNombre(nombre);
                }
                return alumnoReal.getCalificacion();
            }

        public Comparable getClave()
        {
            throw new NotImplementedException();
        }

        public int getLegajo()
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                    alumnoReal.setNombre(nombre);
                }
                return alumnoReal.getLegajo();
            }

            public string getNombre()
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                    alumnoReal.setNombre(nombre);
                }
                return alumnoReal.getNombre();
            }

        public Comparable getValor()
        {
            throw new NotImplementedException();
        }

        public string mostrarCalificacion()
            {
            if (alumnoReal == null)
            {
                alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                alumnoReal.setNombre(nombre);
            }
            return alumnoReal.mostrarCalificacion();
        }

            public int responderPregunta(int q)
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);
                
                alumnoReal.setNombre(nombre);
                
                }
           
            return alumnoReal.responderPregunta(q);

            }

            public int responderPreguntaest(int pregunta)
            {
                throw new NotImplementedException();
            }

            public void setApellido(string a)
            {
                throw new NotImplementedException();
            }

            public void setCalificacion(int n)
            {
                if (alumnoReal == null)
                {
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);

                    alumnoReal.setNombre(nombre);
                    alumnoReal.setCalificacion(n);
                }


            }

            public void setEstrategia(EstrategiaComparacion est)
            {
                throw new NotImplementedException();
            }

            public void setNombre(string n)
            {
                this.nombre = n;
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
        }
    }

