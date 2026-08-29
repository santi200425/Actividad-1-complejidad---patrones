using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    internal class Catalogo:Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public Catalogo(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        {
            int cant_total = this.pila.cuantos() + this.cola.cuantos();
            return cant_total;
        }

        public Comparable minimo()
        {
            Pila aux = new Pila();
            aux.apilar(this.pila.minimo());
            aux.apilar(this.cola.minimo());

            return aux.minimo();
        }

        public Comparable maximo()
        {
            Pila aux = new Pila();
            aux.apilar(this.pila.maximo());
            aux.apilar(this.cola.maximo());
            return aux.maximo();
        }

        public void agregar(Comparable c)
        {

        }

        public bool contiene(Comparable c)
        {
            if (this.pila.contiene(c) || this.cola.contiene(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
