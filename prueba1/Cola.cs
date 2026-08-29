using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Cola:Coleccionable{
        private List<Comparable> elementos;

        public Cola()
        {
            this.elementos = new List<Comparable>();
        }

        public void encolar(Comparable c)
        {
            this.elementos.Add(c);
            Console.WriteLine("elemento encolado");
        }

        public Comparable desencolar()
        {
            if (this.elementos.Count == 0)
            {
                Console.WriteLine("la cola esta vacia");
                return null;
            }

            Comparable c = this.elementos[0];
            this.elementos.RemoveAt(0);
            return c;
        }

        public Comparable frente()
        {
            return this.elementos[0];
        }

        public bool estaVacia()
        {
            if (this.elementos.Count == 0)
            {
                return true;
            }
            return false;
        }

        public int cant_elementos()
        {
            return this.elementos.Count;
        }

        public int cuantos()
        {
            return this.cant_elementos();
        }

        public Comparable minimo()
        {
            Comparable valor_menor = this.elementos[0];
            for(int i=0; i<this.cuantos(); i++)
            {
                if (valor_menor.sosMayor(this.elementos[i]))
                {
                    valor_menor = this.elementos[i];
                }
            }
            return valor_menor;
        }

        public Comparable maximo()
        {
            Comparable valor_mayor = this.elementos[0];
            for (int i=0; i<this.cuantos(); i++)
            {
                if (valor_mayor.sosMenor(this.elementos[i]))
                {
                    valor_mayor = this.elementos[i];
                }
            }
            return valor_mayor;
        }

        public void agregar(Comparable c)
        {
            this.encolar(c);
        }

        public bool contiene(Comparable c)
        {
            for(int i=0; i<this.cuantos(); i++)
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
