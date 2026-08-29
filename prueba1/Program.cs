using prueba1;

class Program
{
    static void Main(string[] args)
    {
        Pila p = new Pila();
        Cola c = new Cola();
        Catalogo catalogo = new Catalogo(p, c);

        llenarSuscriptores(p);
        llenarSuscriptores(c);
        informar(catalogo);











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

        for(int i=0; i<20; i++)
        {
            Comparable c1 = new Suscriptor(lista_nombres[r.Next(0, lista_nombres.Length)], r.Next(1000, 10000), r.Next(1, 13), r.Next(0, 25));
            c.agregar(c1);
        }

    }
    
}
       