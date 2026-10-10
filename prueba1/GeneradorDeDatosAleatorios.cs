using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random;

        public GeneradorDeDatosAleatorios()
        {
            random = new Random();
        }

        public int numeroAleatorio(int max)
        {
            int num = random.Next(0, max + 1);
            return num;
        }

        public string stringAleatorio(int cant)
        {
            string caracteres = "abcdefghijklmnñopqrstuvwxyz";

            string resultado = "";
            for(int i=0; i<cant; i++)
            {
                resultado = resultado + caracteres[random.Next(0, caracteres.Length)];
            }

            return resultado;
        }


    }
}
