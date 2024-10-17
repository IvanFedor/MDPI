using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
  public  class AlumnoAdapter: Student
    {
        private IAlumno alu;
        public AlumnoAdapter(IAlumno alu)
        {
            this.alu = alu;
            
        }
        public int getLegajo()
        {
            return alu.getLegajo();
        }
        
        public string yourLastNameIs()
        {
            return alu.getApellido();
        }
        public  int yourAnswerIs(int question)
        {
            
            return alu.responderPregunta(question);
        }
        public  string showScore()
        {
            return alu.mostrarCalificacion();
        }

        public string getName()
        {
            return alu.getNombre();
        }

        public void setScore(int score)
        {
            alu.setCalificacion(score);
        }

        public string showResult()
        {
            return alu.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            return alu.getLegajo() == student.getLegajo();
        }

        public bool lessThan(Student student)
        {
           return alu.getLegajo() > student.getLegajo();
        }

        public bool greaterThan(Student student)
        {
            return alu.getLegajo() < student.getLegajo();
        }
    }
}
