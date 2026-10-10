using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class FabricaDeCanales: FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios nombre = new GeneradorDeDatosAleatorios();
            string nom = nombre.stringAleatorio(5);

            return new Canal(nom);
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos nombre = new LectorDeDatos();
            Console.WriteLine("ingresar nombre");
            string nom = nombre.stringPorTeclado();
            return new Canal(nom);
        }
    }
}
