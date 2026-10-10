using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Iterator
{
    public class IteradorPila: Iterador
    {
        private List<Comparable> elementos;
        private int posicionActual;

        public IteradorPila(List<Comparable> lista)
        {
            this.elementos = lista;
            this.primero();
        }

        public void primero()
        {
            posicionActual = elementos.Count -1;
        }

        public void siguiente()
        {
            posicionActual = posicionActual - 1;
        }

        public bool fin()
        {
            return posicionActual < 0;
        }

        public Comparable actual()
        {
            return elementos[posicionActual];
        }



    }
}
