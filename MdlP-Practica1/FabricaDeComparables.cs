using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
    public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos teclado = new LectorDeDatos();

		

		public static Comparable crearAleatorio(int op)
		{
			FabricaDeComparables fabrica = null;

			switch (op)
			{
				case 1:
					fabrica = new FabricaDeAlumnos();
					break;
				case 2:
					fabrica = new FabricaDeNumeros();
					break;
				case 3:
					fabrica = new FabricaDeProfesores();
					break;
				case 4:
					fabrica = new FabricaDeAlumnosMuyEstudiosos();
					
					break;
				
			}
			return fabrica.crearAleatorio();
		}

		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		public static Comparable crearPorTeclado(int op)
		{ 

		 FabricaDeComparables fabrica = null;

			switch (op)
			{
				case 1:
					fabrica = new FabricaDeAlumnos();
					break;
				case 2:
					fabrica = new FabricaDeNumeros();
					break;
				case 3: fabrica = new FabricaDeProfesores();
					break;
				
			}
			return fabrica.crearPorTeclado();
		}

     

	}
}
