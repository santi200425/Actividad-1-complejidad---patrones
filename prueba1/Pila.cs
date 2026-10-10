using prueba1.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Pila:Coleccionable, Iterable{
        private List<Comparable> elementos;
        public Pila(){
            this.elementos = new List<Comparable>();
        }

        public Iterador crearIterador()
        {
            return new IteradorPila(elementos);
        }

        public void apilar(Comparable c){
            this.elementos.Add(c);
            Console.WriteLine("elemento apilado");
        }

        public Comparable desapilar() {
            if (this.elementos.Count == 0) {
                return null;
            }
            Comparable c = this.elementos[elementos.Count - 1];
            this.elementos.Remove(c);
            return c;

        }

        public Comparable tope(){
            Comparable c = this.elementos[this.elementos.Count -1];
            return c;

        }

        public bool estaVacia(){
            if (this.elementos.Count == 0){
                return true;

            }
            else{
                return false;
            }

        }

        public int cant_elementos(){
            return this.elementos.Count;
        }

        public int cuantos()
        {
            return this.cant_elementos();
        }

        public Comparable minimo()
        {
            if (this.elementos.Count == 0)
            {
                return null;
            }

            Comparable menor_valor = this.elementos[0];
            for(int i=0; i<this.cuantos(); i++)
            {
                if (menor_valor.sosMayor(this.elementos[i]))
                {
                    menor_valor = this.elementos[i];
                }
            }
            return menor_valor;
        }

        public Comparable maximo()
        {
            if (this.elementos.Count ==0)
            {
                return null;
            }
            Comparable maximo_valor= this.elementos[0];
            for(int i=0; i<this.cuantos(); i++)
            {
                if (maximo_valor.sosMenor(this.elementos[i]))
                {
                    maximo_valor = this.elementos[i];
                }
            }
            return maximo_valor;
        }

        public void agregar(Comparable c)
        {
            apilar(c);
        }

        public bool contiene(Comparable c)
        {
           for (int i=0; i<this.cuantos(); i++)
            {
                if (c.sosIgual(this.elementos[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
