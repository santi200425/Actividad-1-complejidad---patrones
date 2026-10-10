using prueba1.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public class Canal:Comparable, IObservado
    {
        List<IObservador> observadores = new List<IObservador>();
        private string nombre;

        private string ultimoEvento;

        public Canal(string n)
        {
            this.nombre = n;
            this.ultimoEvento = null;
        }

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }

        public void publicarContenido()
        {
            Console.WriteLine($"{nombre} publico contenido nuevo");
            ultimoEvento = "contenido nuevo";
            this.notificar();
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine($"{nombre} esta en vivo");
            ultimoEvento = "en vivo";
            this.notificar();
        }

        public bool sosIgual(Comparable c)
        {
            if(c is Canal)
            {
                Canal c1 = (Canal)c;
                return this.nombre == c1.nombre;
            }
            return false;
        }

        public bool sosMenor(Comparable c)
        {
            if (c is Canal)
            {
                Canal c1 = (Canal)c;
                return this.nombre.Length < c1.nombre.Length;
            }
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            if (c is Canal)
            {
                Canal c1 = (Canal)c;
                return this.nombre.Length > c1.nombre.Length;
            }
            return false;
        }

        public string getUltimoEvento()
        {
            return this.ultimoEvento;
        }

    }
}
