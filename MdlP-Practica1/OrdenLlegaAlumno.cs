using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public class OrdenLLegaAlumno : OrdenEnAula2
    {
        private Aula aula;
        public OrdenLLegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((AlumnoProxy)c);
        }
    }
}
