using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Iterator
{
    public class IteradorPlaylist: Iterador
    {
        private List<Comparable> elementos;
        private int posicionActual;

        public IteradorPlaylist(List<Comparable> lista)
        {
            this.elementos = lista;
            this.primero();
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual = posicionActual + 1;

        }

        public bool fin()
        {
            return posicionActual >= elementos.Count;
        }

        public Comparable actual()
        {
            return elementos[posicionActual];
        }
    }
}
