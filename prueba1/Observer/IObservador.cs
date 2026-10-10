using System;
using System.Collections.Generic;
using System.Text;

namespace prueba1.Observer
{
    public interface IObservador
    {
        public void actualizar(IObservado o);
    }
}
