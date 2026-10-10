using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class FabricaDeVisualizaciones: FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios num = new GeneradorDeDatosAleatorios();
            int cantidad = num.numeroAleatorio(1000);
            return new Visualizacion(cantidad);
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos num = new LectorDeDatos();
            Console.WriteLine("ingresar cantidad");
            int cantidad = num.numeroPorTeclado();

            return new Visualizacion(cantidad);
        }
    }
}
