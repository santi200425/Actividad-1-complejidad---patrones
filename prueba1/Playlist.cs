using prueba1.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Playlist: Coleccionable, Iterable
    {
        List<Comparable> elementos;

        public Playlist()
        {
            elementos = new List<Comparable>();
        }

        public Iterador crearIterador()
        {
            return new IteradorPlaylist(elementos);
        }

        public void agregar(Comparable c)
        {
            if (this.pertenece(c))
            {
                this.elementos.Add(c);
            }
        }

        public bool pertenece(Comparable c)
        {
            for(int i=0; i<elementos.Count(); i++)
            {
                if (elementos[i].sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return this.elementos.Count();
        }

        public Comparable minimo()
        {
            Comparable min = elementos[0];
            for(int i=0; i<elementos.Count(); i++)
            {
                if (min.sosMayor(elementos[i]))
                {
                    min = elementos[i];
                }
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = elementos[0];
            for(int i=0; i<elementos.Count(); i++)
            {
                if (max.sosMenor(elementos[i]))
                {
                    max = elementos[i];
                }
            }
            return max;
        }
        public bool contiene(Comparable c)
        {
            for (int i = 0; i < elementos.Count(); i++)
            {
                if (elementos[i].sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
