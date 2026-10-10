using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    abstract public class FabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            if (opcion == 1)
            {
                fabrica = new FabricaDeSuscriptores();
            }
            else if(opcion == 2)
            {
                fabrica = new FabricaDeVisualizaciones();
            }
            else
            {
                fabrica = new FabricaDeCanales();
            }
            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            if (opcion == 1)
            {
                fabrica = new FabricaDeSuscriptores();

            }
            else if(opcion == 2)
            {
                fabrica= new FabricaDeVisualizaciones();
            }
            else
            {
                fabrica = new FabricaDeCanales();
            }
            
            return fabrica.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();

        public abstract Comparable crearPorTeclado();
    }
}
