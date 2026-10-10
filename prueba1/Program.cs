using prueba1;
using prueba1.Decorator;
using prueba1.Iterator;
using prueba1.strategy;

class Program
{
    static void Main(string[] args)
    {
        /*//main de ejercicio 13 practica 1
        Pila p = new Pila();
        Cola c = new Cola();
        Catalogo catalogo = new Catalogo(p, c);

        llenarSuscriptores(p);
        llenarSuscriptores(c);
        informar(catalogo);*/

        /*//ejercicio 7 practica 2
        Pila p = new Pila();
        Cola c = new Cola();
        Playlist pl = new Playlist();

        llenarSuscriptores(p);
        llenarSuscriptores(c);
        llenarSuscriptores(pl);
        imprimirElementos(p);
        imprimirElementos(c);
        imprimirElementos(pl);*/

        /*//ejercicio 9 practica 2
        Pila p = new Pila();
        llenarSuscriptores(p);
        cambiarEstrategia(p, new porNombre());
        informar(p);
        cambiarEstrategia(p, new porMesesDeSuscripcion());
        informar(p);
        cambiarEstrategia(p, new porHorasVistas());
        informar(p);
        cambiarEstrategia(p, new porID());
        informar(p);*/

        /*//ejercicio 14 practica 2
        Pila p = new Pila();
        Cola c = new Cola();
        Catalogo catalogo = new Catalogo(p, c);

        // opciones: 1 para suscriptores, 2 para visualizaciones
        llenarFactory(p, 1);
        llenarFactory(c, 1);
        informarFactory(catalogo, 1);*/

        /*//ejecricio 18 practica 2
        Canal canal = (Canal)FabricaDeComparables.crearAleatorio(3);
        Pila p = new Pila();
        llenarFactory(p, 1);
        Iterador ite = ((Iterable)p).crearIterador();
        while (!ite.fin())
        {
            canal.agregarObservador((IObservador)ite.actual());
            ite.siguiente();
        }
        temporadaDeContenido(canal);*/

        /*//ejercicio 21 practica 2
        Suscriptor s1 = new Suscriptor("santiago", 1234, 5, 10);
        DecoradorMesesDeAntiguedad d1 = new DecoradorMesesDeAntiguedad(s1);
        DecoradorNivelDeFanatico d2 = new DecoradorNivelDeFanatico(d1);
        DecoradorEstadoDeCuenta d3 = new DecoradorEstadoDeCuenta(d2);
        DecoradorRecuadro d4 = new DecoradorRecuadro(d3);
        Console.WriteLine(d4.mostrarInfo());*/


        //ejercicio 22 practica 2
        Canal canal = new Canal("CTyPDS UNAJ");
        Pila pila = new Pila();

        for (int i=0; i<10; i++)
        {
            Suscriptor s1 = (Suscriptor)FabricaDeComparables.crearAleatorio(1);
            canal.agregarObservador(s1);
            pila.agregar(s1);
        }

        temporadaDeContenido(canal);

        Iterador ite = ((Iterable)pila).crearIterador();
        while (!ite.fin())
        {
            Suscriptor s = (Suscriptor)ite.actual();
            DecoradorMesesDeAntiguedad d1 = new DecoradorMesesDeAntiguedad(s);
            DecoradorNivelDeFanatico d2 = new DecoradorNivelDeFanatico(d1);
            DecoradorEstadoDeCuenta d3 = new DecoradorEstadoDeCuenta(d2);
            DecoradorRecuadro d4 = new DecoradorRecuadro(d3);
            Console.WriteLine(d4.mostrarInfo());

            ite.siguiente();
        }





    } 
    static void llenar(Coleccionable c)
    { 
        Random r = new Random();
        for (int i = 0; i < 20; i++)
        {
            Comparable c1 = new Visualizacion(r.Next(1, 101));
            c.agregar(c1);
        }
    }

    static void informar(Coleccionable c)
    {
        Comparable min = c.minimo();
        Comparable max = c.maximo();
        Comparable c1;
        if (c.minimo() is Visualizacion)
        {
            Visualizacion v= (Visualizacion)min;
            Visualizacion v2 = (Visualizacion)max;
            Console.WriteLine("cantidad de elementos: " + c.cuantos());
            Console.WriteLine("minimo: " + v.getcantidad());
            Console.WriteLine("maximo: " + v2.getcantidad());
            Console.WriteLine("ingrese un numero");
            int cant = int.Parse(Console.ReadLine());
            c1 = new Visualizacion(cant);
        }
        else if(c.minimo() is Suscriptor)
        {
            Suscriptor v = (Suscriptor)min;
            Suscriptor v2 = (Suscriptor)max;
            Console.WriteLine("cantidad de elementos: " + c.cuantos());
            Console.WriteLine("minimo: " + v.getMesesDeSuscripcion());
            Console.WriteLine("maximo: " + v2.getMesesDeSuscripcion());
            Console.WriteLine("ingrese meses de suscripcion");
            int meses_suscripcion = int.Parse(Console.ReadLine());
            c1 = new Suscriptor("x", 0000, meses_suscripcion, 0);
        }
        else
        {
            Perfil v = (Perfil)min;
            Perfil v2 = (Perfil)max;
            Console.WriteLine("cantidad de elementos: " + c.cuantos());
            Console.WriteLine("minimo: " + v.getId());
            Console.WriteLine("maximo: " + v2.getId());
            Console.WriteLine("ingrese id");
            int id = int.Parse(Console.ReadLine());
            c1 = new Suscriptor("x", id, 0, 0);
        }
        if (c.contiene(c1))
        {
            Console.WriteLine("el elemento leido esta en la coleccion");
        }
        else
        {
            Console.WriteLine("el elemento leido no esta en la coleccion");
        }

    }

    static void llenarSuscriptores(Coleccionable c)
    {
        string[] lista_nombres = {"juan","lucas","ana","matias","maria","pedro","sofia","carlos","laura","micaela","candela","morena","aaron","soledad","jose","aldana","santiago","nicolas","maximo", "agustina", "leo","facundo", "tomas","thiago" };
        
        Random r = new Random();
        IEstrategia nueva_estrategia = new porNombre();

        for(int i=0; i<20; i++)
        {
            Suscriptor s1 = new Suscriptor(lista_nombres[r.Next(0, lista_nombres.Length)], r.Next(1000, 10000), r.Next(1, 13), r.Next(0, 25));
            s1.cambiarComparacion(nueva_estrategia);
            Comparable c1 = (Comparable)s1;
            
            c.agregar(c1);

        }

    }

    static void imprimirElementos(Coleccionable c)
    {
        Iterador ite = ((Iterable)c).crearIterador();
        while (!ite.fin())
        {
            Console.WriteLine(ite.actual().ToString());
            ite.siguiente();
        }
    }

    static void cambiarEstrategia(Coleccionable c, IEstrategia nueva_estrategia)
    {
        Iterador ite = ((Iterable)c).crearIterador();
        while (!ite.fin())
        {
            Suscriptor s = (Suscriptor)ite.actual();
            s.cambiarComparacion(nueva_estrategia);
            ite.siguiente();
        }
    }

    static void llenarFactory(Coleccionable c, int opcion)
    {
        for (int i=0; i<10; i++)
        {
            Comparable c1 = FabricaDeComparables.crearAleatorio(opcion);
            c.agregar(c1);
        }
    }

    static void informarFactory(Coleccionable c, int opcion)
    {
        Console.WriteLine("cantidad de elementos: " + c.cuantos());
        Console.WriteLine("minimo: " + c.minimo());
        Console.WriteLine("maximo: " + c.maximo());
        Comparable c1 = FabricaDeComparables.crearPorTeclado(opcion);

        if (c.contiene(c1))
        {
            Console.WriteLine("el elemento leido esta en la coleccion");
        }
        else
        {
            Console.WriteLine("el elemento leido no esta en la coleccion");
        }
    }

    static void temporadaDeContenido(Canal canal)
    {
        for(int i=0; i<5; i++)
        {
            canal.publicarContenido();
            canal.iniciarEnVivo();
        }
    }
    
}
       