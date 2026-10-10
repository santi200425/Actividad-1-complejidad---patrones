using prueba1.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1
{
    public interface IObservado
    {
        public void agregarObservador(IObservador o);

        public void quitarObservador(IObservador o);

        public void notificar();
    }
}
