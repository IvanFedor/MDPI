using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    class DecoradoConLetras : AlumnoDecorator
    {
        public DecoradoConLetras(IAlumno ialu)
        {
            this.adicional = ialu;

        }
        public string numeroAletra(int n)
        {
            
            switch (n)
            {
                case 1:
                    return "UNO";
                   
                case 2:
                    return "DOS";
                    
                case 3:
                    return "TRES";
                    
                case 4:
                    return "CUATRO";
                    
                case 5:
                    return "CINCO";
                    
                case 6:
                    return "SEIS";
                   
                case 7:
                    return "SIETE";
                   
                case 8:
                    return "OCHO";
                    
                case 9:
                    return "NUEVE";
                   
                case 10:
                    return "DIEZ";
                    
                case 0:
                    return "CERO";
                    
            }
            return "sin nota";
            

        }
        
       
        public override string mostrarCalificacion()
        {
            return $"{base.mostrarCalificacion()} {numeroAletra(adicional.getCalificacion())}";
        }
    }
}
