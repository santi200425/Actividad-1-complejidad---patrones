using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class FabricaDeSuscriptores: FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios nombre= new GeneradorDeDatosAleatorios();
            GeneradorDeDatosAleatorios num = new GeneradorDeDatosAleatorios();

            string nom = nombre.stringAleatorio(5);
            int id = num.numeroAleatorio(9999);
            int mesesDeSuscripcion = num.numeroAleatorio(12);
            int horasVistas = num.numeroAleatorio(24);

            return new Suscriptor(nom, id, mesesDeSuscripcion, horasVistas);
            
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos nombre = new LectorDeDatos();
            LectorDeDatos num = new LectorDeDatos();
            Console.WriteLine("ingresar nombre");
            string nom = nombre.stringPorTeclado();
            Console.WriteLine("ingresar id");
            int id = num.numeroPorTeclado();
            Console.WriteLine("ingresar meses de suscripcion");
            int mesesDeSuscripcion = num.numeroPorTeclado();
            Console.WriteLine("ingresar horas vistas");
            int horasVistas = num.numeroPorTeclado();

            return new Suscriptor(nom, id, mesesDeSuscripcion, horasVistas);
        }
    }
}
