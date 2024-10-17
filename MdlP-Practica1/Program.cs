using System;
using System.Collections.Generic;

namespace MdlP_Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher teacher = new Teacher();
            Student student;
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();


            IAlumno alu, deco1, deco2, deco3, deco4;
            for (int i = 0; i < 10; i++)
            {
                AlumnoProxy alumnoProxy = new AlumnoProxy(gen.stringAleatorio(5), 1);
                deco1 = new DecoradoConLetras(alumnoProxy);
                deco2 = new DecoradoConLegajo(deco1);
                deco3 = new DecoradoConPromocion(deco2);
                deco4 = new DecoradoConAsteriscos(deco3);
                student = new AlumnoAdapter(deco4);
                teacher.goToClass(student);
            }
            for (int i = 0; i < 10; i++)
            {
                AlumnoProxy alumnoProxy = new AlumnoProxy(gen.stringAleatorio(5), 4);
                deco1 = new DecoradoConLetras(alumnoProxy);
                deco2 = new DecoradoConLegajo(deco1);
                deco3 = new DecoradoConPromocion(deco2);
                deco4 = new DecoradoConAsteriscos(deco3);
                student = new AlumnoAdapter(deco4);
                teacher.goToClass(student);
            }
            teacher.teachingAClass();



            Aula aula = new Aula();
            OrdenAulaLlena oal = new OrdenAulaLlena(aula);
            OrdenInicio oi = new OrdenInicio(aula);
            OrdenLLegaAlumno ola = new OrdenLLegaAlumno(aula);
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();
            pila.setOrdenInicio(oi);
            pila.setOrdenAulaLlena(oal);
            pila.setOrdenLlegaAlumno(ola);
            cola.setOrdenInicio(oi);
            cola.setOrdenAulaLlena(oal);
            cola.setOrdenLlegaAlumno(ola);
            conjunto.setOrdenInicio(oi);
            conjunto.setOrdenAulaLlena(oal);
            conjunto.setOrdenLlegaAlumno(ola);
            diccionario.setOrdenInicio(oi);
            diccionario.setOrdenAulaLlena(oal);
            diccionario.setOrdenLlegaAlumno(ola);
            llenar(pila, 1);
            llenar(pila, 4);
            llenar(cola, 1);
            llenar(cola, 4);
            llenar(conjunto, 1);
            llenar(conjunto, 4);
            llenar(diccionario, 1);
            llenar(diccionario, 4);
            
            //for ( int i= 0;i<10; i++)
            //{
            //    alu = (Alumno)FabricaDeComparables.crearAleatorio(1);



            //    deco1 = new DecoradoConLetras(alu);
            //    deco2 = new DecoradoConLegajo(deco1);
            //    deco3 = new DecoradoConPromocion(deco2);
            //    deco4 = new DecoradoConAsteriscos(deco3);
            //    student = new AlumnoAdapter(deco4);
            //    teacher.goToClass(student);

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    alu = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
            //    deco1 = new DecoradoConLetras(alu);
            //    deco2 = new DecoradoConLegajo(deco1);
            //    deco3 = new DecoradoConPromocion(deco2);
            //    deco4 = new DecoradoConAsteriscos(deco3);


            //    student = new AlumnoAdapter(deco4);
            //    teacher.goToClass(student);

            //}
            //teacher.teachingAClass();

            ////Ejercicio 7.
            //Console.WriteLine("Hello World!");
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //llenar(pila);
            //llenar(cola);
            //Console.WriteLine("lala");
            //informar(pila);
            //informar(cola);
            //Ejercicio 13.
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            //llenarPersonas(pila);
            //llenarPersonas(cola);
            //informar(multiple);
            // Ejercicio 17.

            //ultimo
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            //llenar(pila,1);
            //llenar(cola,2);
            //informar(multiple,1);
            //informar(pila,1);
            //informar(cola, 2);
            //Profesor profe = new Profesor("sarmiento", 1234, 25, "perez");
            //Pila pila = new Pila();
            //llenarAlumnos(pila);
            //Iterador ite = pila.crearIterador();
            //while (!ite.fin())
            //{
            //    profe.agregarObservador((Observador)ite.actual());
            //    ite.siguiente();

            //}

            //dictadoDeClases(profe);


            // Practica 2 Ejercicio 8

            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //Conjunto conjunto = new Conjunto();
            //Diccionario diccionario = new Diccionario();
            //llenarAlumnos(pila);
            //llenarAlumnos(cola);
            //llenarAlumnos(conjunto);
            //llenarAlumnos(diccionario);
            //imprimirElementos(pila);
            //imprimirElementos(cola);
            //imprimirElementos(conjunto);
            //imprimirElementos(diccionario);

            //practica 2 Ejercicio 10
            //Pila pila = new Pila();
            //llenarAlumnos(pila);

            //cambiarEstrategia(pila, new ComparacionPorLegajo());
            //informar(pila);

            //cambiarEstrategia(pila, new ComparacionPorLegajo());

            //informar(pila);

            //cambiarEstrategia(pila, new ComparacionPorPromedio());
            //informar(pila);
            //cambiarEstrategia(pila, new ComparacionPorDni());
            //informar(pila);




        }
        //Practica 2 Ejercicio 9
        public static void cambiarEstrategia(Coleccionable col, EstrategiaComparacion est)
        {
            Iterador ite = col.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                ite.actual().setEstrategia(est);
                ite.siguiente();
            }
        }

        //Ejercicio 12.
        //public static void llenarPersonas(Coleccionable col)
        //{
        //    List<string> listanombres = new List<string>()
        //    {"jorge", "Pedro", "gabriel", "Mariano", "Alejandro",
        //        "Rodrigo", "Ariel", "Martin","Lucas", "Adrian"
        //    , "Camila", "Mariana", "Romina", "Josefina", "Agustina",
        //    "Maria", "Julia", "Marta", "Mabel","Esther" };
        //    for (int i = 0; i < 20; i++)
        //    {
        //        var random = new Random();
        //        int numRnd = random.Next(1, 99999999);
        //        int numRnd2 = random.Next(1, 20);
        //        string n = listanombres[numRnd2];

        //        Persona p1 = new Persona(n, numRnd);
        //        col.agregar(p1);
        //    }
        //}
        //public static void llenar(Coleccionable col)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        var random = new Random();
        //        int numRnd = random.Next(1, 100);
        //        Comparable aux = new Numero(numRnd);
        //        col.agregar(aux);

        //    }
        //}
        //Ejercicio 6.
        //public static void informar(Coleccionable col)
        //{
        //    Console.WriteLine(col.cuantos()); 
        //    Console.WriteLine(((Numero)col.minimo()).getValor());
        //    Console.WriteLine(((Numero)col.maximo()).getValor());
        //    int valor = Convert.ToInt32(Console.ReadLine());
        //    Comparable com = new Numero(valor);
        //    if (col.contiene(com))
        //    {
        //        Console.WriteLine("El elemento leido esta en la coleccion");
        //    }
        //    else Console.WriteLine("El elemento leido no esta en la coleccion");
        //}
        //public static void informar(Coleccionable col)
        //{
        //    Console.WriteLine(col.cuantos());
        //    Console.WriteLine(col.minimo());
        //    Console.WriteLine(col.maximo());
        //    string nombre = Console.ReadLine();
        //    int dni = Convert.ToInt32(Console.ReadLine());
        //    Comparable com = new Persona(nombre, dni);
        //    if (col.contiene(com))
        //    {
        //        Console.WriteLine("El elemento leido esta en la coleccion");
        //    }
        //    else Console.WriteLine("El elemento leido no esta en la coleccion");
        //}
        //Ejercicio 16.
        //public static void llenarAlumnos(Coleccionable col)
        //{
        // List<string> listanombres = new List<string>()
        //    {"jorge", "Pedro", "gabriel", "Mariano", "Alejandro",
        //        "Rodrigo", "Ariel", "Martin","Lucas", "Adrian"
        //    , "Camila", "Mariana", "Romina", "Josefina", "Agustina",
        //    "Maria", "Julia", "Marta", "Mabel","Esther" };

        //    for (int h = 0; h < 20; h++)
        //        {
        //            var random = new Random();
        //            int dni = random.Next(1, 99999999);
        //            int numRnd2 = random.Next(1, 20);
        //            string n = listanombres[numRnd2];
        //            int l = random.Next(1, 20);
        //            int p = random.Next(1, 10);
        //        string ap = listanombres[numRnd2];
        //            Comparable com = new Alumno(n, dni, l, p,ap);
        //            com.setEstrategia(new ComparacionPorLegajo());
        //            col.agregar(com);


        //        }
        //    }
        public static void llenarAlumnos(Coleccionable col)
        {
            List<string> listanombres = new List<string>()
            {"jorge", "Pedro", "gabriel", "Mariano", "Alejandro",
                "Rodrigo", "Ariel", "Martin","Lucas", "Adrian"
            , "Camila", "Mariana", "Romina", "Josefina", "Agustina",
            "Maria", "Julia", "Marta", "Mabel","Esther" };

            for (int h = 0; h < 20; h++)
            {
                var random = new Random();
                int dni = random.Next(1, 99999999);
                int numRnd2 = random.Next(1, 20);
                string n = listanombres[numRnd2];
                int l = random.Next(1, 2);
                int p = random.Next(1, 10);
                string ap = listanombres[numRnd2];
                Comparable com = new AlumnoProxy(n,l );
                
                col.agregar(com);


            }
        }

        public static void imprimirElementos(Coleccionable col)
        {
            Iterador ite = col.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }
        public static void llenar(Coleccionable coleccionable, int opcion)
        {

            for (int i = 0; i < 20; i++)
            {
                GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
                Random rnd = new Random();
                Comparable comparable = new AlumnoProxy(gen.stringAleatorio(6), rnd.Next(1, 2));
                coleccionable.agregar(comparable);
                //public static void llenar(Coleccionable coleccionable, int opcion) {
                //    for (int i = 0; i< 20; i++) {
                //        Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                //        coleccionable.agregar(comparable);
            }
        }
        public static void informar(Coleccionable coleccionable, int opcion)
        {
            Console.WriteLine(coleccionable.cuantos());
            Console.WriteLine(coleccionable.minimo());
            Console.WriteLine(coleccionable.maximo());
            Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else Console.WriteLine("El elemento leído no está en la colección");
        }
        //Practica 3 ejercicio 12

        public static void dictadoDeClases(Profesor profe)
        {
            for (int i = 0; i<5;i++)
            {
                profe.hablarALaClase();
                
                profe.escribirEnElPizarron();
            }
        }

    }
}
    


   

    

    
