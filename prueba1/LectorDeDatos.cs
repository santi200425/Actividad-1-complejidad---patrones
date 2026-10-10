using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public string stringPorTeclado()
        {
            string str = Console.ReadLine();
            return str;
        }
    }
}
