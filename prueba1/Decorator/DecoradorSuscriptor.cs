using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Decorator
{
    abstract public class DecoradorSuscriptor: Mostrable
    {
        protected Mostrable componente;

        public DecoradorSuscriptor(Mostrable c)
        {
            this.componente = c;
        }

        public abstract string mostrarInfo();

        public Suscriptor getSuscriptor()
        {
            return componente.getSuscriptor();
        }
    }
}
