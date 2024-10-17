using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public class Aula 
    { 
    public Teacher teacher;

    public void comenzar()
    {
        Console.WriteLine("Comenzando la clase");
        teacher = new Teacher();
    }
    public void nuevoAlumno(AlumnoProxy a)
    {
        teacher.goToClass(new AlumnoAdapter(a));
    }
    public void claseLista()
    {
        teacher.teachingAClass();
    }

}
}
